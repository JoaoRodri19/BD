-- Trigger for Localizacao table
CREATE TRIGGER LocalizacaoSaveLimit
ON Localizacao
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @num INT;
	SELECT @num = COUNT(*) FROM Ds3.Saves;
	IF (@num > 7)
	BEGIN
		RAISERROR('Excedeu o limite de saves', 16, 1);
		ROLLBACK TRAN;
	END
END;

-- Trigger for Saves table
CREATE TRIGGER SavesSaveLimit
ON Saves
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @num INT;
	SELECT @num = COUNT(*) FROM Ds3.Saves;
	IF (@num > 7)
	BEGIN
		RAISERROR('Excedeu o limite de saves', 16, 1);
		ROLLBACK TRAN;
	END
END;

-- Trigger for Jogador table
CREATE TRIGGER JogadorSaveLimit
ON Jogador
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @num INT;
	SELECT @num = COUNT(*) FROM Ds3.Saves;
	IF (@num > 7)
	BEGIN
		RAISERROR('Excedeu o limite de saves', 16, 1);
		ROLLBACK TRAN;
	END
END;
