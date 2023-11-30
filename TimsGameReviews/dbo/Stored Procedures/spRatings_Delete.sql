CREATE PROCEDURE [dbo].[spRatings_Delete]
@Id int
AS 
begin

	set nocount on;

	DELETE
	FROM dbo.[Rating]
	WHERE Id = @Id;

end
