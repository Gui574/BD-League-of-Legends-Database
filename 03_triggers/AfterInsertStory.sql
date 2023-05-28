CREATE TRIGGER AfterInsertStoryUpdate
ON Stories
AFTER INSERT
AS
BEGIN 
    -- Update the summary table stats to reflect the total number of stories
    UPDATE stats
    SET TotalStories = (SELECT COUNT(*) FROM StoryTable)
END