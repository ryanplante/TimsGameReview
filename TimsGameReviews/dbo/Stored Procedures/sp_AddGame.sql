CREATE PROCEDURE [dbo].[spAddGame]
    @Title NVARCHAR(50),
    @Description NVARCHAR(MAX),
    @Price FLOAT,
    @Genre INT,
    @Id INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
       -- If not exists, then insert the new review
     INSERT INTO dbo.VideoGames (Title, Description, Price, Genre)
        VALUES (@Title, @Description, @Price, @Genre);

        SET @Id = SCOPE_IDENTITY();
    END;

