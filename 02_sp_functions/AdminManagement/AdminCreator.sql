CREATE PROCEDURE CreateAdmin
@Username varchar(50),
@Password varchar(50)
AS
BEGIN
BEGIN TRY
    IF NOT EXISTS (SELECT * FROM Admin WHERE username = @Username)
        BEGIN
                INSERT INTO Admin VALUES(@Username, HASHBYTES('SHA2_512', @Password))
                PRINT 'New Admin created.'
        END
    ELSE
        BEGIN
            PRINT 'Username already taken. Please choose another username.'
        END
END TRY
    BEGIN CATCH
        PRINT '[ERROR] ' + ERROR_MESSAGE();  
    END CATCH

END