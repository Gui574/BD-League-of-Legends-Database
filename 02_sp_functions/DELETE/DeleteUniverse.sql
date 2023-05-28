CREATE PROCEDURE [dbo].[DeleteUniverse]
(
@UniverseName VARCHAR(25)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION;

--Check if the universe exists
IF EXISTS (SELECT * FROM Alternate_Universe WHERE name = @UniverseName)
    BEGIN

        --Delete from the dependent tables
        DELETE FROM Stories WHERE universe_name = @UniverseName;
        DELETE FROM Exists_On WHERE universe_name = @UniverseName;

         --Delete the universe from the Alternate_universe table
        DELETE FROM Alternate_Universe WHERE name = @UniverseName;

        --Commit the transaction
        COMMIT TRANSACTION;
    END
ELSE

    BEGIN
    --If the universe doesn't exist, rollback the transaction
    SELECT 'Alternate Universe not found, rollbacking transaction.' AS Result
    ROLLBACK TRANSACTION;
END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION;        
    END CATCH
    
END