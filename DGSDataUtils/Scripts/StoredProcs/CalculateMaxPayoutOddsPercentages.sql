CREATE PROCEDURE dbo.IBET_CalculateMaxPayoutOddsPercentages
    @inputIdRaceProfile INT
AS
BEGIN
SET NOCOUNT ON;

-- Create a temporary table
CREATE TABLE #TempMaxPayoutOddsPercentages(
                                              IdBetType INT,
                                              Value DECIMAL(10,2),
    ValuePercent DECIMAL(10, 2),
    ValueType INT
    )

-- Define variables
DECLARE @totalMaxPayoutOdds MONEY,
    @currentIdBetType INT,
    @currentMaxPayoutOdds MONEY;

-- Create a cursor that contains each IdBetType for the given IdRaceProfile
DECLARE min_bets CURSOR FOR
    SELECT DISTINCT IdBetType, MaxPayoutOdds
    FROM IBET_TrackLimits
    WHERE IdRaceProfile = @inputIdRaceProfile;

-- Open the cursor
OPEN min_bets;
FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentMaxPayoutOdds;

-- Iterate through each MaxPayoutOdds
WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Calculate the percentage of the current MaxPayoutOdds in comparison to the total MaxPayoutOddss of the same value and store the value in the temp table
INSERT INTO #TempMaxPayoutOddsPercentages (IdBetType, Value, ValuePercent, ValueType)
(SELECT IdBetType, MaxPayoutOdds AS Value, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType) as ValuePercent, 4
    FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType GROUP BY IdBetType, MaxPayoutOdds)

FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentMaxPayoutOdds;
END;

-- Close the cursor
CLOSE min_bets;
DEALLOCATE min_bets;

-- Return all rows in the temp table
SELECT DISTINCT * FROM #TempMaxPayoutOddsPercentages ORDER BY IdBetType;

-- Drop the temp table
DROP TABLE #TempMaxPayoutOddsPercentages;
END;
go

