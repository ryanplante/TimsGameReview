CREATE PROCEDURE [dbo].[sp_AllGames]
AS
begin
	set nocount on;
	SELECT [Id], [Title], [Description], [Price], [Genre]
	FROM dbo.VideoGame;
end
