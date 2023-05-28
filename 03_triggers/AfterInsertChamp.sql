CREATE TRIGGER AfterInsertChampionUpdate
ON Champions
AFTER INSERT
AS
BEGIN
    -- Update the summary table stats to reflect the total number of champions in the game
    UPDATE Stats
    SET TotalChampions = (SELECT COUNT(*) FROM Champions)
END