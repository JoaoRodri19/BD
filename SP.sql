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
CREATE PROCEDURE GetBossByAttributeName @entity NVARCHAR(MAX),@attribute NVARCHAR(MAX), @filter NVARCHAR(MAX)
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
		+ QUOTENAME(@entity) + '.' + QUOTENAME(@attribute) + ' LIKE ''%' + @filter +'%'';';

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
    DELETE FROM ds3.Item_Personagem WHERE Personagem = @PER_ID;
    DELETE FROM ds3.Personagem WHERE Personagem = @PER_ID;
    DELETE FROM ds3.Localizacao WHERE Coordenadas = @PER_LOC;
END;

CREATE PROCEDURE GetJogador
AS
BEGIN
	SELECT Nome FROM ds3.Saves 
					 JOIN ds3.Jogador ON Saves.Jogador = Jogador.Personagem 
					 JOIN ds3.Personagem ON Jogador.Personagem = Personagem.ID;
END;

CREATE PROCEDURE InsertItem
    @ID_Item INT,
    @Nome_Personagem VARCHAR(50)
AS
BEGIN
    DECLARE @ID_Personagem INT
    SELECT @ID_Personagem = ID FROM ds3.Personagem WHERE Nome = @Nome_Personagem

    INSERT INTO ds3.Item_Personagem (Item, Personagem) 
    VALUES (@ID_Item, @ID_Personagem)
END;

GO;

CREATE PROCEDURE DeleteItem_Personagem @Item_ID INT, @Nome_Personagem varchar(50)
AS
BEGIN
	DECLARE @ID_Personagem INT
	SET @ID_Personagem = (SELECT ID FROM ds3.Personagem WHERE Personagem.Nome = @Nome_Personagem);
	DELETE FROM ds3.Item_Personagem WHERE Item_Personagem.Item = @Item_ID AND Item_Personagem.Personagem = @ID_Personagem;
END;

-------------------------------------------------------------------------------------------------------------------------
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
DROP PROCEDURE IF EXISTS GetJogador;
DROP PROCEDURE IF EXISTS InsertItem;
DROP PROCEDURE IF EXISTS DeleteItem_Personagem;


-- exec
exec GetBossByName @name = 'ar'



-- exec
exec GetAllSavesInformation
exec GetBossByName @name = 'ar'
exec GetBossInformation
exec GetBossByHp @hp_ini = 1, @hp_fim = 2000
exec GetBossByAttributeName @entity = 'Zona', @attribute = 'Nome', @filter = 'Ash';
exec GetAllBossInformation
exec InsertBoss @Nome ='TESTE',@Pontos_De_Vida= 10000,@Drops = 'TESTE',
@Fraqueza ='TESTE', @Resistencia ='TESTE', @Imunidade ='TESTE',
@Trilha_Sonora ='TESTE', @Dialogo ='TESTE',@Nome_Zona ='TESTE', @Coordenadas ='TESTE'

exec InsertSave @Ultima_localizacao ='1,1,1',@Horas =2 ,@Item_Discovery = 0,@Stamina = 0,
@Classe= 'TESTE', @Equip_Load = 0, @Focus_Points = 0, @Nivel = 0, @Nome='CABOCA',@Zona='TESTE',
@Pontos_De_Vida = 0
exec GetJogador;
exec InsertItem @Nome_Personagem = 'Aim_A_Cat', @ID_Item = 34
exec DeleteItem_Personagem @Item_ID = 1, @Nome_Personagem = 'Aim_A_Cat';

SELECT * FROM ds3.Item_Personagem

SELECT * FROM ds3.Item

SELECT * FROM ds3.Personagem

SELECT
    *
  FROM
    ds3.Boss
    JOIN ds3.Adversario ON Boss.Adversario = Adversario.Personagem
    JOIN ds3.Personagem ON ID = Adversario.Personagem
    JOIN ds3.Localizacao_Adversario ON Adversario.Personagem = Localizacao_Adversario.Adversario
    JOIN ds3.Localizacao ON Localizacao.Coordenadas = Localizacao_Adversario.Localizacao
    JOIN ds3.Zona ON Zona.Nome = Localizacao.Zona