CREATE PROCEDURE [dbo].[FilterChampions]
    @GenderFilter VARCHAR(6),
    @RegionFilter VARCHAR(50)
AS
BEGIN
    -- Start with the base query (always true, returns all)
     DECLARE @sqlQuery NVARCHAR(MAX) = 'SELECT * FROM Champion WHERE 1=1';

    -- Add conditions based on the variables
    IF @GenderFilter IS NOT ""
        SET @sqlQuery = @sqlQuery + ' AND gender = @GenderFilter';

    IF @RegionFilter IS NOT ""
        SET @sqlQuery = @sqlQuery + ' AND region_name = @RegionFilter';


    -- Execute the dynamic query
    EXEC sp_executesql @sqlQuery,
        N'@GenderFilter VARCHAR(50), @RegionFilter VARCHAR(50)',
        @GenderFilter,
        @RegionFilter;
   
    
END