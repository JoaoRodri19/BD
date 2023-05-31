CREATE FUNCTION Ds3.GetHighestID ()
RETURNS INT
AS
BEGIN
    DECLARE @maxID INT;
    @maxID = SELECT max(id) FROM Ds3.Personagem
    RETURN @maxID+1;
END;