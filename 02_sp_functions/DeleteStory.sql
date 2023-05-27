CREATE PROCEDURE [dbo].[DeleteStory]
(
@StoryName VARCHAR(70)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION;

--Check if the story exists
IF EXISTS (SELECT * FROM Stories WHERE title = @StoryName)
    BEGIN

         --Delete from the dependent tables
        DELETE FROM Participates WHERE stories_title = @StoryName;

        --Delete the story from the Stories table
        DELETE FROM Stories WHERE title = @StoryName;

        --Commit the transaction
        COMMIT TRANSACTION;
    END
ELSE

 BEGIN
    --If the region doesn't exist, rollback the transaction
    PRINT 'Story not found, rollbacking transaction.'
    ROLLBACK TRANSACTION;
END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        PRINT '[ERROR] ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;       
    END CATCH
    
END