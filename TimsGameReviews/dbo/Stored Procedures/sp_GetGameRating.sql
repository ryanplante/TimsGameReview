CREATE PROCEDURE [dbo].[spGetGameRating]
    @GameID INT,
    @AverageRating FLOAT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate the average rating for the specified GameID
    SELECT AVG(Rating)
    FROM dbo.[Rating]
    WHERE GameID = @GameID;
END;
