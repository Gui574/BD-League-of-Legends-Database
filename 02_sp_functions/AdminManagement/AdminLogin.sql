CREATE PROCEDURE Admin_Login
    @Username varchar(50),
    @Password varchar(50)
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @HashPassword varbinary(64)

    IF NOT EXISTS (SELECT * FROM Admin WHERE username = @Username)
    BEGIN
        SELECT 'Invalid Username' AS Result
        RETURN
    END

    SELECT @HashPassword = hashPassword FROM Users WHERE username = @Username

    IF (HASHBYTES('SHA2_512', @Password) <> @HashPassword)
    BEGIN
        SELECT 'Incorrect Password' AS Result
        RETURN
    END

    SELECT 'Success' AS Result
END