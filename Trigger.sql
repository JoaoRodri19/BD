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
		RAISERROR('Save limit exceeded', 16, 1);
		ROLLBACK TRAN;
	END
END;

GO

CREATE Trigger CheckItemExists
ON Ds3.Item_Personagem
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @ID_Item int;
	DECLARE @ID_Personagem int;
	SELECT @ID_Item = Item, @ID_Personagem = Personagem FROM inserted;
	IF (@ID_Item NOT IN (SELECT ID FROM Ds3.Item))
		BEGIN
			RAISERROR('This item does not exist', 16, 1);
		END
	ELSE
		BEGIN
			INSERT INTO ds3.Item_Personagem(Item, Personagem) 
			VALUES (@ID_Item, @ID_Personagem);
		END;
	
END;

GO
DROP TRIGGER Ds3.CheckItemExists
