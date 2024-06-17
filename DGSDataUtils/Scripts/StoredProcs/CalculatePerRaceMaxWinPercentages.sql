CREATE PROCEDURE dbo.IBET_CalculatePerRaceMaxWinPercentages
    @inputIdRaceProfile INT
AS
BEGIN
SET NOCOUNT ON;

-- Create a temporary table
CREATE TABLE #TempPerRaceMaxWinPercentages(
                                              IdBetType INT,
                                              Value DECIMAL(10,2),
    ValuePercent DECIMAL(10, 2),
    ValueType INT
    )

-- Define variables
DECLARE @totalPerRaceMaxWin MONEY,
    @currentIdBetType INT,
    @currentPerRaceMaxWin MONEY;

-- Create a cursor that contains each IdBetType for the given IdRaceProfile
DECLARE min_bets CURSOR FOR
    SELECT DISTINCT IdBetType, PerRaceMaxWin
    FROM IBET_TrackLimits
    WHERE IdRaceProfile = @inputIdRaceProfile;

-- Open the cursor
OPEN min_bets;
FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentPerRaceMaxWin;

-- Iterate through each PerRaceMaxWin
WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Calculate the percentage of the current PerRaceMaxWin in comparison to the total PerRaceMaxWins of the same value and store the value in the temp table
INSERT INTO #TempPerRaceMaxWinPercentages (IdBetType, Value, ValuePercent, ValueType)
(SELECT IdBetType, PerRaceMaxWin AS Value, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType) as ValuePercent, 0
    FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType GROUP BY IdBetType, PerRaceMaxWin)

FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentPerRaceMaxWin;
END;

-- Close the cursor
CLOSE min_bets;
DEALLOCATE min_bets;

-- Return all rows in the temp table
SELECT DISTINCT * FROM #TempPerRaceMaxWinPercentages ORDER BY IdBetType;

-- Drop the temp table
DROP TABLE #TempPerRaceMaxWinPercentages;
END;
go

