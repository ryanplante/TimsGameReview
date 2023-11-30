CREATE TABLE [dbo].[Rating]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustID] INT NULL, 
    [GameID] INT NULL, 
    [Rating] FLOAT NULL, 
    [Review] NVARCHAR(MAX) NULL
)
