CREATE PROCEDURE [dbo].[CreateAdmin]
@Username varchar(50),
@Password varchar(50)
AS
BEGIN
BEGIN TRY
    IF NOT EXISTS (SELECT * FROM Admin WHERE username = @Username)
        BEGIN
                INSERT INTO Admin VALUES(@Username, HASHBYTES('SHA2_512', @Password))
                SELECT 'New Admin created.' AS Result
        END
    ELSE
        BEGIN
           SELECT 'Username already taken. Please choose another username.' AS Result
        END
END TRY
    BEGIN CATCH
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
    END CATCH

END