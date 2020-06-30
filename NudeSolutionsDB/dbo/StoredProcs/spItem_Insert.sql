CREATE PROCEDURE [dbo].[spItem_Insert]
	@CategoryId INT,
	@ItemDesc NVARCHAR(50),
	@ItemLimit INT,
	@Id int output
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.[Item] ([CategoryId], [ItemDesc], [ItemLimit])
	VALUES (@CategoryId, @ItemDesc, @ItemLimit);

	SET @Id = SCOPE_IDENTITY();

END