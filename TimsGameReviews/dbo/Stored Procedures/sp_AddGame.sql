CREATE PROCEDURE [dbo].[sp_AddGame]
    @Title NVARCHAR(50),
    @Description NVARCHAR(MAX),
    @Price FLOAT,
    @Genre INT,
    @Id INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
       -- If not exists, then insert the new review
     INSERT INTO dbo.[VideoGame] (Title, Description, Price, Genre)
        VALUES (@Title, @Description, @Price, @Genre);

        SET @Id = SCOPE_IDENTITY();
    END;

