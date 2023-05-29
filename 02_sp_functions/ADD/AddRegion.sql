CREATE PROCEDURE [dbo].[AddRegion]

@name			VARCHAR(50),
@emblem			VARCHAR(350)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    INSERT INTO Region VALUES (@name, @emblem)
    SELECT 'Success' AS Result
    COMMIT TRANSACTION
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION    
    END CATCH



END
