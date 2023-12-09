CREATE PROCEDURE [dbo].[sp_GameByID]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM dbo.[VideoGame]
    WHERE Id = @Id;
END;
