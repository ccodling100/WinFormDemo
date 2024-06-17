CREATE PROCEDURE dbo.IBET_CalculateMinBetPercentages
    @inputIdRaceProfile INT
AS
BEGIN
SET NOCOUNT ON;

-- Create a temporary table
CREATE TABLE #TempMinBetPercentages(
                                       IdBetType INT,
                                       Value DECIMAL(10,2),
    ValuePercent DECIMAL(10, 2),
    ValueType INT
    )

-- Define variables
DECLARE @totalMinBet MONEY,
    @currentIdBetType INT,
    @currentMinBet MONEY;

-- Create a cursor that contains each IdBetType for the given IdRaceProfile
DECLARE min_bets CURSOR FOR
    SELECT DISTINCT IdBetType, MinBet
    FROM IBET_TrackLimits
    WHERE IdRaceProfile = @inputIdRaceProfile;

-- Open the cursor
OPEN min_bets;
FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentMinBet;

-- Iterate through each MinBet
WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Calculate the percentage of the current MinBet in comparison to the total MinBets of the same value and store the value in the temp table
INSERT INTO #TempMinBetPercentages (IdBetType, Value, ValuePercent, ValueType)
(SELECT IdBetType, MinBet AS Value, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType) as ValuePercent, 1
    FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType GROUP BY IdBetType, MinBet)

FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentMinBet;
END;

-- Close the cursor
CLOSE min_bets;
DEALLOCATE min_bets;

-- Return all rows in the temp table
SELECT DISTINCT * FROM #TempMinBetPercentages ORDER BY IdBetType;

-- Drop the temp table
DROP TABLE #TempMinBetPercentages;
END;
go

