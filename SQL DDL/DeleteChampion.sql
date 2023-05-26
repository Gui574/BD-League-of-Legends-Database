CREATE PROCEDURE [dbo].[DeleteItem]
(
@ItemId INT
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION;

--Check if the item exists
IF EXISTS (SELECT * FROM Items WHERE ItemId = @ItemId)
BEGIN
--Delete the item from the Items table
DELETE FROM Items WHERE ItemId = @ItemId;

--Delete the corresponding records from the dependent tables
DELETE FROM Orders WHERE ItemId = @ItemId;
DELETE FROM Sales WHERE ItemId = @ItemId;

--Commit the transaction
COMMIT TRANSACTION;
END
ELSE
BEGIN
--If the item doesn't exist, rollback the transaction
ROLLBACK TRANSACTION;
END
END TRY

BEGIN CATCH
--If there's a problem with the transaction, rollback the transaction
ROLLBACK TRANSACTION;
--Handle the error
END CATCH
END