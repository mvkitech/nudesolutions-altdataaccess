CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Sequence] INT NOT NULL,
    [Code] NCHAR(3) NOT NULL,
    [Description] NVARCHAR(50) NOT NULL, 
    [TotalLimits] INT NOT NULL	
)
