CREATE PROCEDURE [dbo].[ChampParticipesStory]

@champion_name		VARCHAR(25),
@stories_title		VARCHAR(70)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION;
    INSERT INTO Participates VALUES (@champion_name, @stories_title)
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION;     
    END CATCH

END
