CREATE PROCEDURE dbo.IBET_GetAllPercentages
    @inputIdRaceProfile INT
AS
BEGIN
CREATE TABLE #TempPercents ( IdBetType INT,
                             Value DECIMAL (10,2),
    ValuePercentage DECIMAL(10,2),
    ValueType INT
    )

-- CalculatePerRaceMaxWinPercentages
INSERT INTO #TempPercents
    EXEC IBET_CalculatePerRaceMaxWinPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculateMinBetPercentages
INSERT INTO #TempPercents
    EXEC IBET_CalculateMinBetPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculateMaxBetPercentages
INSERT INTO #TempPercents
    EXEC IBET_CalculateMaxBetPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculatePerBetMaxWinPercentages
INSERT INTO #TempPercents
    EXEC IBET_CalculatePerBetMaxWinPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculateMaxPayoutOddsPercentages
INSERT INTO #TempPercents
    EXEC IBET_CalculateMaxPayoutOddsPercentages @inputIdRaceProfile = @inputIdRaceProfile

--Return all of the results
SELECT * FROM #TempPercents
END
    go

