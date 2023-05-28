CREATE PROCEDURE [dbo].[AddChampion]

@name VARCHAR(25),
@gender VARCHAR(6),
@description VARCHAR(50),
@species VARCHAR(30),
@region_name VARCHAR(50),
@splashArt VARCHAR(350),	
@quote VARCHAR(200),	
@releaseDate DATE,

@P_name				VARCHAR(50),
@P_description		VARCHAR(MAX),

@Q_name				VARCHAR(50),
@Q_description		VARCHAR(MAX),

@W_name				VARCHAR(50),
@W_description		VARCHAR(MAX),

@E_name				VARCHAR(50),
@E_description		VARCHAR(MAX),

@R_name				VARCHAR(50),
@R_description		VARCHAR(MAX),

@stories_title      VARCHAR(70),

@universe_name      VARCHAR(25)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION;
    INSERT INTO Champion VALUES (@name, @gender, @description, @species,@region_name,@splashArt,@quote,@releaseDate)
    INSERT INTO Abilities VALUES (@name, @P_name, @P_description, @Q_name, @Q_description, @W_name, @W_description, @E_name, @E_description, @R_name, @R_description)

    IF @stories_title IS NOT NULL
        BEGIN
            INSERT INTO Participates VALUES (@name, @stories_title)
        END
    
    IF @universe_name IS NOT NULL
        BEGIN
            INSERT INTO Exists_On VALUES (@name, @universe_name)
        END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION;     
    END CATCH

END