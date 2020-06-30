CREATE PROCEDURE [dbo].[spItem_GetById]
	@Id INT
AS
BEGIN

	SET NOCOUNT ON;

	SELECT [Id], [CategoryId], [ItemDesc], [ItemLimit]
	FROM dbo.[Item]
	WHERE [Id] = @Id;

END