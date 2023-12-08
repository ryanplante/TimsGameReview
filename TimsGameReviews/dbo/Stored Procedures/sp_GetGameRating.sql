CREATE PROCEDURE [dbo].[spGetGameRating]
    @GameID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Get all records, the API will average them.
    SELECT Rating
    FROM dbo.[Rating]
    WHERE GameID = @GameID;
END;
