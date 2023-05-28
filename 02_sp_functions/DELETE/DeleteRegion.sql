CREATE PROCEDURE [dbo].[DeleteRegion]
(
@RegionName VARCHAR(50)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION;

--Check if the region exists
IF EXISTS (SELECT * FROM Region WHERE name = @RegionName)
    BEGIN

        --Delete from the dependent tables
        DELETE FROM Tribes WHERE region_name = @RegionName;
        DELETE FROM Secrets WHERE region_name = @RegionName;

        --Delete the region from the Region table
        DELETE FROM Region WHERE name = @RegionName;

        --Change the region of champions to Runeterra (Unknown)
          UPDATE Champion 
            SET region_name ='Runeterra (Unknown)'
            WHERE region_name = @RegionName

        --Commit the transaction
        COMMIT TRANSACTION;
    END
ELSE

    BEGIN
    --If the region doesn't exist, rollback the transaction
    Select 'Region not found, rollbacking transaction.' As Result
    ROLLBACK TRANSACTION;
END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION;      
    END CATCH
    
END