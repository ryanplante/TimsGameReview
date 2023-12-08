CREATE PROCEDURE [dbo].[sp_GameByID]
    @GameID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM dbo.[Rating]
    WHERE GameID = @GameID;
END;
