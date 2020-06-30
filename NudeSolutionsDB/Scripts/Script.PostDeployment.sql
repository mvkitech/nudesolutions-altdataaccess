/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script
 and the purpose will be to insert rows into the Coverage and Category tables
 ensuring all data considered static in the context of this sample application
 exists in the database prior to the application launching for the first time.

 Please note that had this been a real world production candidate system, this
 data would likely be supported via Admin Configuration components and I likely
 would have used a different strategy towards per populating the database.
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT * FROM dbo.Category)
BEGIN
	INSERT INTO dbo.Category ([Sequence], [Code], [Description], [TotalLimits])
	VALUES (1, 'ELE', 'Electronics', 0),
	       (2, 'CLO', 'Clothing', 0),
           (3, 'KIT', 'Kitchen', 0);
END
