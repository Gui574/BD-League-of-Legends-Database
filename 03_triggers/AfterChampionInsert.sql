CREATE TRIGGER beforeInsertChampion
ON Champion
AFTER INSERT
AS
BEGIN

    DECLARE @name VARCHAR(25),
            @gender VARCHAR(6), 
            @regionName VARCHAR(50)

    SELECT  @name = name, 
            @gender = gender, 
            @regionName = region_name FROM inserted

    -- Check if champion name already exists
    IF EXISTS(SELECT 1 FROM Champion WHERE name = @name)
        BEGIN
            SELECT 'Champion name must be unique' AS Result
            ROLLBACK TRANSACTION
            RETURN
        END

    -- Check if gender value is valid
    IF @gender NOT IN ('Male', 'Female', 'Other')
        BEGIN
            SELECT 'Gender can only be Male, Female or Other' AS Result
            ROLLBACK TRANSACTION
            RETURN
        END

    -- Check if region exists
    IF NOT EXISTS(SELECT 1 FROM regions WHERE name = @regionName)
        BEGIN
            SELECT 'Region must exist' AS Result
            ROLLBACK TRANSACTION
            RETURN
        END

    -- If validation passes, perform the insert
    

END