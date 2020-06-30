CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryId] INT NOT NULL, 
    [ItemDesc] NVARCHAR(50) NOT NULL, 
    [ItemLimit] INT NOT NULL, 
    CONSTRAINT [FK_Item_ToCategory] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id])
)
