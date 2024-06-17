CREATE PROCEDURE dbo.IBET_CalculatePerBetMaxWinPercentages
    @inputIdRaceProfile INT
AS
BEGIN
SET NOCOUNT ON;

-- Create a temporary table
CREATE TABLE #TempPerBetMaxWinPercentages(
                                             IdBetType INT,
                                             Value DECIMAL(10,2),
    ValuePercent DECIMAL(10, 2),
    ValueType INT
    )

-- Define variables
DECLARE @totalPerBetMaxWin MONEY,
    @currentIdBetType INT,
    @currentPerBetMaxWin MONEY;

-- Create a cursor that contains each IdBetType for the given IdRaceProfile
DECLARE min_bets CURSOR FOR
    SELECT DISTINCT IdBetType, PerBetMaxWin
    FROM IBET_TrackLimits
    WHERE IdRaceProfile = @inputIdRaceProfile;

-- Open the cursor
OPEN min_bets;
FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentPerBetMaxWin;

-- Iterate through each PerBetMaxWin
WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Calculate the percentage of the current PerBetMaxWin in comparison to the total PerBetMaxWins of the same value and store the value in the temp table
INSERT INTO #TempPerBetMaxWinPercentages (IdBetType, Value, ValuePercent, ValueType)
(SELECT IdBetType, PerBetMaxWin AS Value, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType) as ValuePercent, 3
    FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType GROUP BY IdBetType, PerBetMaxWin)

FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentPerBetMaxWin;
END;

-- Close the cursor
CLOSE min_bets;
DEALLOCATE min_bets;

-- Return all rows in the temp table
SELECT DISTINCT * FROM #TempPerBetMaxWinPercentages ORDER BY IdBetType;

-- Drop the temp table
DROP TABLE #TempPerBetMaxWinPercentages;
END;
go

