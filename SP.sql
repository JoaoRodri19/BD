-------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetBossInformation
AS
BEGIN
  SELECT
    Personagem.nome AS "Boss Name",
    Pontos_De_Vida AS "HP",
    Zona.nome AS "Zona"
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona;
END;
GO
--------------------------------------------------------------------------------------------------------
-- all info
CREATE PROCEDURE GetAllBossInformation
AS
BEGIN
  SELECT
    *
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona;
END;
GO
-------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetBossByHp @hp_ini int, @hp_fim int
AS
BEGIN
SELECT
    Personagem.nome AS "Boss Name",
    Pontos_De_Vida AS "HP",
    Zona.nome AS "Zona"
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona
    where Pontos_De_Vida > @hp_ini and Pontos_De_Vida < @hp_fim
END;
GO
---------------------------------------------------------------------------------------------
CREATE PROCEDURE GetBossByName @name varchar(30)
AS
BEGIN
SELECT
    Personagem.nome AS "Boss Name",
    Pontos_De_Vida AS "HP",
    Zona.nome AS "Zona"
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona
    where Personagem.Nome LIKE '%'+ @name+'%'
END;
GO
----------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetBossByAttributeName @entity varchar(30) ,@attribute varchar(30), @name varchar(30)
AS
BEGIN
	
	DECLARE @Query NVARCHAR(MAX);

	SET @Query = '
	
	SELECT
		Personagem.nome AS "Boss Name",
		Pontos_De_Vida AS "HP",
		Zona.nome AS "Zona"
	FROM
		ds3.Boss
		JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
		JOIN ds3.Personagem ON ID = Adversario.Personagem
		JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
		JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
		JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona
	WHERE ' 
		+ QUOTENAME(@attribute) + ' LIKE ''%' + QUOTENAME(@name) +'%'';';

	EXEC sp_executesql @Query;
END;

GO
-----------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetBossByName @name varchar(30)
AS
BEGIN
SELECT
    Personagem.nome AS "Boss Name",
    Pontos_De_Vida AS "HP",
    Zona.nome AS "Zona"
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona
	where Personagem.Nome LIKE '%'+ @name+'%'
END;
GO
-------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE InsertBoss @Nome varchar(50),@Pontos_De_Vida int,@Drops varchar(30),
@Fraqueza varchar(30), @Resistencia varchar(30), @Imunidade varchar(30),
@Trilha_Sonora varchar(30), @Dialogo text,@Nome_Zona varchar(50), @Coordenadas varchar(20)
AS
BEGIN
	DECLARE @ID int
	SET @ID = Ds3.GetHighestID()
	INSERT INTO Ds3.Personagem (ID, Nome, Pontos_De_Vida) VALUES (@ID, @Nome,@Pontos_De_Vida)
	INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
	VALUES (@Drops,@Fraqueza,@Resistencia,@Imunidade,@ID)
	INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
	VALUES (@Trilha_Sonora,@Dialogo,@ID)
	
	IF NOT EXISTS (
    SELECT 1
    FROM ds3.Zona
    WHERE Nome = @Nome_Zona
)
BEGIN
    INSERT INTO ds3.Zona (Nome, Trilha_Sonora)
    VALUES (@Nome_Zona, @Trilha_Sonora)

END;
IF NOT EXISTS (
    SELECT 1
    FROM ds3.Zona
    WHERE Nome = @Nome_Zona
)
BEGIN
    INSERT INTO ds3.Localizacao (Item, Zona, Coordenadas)
    VALUES (null, @Nome_Zona, @Coordenadas)
END;


	INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
	VALUES (@ID,@Coordenadas)
	
END
GO
------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetAllSavesInformation
AS
BEGIN
  SELECT
    *
  FROM
    Ds3.Saves
	JOIN Ds3.Jogador on Saves.Jogador = Jogador.Personagem
	JOIN Ds3.Personagem on Personagem.ID = Jogador.Personagem
END;
GO
------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE InsertSave @Ultima_localizacao varchar(20),@Horas varchar(20) ,@Item_Discovery int,@Stamina int,
@Classe varchar(20), @Equip_Load int, @Focus_Points int, @Nivel int, @Nome varchar(50),@Zona varchar(50),
@Pontos_De_Vida int
AS
BEGIN
	DECLARE @ID_Save int,@ID int
	SET @ID = Ds3.GetHighestID()
	SET @ID_Save = Ds3.GetHighestIDSave()
	
	IF NOT EXISTS (
    SELECT 1
    FROM ds3.Localizacao
    WHERE Coordenadas = @Ultima_localizacao)
	BEGIN
    INSERT INTO ds3.Localizacao (Item, Zona, Coordenadas)
    VALUES (null, @Zona, @Ultima_localizacao)
	END;

	INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
	VALUES (@Nome,@Pontos_De_Vida,@ID)

	INSERT INTO ds3.Jogador(Personagem,Item_Discovery,Stamina,Classe,Equip_Load,Focus_Points,Nivel)
	VALUES (@ID,@Item_Discovery,@Stamina,@Classe,@Equip_Load,@Focus_Points,@Nivel)

	INSERT INTO ds3.Saves(Horas,ID,Ultima_localizacao,Jogador)
	VALUES (DATEADD(HOUR, CAST(@Horas AS int), CAST('00:00:00' AS TIME)),@ID_Save,@Ultima_Localizacao,@ID)

END;
GO
--------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE DeleteBoss @ID int
AS
BEGIN
    DELETE ds3.Boss WHERE Adversario=@ID;
    DELETE ds3.Localizacao_Adversario WHERE Adversario=@ID;
    DELETE ds3.Adversario WHERE Personagem=@ID;
    DELETE ds3.Item_Personagem WHERE Personagem=@ID;
    DELETE ds3.Personagem WHERE ID=@ID;
END;
--------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE DeleteSave @ID int
AS
BEGIN
    DECLARE @PER_ID int;
    SET @PER_ID = (SELECT Jogador FROM ds3.Saves WHERE ID = @ID);
    DECLARE @PER_LOC varchar(20);
    SET @PER_LOC = (SELECT Ultima_localizacao FROM ds3.Saves WHERE ID = @ID);
    
    DELETE FROM ds3.Saves WHERE ID = @ID;
    DELETE FROM ds3.Jogador_Atributos WHERE Jogador = @PER_ID;
    DELETE FROM ds3.Jogador WHERE Personagem = @PER_ID;
    DELETE FROM ds3.Item_Personagem WHERE Item_Personagem.Personagem = @PER_ID;
    DELETE FROM ds3.Personagem WHERE ID = @PER_ID;
END;
-----------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetArmaduraByName @Nome varchar(50)
AS
BEGIN
	DECLARE @ID int;
	SET @ID = (SELECT ID FROM Ds3.Personagem WHERE Nome = @Nome)
	SELECT * FROM Ds3.Armadura 
	JOIN Ds3.Item_Equipavel on Ds3.Armadura.Item_Equipavel = Item_Equipavel.Item 
	JOIN Ds3.Item on Item_Equipavel.Item = Item.ID
	JOIN Ds3.Item_Personagem on Item_Personagem.Personagem = @ID
	WHERE ID = Item_Personagem.Item

END;
-------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE GetArmaByName @Nome varchar(50)
AS
BEGIN
	DECLARE @ID int;
	SET @ID = (SELECT ID FROM Ds3.Personagem WHERE Nome = @Nome)
	SELECT * FROM Ds3.Arma 
	JOIN Ds3.Item_Equipavel on Ds3.Arma.Item_Equipavel = Item_Equipavel.Item 
	JOIN Ds3.Item on Item_Equipavel.Item = Item.ID
	JOIN Ds3.Item_Personagem on Item_Personagem.Personagem = @ID
	WHERE ID = Item_Personagem.Item

END;
------------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE GetItemNaoEquipavelByName @Nome varchar(50)
AS
BEGIN
	DECLARE @ID int;
	SET @ID = (SELECT ID FROM Ds3.Personagem WHERE Nome = @Nome)
	SELECT * FROM Ds3.Item_Nao_Equipavel 
	JOIN Ds3.Item on Item_Nao_Equipavel.Item = Item.ID
	JOIN Ds3.Item_Personagem on Item_Personagem.Personagem = @ID
	WHERE ID = Item_Personagem.Item

END;
---------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE GetArmadura
AS
BEGIN
	
	SELECT * FROM Ds3.Armadura 
	JOIN Ds3.Item_Equipavel on Ds3.Armadura.Item_Equipavel = Item_Equipavel.Item 
	JOIN Ds3.Item on Item_Equipavel.Item = Item.ID
	

END;
-------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE GetArma
AS
BEGIN
	
	SELECT * FROM Ds3.Arma 
	JOIN Ds3.Item_Equipavel on Ds3.Arma.Item_Equipavel = Item_Equipavel.Item 
	JOIN Ds3.Item on Item_Equipavel.Item = Item.ID
	

END;
------------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE GetItemNaoEquipavel 
AS
BEGIN
	
	SELECT * FROM Ds3.Item_Nao_Equipavel 
	JOIN Ds3.Item on Item_Nao_Equipavel.Item = Item.ID
	
	

END;
---------------------------------------------------------------------------------------------------------------------------------------------------------


-- drop sp
DROP PROCEDURE IF EXISTS GetBossInformation;
DROP PROCEDURE IF EXISTS GetAllBossInformation;
DROP PROCEDURE IF EXISTS GetBossByHp;
DROP PROCEDURE IF EXISTS GetBossByName;
DROP PROCEDURE IF EXISTS GetBossByAttributeName;
DROP PROCEDURE IF EXISTS GetAllSavesInformation
DROP PROCEDURE IF EXISTS InsertBoss;
DROP PROCEDURE IF EXISTS GetBossByHp;
DROP PROCEDURE IF EXISTS GetBossByName;
DROP PROCEDURE DeleteSave
DROP PROCEDURE GetArmaduraByName
DROP PROCEDURE GetArmaByName
DROP PROCEDURE GetItemNaoEquipavelByName

-- exec
exec GetBossByName @name = 'ar'



-- exec
exec GetItemNaoEquipavelByName 'Aim_A_Cat'
exec GetAllSavesInformation
exec GetBossByName @name = 'ar'
exec GetBossInformation
exec GetBossByHp @hp_ini = 1, @hp_fim = 2000
exec GetBossByAttributeName @entity = '', @attribute = 'Zona.Nome', @name = 'Ash';
exec GetAllBossInformation
exec InsertBoss @Nome ='TESTE',@Pontos_De_Vida= 10000,@Drops = 'TESTE',
@Fraqueza ='TESTE', @Resistencia ='TESTE', @Imunidade ='TESTE',
@Trilha_Sonora ='TESTE', @Dialogo ='TESTE',@Nome_Zona ='TESTE', @Coordenadas ='TESTE'

exec InsertSave @Ultima_localizacao ='1,1,1',@Horas =2 ,@Item_Discovery = 0,@Stamina = 0,
@Classe= 'TESTE', @Equip_Load = 0, @Focus_Points = 0, @Nivel = 0, @Nome='CABOCA',@Zona='TESTE',
@Pontos_De_Vida = 0

exec DeleteSave 6
SELECT * from Ds3.arma
exec GetAByName 'Aim_A_Cat'
select * from Ds3.Item_Personagem

SELECT
    *
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona