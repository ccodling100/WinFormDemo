CREATE PROCEDURE dbo.IBET_CalculateMaxBetPercentages
    @inputIdRaceProfile INT
AS
BEGIN
SET NOCOUNT ON;

-- Create a temporary table
CREATE TABLE #TempMaxBetPercentages(
                                       IdBetType INT,
                                       Value DECIMAL(10,2),
    ValuePercent DECIMAL(10, 2),
    ValueType INT
    )

-- Define variables
DECLARE @totalMaxBet MONEY,
    @currentIdBetType INT,
    @currentMaxBet MONEY;

-- Create a cursor that contains each IdBetType for the given IdRaceProfile
DECLARE min_bets CURSOR FOR
    SELECT DISTINCT IdBetType, MaxBet
    FROM IBET_TrackLimits
    WHERE IdRaceProfile = @inputIdRaceProfile;

-- Open the cursor
OPEN min_bets;
FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentMaxBet;

-- Iterate through each MaxBet
WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Calculate the percentage of the current MaxBet in comparison to the total MaxBets of the same value and store the value in the temp table
INSERT INTO #TempMaxBetPercentages (IdBetType, Value, ValuePercent, ValueType)
(SELECT IdBetType, MaxBet AS Value, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType) as ValuePercent, 2
    FROM IBET_TrackLimits WHERE IdRaceProfile = @inputIdRaceProfile AND IdBetType = @currentIdBetType GROUP BY IdBetType, MaxBet)

FETCH NEXT FROM min_bets INTO @currentIdBetType, @currentMaxBet;
END;

-- Close the cursor
CLOSE min_bets;
DEALLOCATE min_bets;

-- Return all rows in the temp table
SELECT DISTINCT * FROM #TempMaxBetPercentages ORDER BY IdBetType;

-- Drop the temp table
DROP TABLE #TempMaxBetPercentages;
END;
go

