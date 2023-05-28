CREATE TRIGGER beforeInsertChampion
ON Champion
AFTER INSERT
AS
BEGIN

    -- Check if champion name already exists
    IF EXISTS(SELECT 1 FROM champions WHERE name = NEW.name)
        BEGIN
            print 'Champion name must be unique'
            ROLLBACK TRANSACTION
        END

    -- Check if gender value is valid
    IF NEW.gender NOT IN ('Male', 'Female', 'Other')
        BEGIN
            print'Gender can only be Male, Female or Other';
            ROLLBACK TRANSACTION
        END 

    -- Check if region exists
    IF NOT EXISTS(SELECT 1 FROM regions WHERE id = NEW.region_id)
        BEGIN
            print 'Region must exist';
            ROLLBACK TRANSACTION
        END
END