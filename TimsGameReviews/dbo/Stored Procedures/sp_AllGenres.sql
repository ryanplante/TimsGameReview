CREATE PROCEDURE [dbo].[sp_AllGenres]
AS
begin
	set nocount on;
	SELECT * 
	FROM dbo.Genre;
end
