CREATE PROCEDURE [dbo].[spItem_Delete]
	@Id INT
AS
BEGIN

	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Item]
	WHERE [Id] = @Id;

END