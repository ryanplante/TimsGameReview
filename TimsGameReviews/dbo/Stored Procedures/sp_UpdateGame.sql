CREATE PROCEDURE [dbo].[sp_UpdateGame]
    @Id INT,
    @Title NVARCHAR(50),
    @Description NVARCHAR(MAX),
    @Price FLOAT,
    @Genre INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update the game details for the given Id
    UPDATE dbo.VideoGame
    SET Title = @Title,
        Description = @Description,
        Price = @Price,
        Genre = @Genre
    WHERE Id = @Id;
END;
GO
