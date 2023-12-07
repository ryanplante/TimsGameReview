CREATE PROCEDURE [dbo].[spGame_Delete]
@Id int
AS 
begin

	set nocount on;

	DELETE
	FROM dbo.[VideoGame]
	WHERE Id = @Id;

end