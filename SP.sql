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


-- drop sp
DROP PROCEDURE IF EXISTS GetBossInformation;
DROP PROCEDURE IF EXISTS GetBossByHp;
DROP PROCEDURE IF EXISTS GetBossByName;
DROP PROCEDURE GetAllBossInformation
DROP PROCEDURE InsertBoss

-- exec
exec GetBossByName @name = 'ar'
exec GetBossInformation
exec GetBossByHp @hp_ini = 1, @hp_fim = 2000
exec GetAllBossInformation
exec InsertBoss @Nome ='TESTE',@Pontos_De_Vida= 10000,@Drops = 'TESTE',
@Fraqueza ='TESTE', @Resistencia ='TESTE', @Imunidade ='TESTE',
@Trilha_Sonora ='TESTE', @Dialogo ='TESTE',@Nome_Zona ='TESTE', @Coordenadas ='TESTE'

DECLARE @highestID INT;
EXEC @highestID = Ds3.GetHighestID 'Personagem';
SELECT @highestID AS HighestID;
