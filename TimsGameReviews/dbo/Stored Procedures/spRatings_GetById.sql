CREATE PROCEDURE [dbo].[spRatings_GetById]
	@Id int
AS

begin

	set nocount on;

	SELECT *
	FROM dbo.[Rating]
	WHERE Id = @Id;

end