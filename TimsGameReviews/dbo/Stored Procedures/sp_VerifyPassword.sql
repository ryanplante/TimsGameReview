CREATE PROCEDURE [dbo].[sp_VerifyPassword]
    @UName NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM [dbo].[Users]
    WHERE [UName] = @UName AND [Password] = @Password
END;
