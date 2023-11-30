CREATE PROCEDURE [dbo].[spAddReview]
    @CustID INT,
    @GameID INT,
    @Rating FLOAT,
    @Review NVARCHAR(MAX),
    @Id INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if a review with the same customer ID and game ID already exists
    IF NOT EXISTS (SELECT 1 FROM dbo.[Rating] WHERE CustID = @CustID AND GameID = @GameID)
    BEGIN
        -- If not exists, then insert the new review
        INSERT INTO dbo.[Rating] (CustID, GameID, Rating, Review)
        VALUES (@CustID, @GameID, @Rating, @Review);

        SET @Id = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        -- If a review already exists, set @Id to -1 to indicate failure)
        SET @Id = -1;
    END
END;
