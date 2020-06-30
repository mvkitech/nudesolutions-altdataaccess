CREATE PROCEDURE [dbo].[spItem_Update]
	@Id INT,
	@ItemDesc NVARCHAR(50),
	@ItemLimit INT
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.[Item]
	SET [ItemDesc] = @ItemDesc, [ItemLimit] = @ItemLimit
	WHERE [Id] = @Id;

END