CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UName] NVARCHAR(50) NULL, 
    [PermissionLevel] INT NULL, 
    [Password] NVARCHAR(50) NULL
)
