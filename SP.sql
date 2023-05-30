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

-- drop sp
DROP PROCEDURE IF EXISTS GetBossInformation;
exec GetBossInformation
exec GetBossByHp @hp_ini = 1, @hp_fim = 2000
