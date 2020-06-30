CREATE PROCEDURE [dbo].[spCategories_GetAll]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT c.Sequence, c.Code, c.Description, c.TotalLimits, i.ItemDesc, i.ItemLimit
	FROM dbo.Category c
	LEFT JOIN dbo.item i on c.id = i.CategoryId
	ORDER BY c.Sequence;

END
