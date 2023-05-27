CREATE PROCEDURE [dbo].[DeleteChampion]
(
@ChampName VARCHAR(25)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION;

--Check if the champion exists
IF EXISTS (SELECT * FROM Champion WHERE name = @ChampName)
    BEGIN

        --Delete from the dependent tables
        DELETE FROM Participates WHERE champion_name = @ChampName;
        DELETE FROM Exists_On WHERE champion_name = @ChampName;
        DELETE FROM Abilities WHERE champion_name = @ChampName;

        --Delete the champion from the Champion table
        DELETE FROM Champion WHERE name = @ChampName;

        --Commit the transaction
        COMMIT TRANSACTION;
    END
ELSE

    BEGIN
    --If the champion doesn't exist, rollback the transaction
    PRINT 'Champion not found, rollbacking transaction.'
    ROLLBACK TRANSACTION;
END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        PRINT '[ERROR] ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;     
    END CATCH
    
END