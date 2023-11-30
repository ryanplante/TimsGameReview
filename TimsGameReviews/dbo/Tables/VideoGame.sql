CREATE TABLE [dbo].[VideoGame]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Genre] INT NOT NULL
)
