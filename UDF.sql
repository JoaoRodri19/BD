CREATE FUNCTION Ds3.GetHighestID()
RETURNS INT
AS
BEGIN
    DECLARE @maxID INT;

    SELECT @maxID = MAX(id) FROM Ds3.Personagem;

    SET @maxID = ISNULL(@maxID, 0) + 1;

    RETURN @maxID;
END;
GO
-------------------------------------------------------------------------------------------------------------
CREATE FUNCTION Ds3.GetHighestIDSave()
RETURNS INT
AS
BEGIN
    DECLARE @maxID INT;

    SELECT @maxID = MAX(id) FROM Ds3.Saves;

    SET @maxID = ISNULL(@maxID, 0) + 1;

    RETURN @maxID;
END;
GO
