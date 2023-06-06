-- Trigger for Localizacao table
CREATE TRIGGER LocalizacaoSaveLimit
ON Ds3.Localizacao
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
GO
-- Trigger for Saves table
CREATE TRIGGER SavesSaveLimit
ON Ds3.Saves
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
GO
-- Trigger for Jogador table
CREATE TRIGGER JogadorSaveLimit
ON Ds3.Jogador
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

GO
-- Trigger for Item_Personagem
CREATE TRIGGER Item_Personagem_Limit
ON Ds3.Item_Personagem
INSTEAD OF INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @ID_Item INT;
	SELECT @ID_Item = (SELECT Item FROM INSERTED);
	DECLARE @ID_Per INT;
	SELECT @ID_Per = (SELECT Personagem FROM INSERTED);

	IF(@ID_Per IN (SELECT Personagem FROM ds3.Item_Personagem WHERE Item_Personagem.Item = @ID_Item))
	BEGIN
		IF (@ID_Item IN (SELECT Item FROM ds3.Item_Nao_Equipavel))
		BEGIN
			DECLARE @quantity tinyint;
			SELECT @quantity = Quantidade FROM ds3.Item_Nao_Equipavel WHERE Item_Nao_Equipavel.Item = @ID_Item
			IF(@quantity = 99)
			BEGIN
				RAISERROR('The quantity limit for this item has been exceeded', 16, 1);
				RETURN
			END
			ELSE
			BEGIN
				UPDATE ds3.Item_Nao_Equipavel 
				SET Quantidade = (@quantity+1)
				WHERE Item_Nao_Equipavel.Item = @ID_Item
			END

		END
		ELSE
		BEGIN
			RAISERROR('The quantity limit for this item has been exceeded', 16, 1);
			RETURN
		END
	END
	
	INSERT INTO ds3.Item_Personagem(Item,Personagem)
	VALUES(@ID_Item,@ID_Per)
END;
DROP TRIGGER Item_Personagem_Limit
GO