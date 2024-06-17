create database ProMgrData collate SQL_Latin1_General_CP1_CI_AS
go

use ProMgrData
go

grant connect on database :: ProMgrData to dbo
go

grant view any column encryption key definition, view any column master key definition on database :: ProMgrData to [public]
go

create table dbo.IBET_AgentDefaults
(
    IdAgent       int not null
        constraint PK_IBET_AgentDefaults
            primary key,
    IdRaceProfile int
)
go

create index IX_IBET_AgentDefaults_IdRaceProfile
    on dbo.IBET_AgentDefaults (IdRaceProfile)
go

create table dbo.IBET_BetTypes
(
    IdBetType int not null
        constraint PK_IBET_BetTypes
            primary key,
    BetName   nvarchar(max)
)
go

create table dbo.IBET_ProfileMaps
(
    IdProfileMap   int identity
        constraint PK_IBET_ProfileMaps
            primary key,
    IdSportProfile int not null,
    IdPlayer       int,
    IdRaceProfile  int
)
go

create table dbo.IBET_RaceProfiles
(
    IdRaceProfile           int           not null
        constraint PK_IBET_RaceProfiles
            primary key,
    ProfileName             nvarchar(max) not null,
    HorseGlobalMax          int           not null,
    GlobalMaxTime           int           not null,
    GlobalMaxAmount         money         not null,
    DefaultPerRaceMaxWin    money         not null,
    IbetAgentDefaultIdAgent int
        constraint FK_IBET_RaceProfiles_IBET_AgentDefaults_IbetAgentDefaultIdAgent
            references dbo.IBET_AgentDefaults
)
go

create index IX_IBET_RaceProfiles_IbetAgentDefaultIdAgent
    on dbo.IBET_RaceProfiles (IbetAgentDefaultIdAgent)
go

create table dbo.IBET_Track
(
    IdTrack   int           not null
        constraint PK_IBET_Track
            primary key,
    TrackName nvarchar(max) not null,
    TrackCode nvarchar(3)   not null
)
go

create table dbo.IBET_TrackLimits
(
    IdRaceProfile int   not null
        constraint FK_IBET_TrackLimits_IBET_RaceProfiles_IdRaceProfile
            references dbo.IBET_RaceProfiles
            on delete cascade,
    IdTrack       int   not null
        constraint FK_IBET_TrackLimits_IBET_Track_IdTrack
            references dbo.IBET_Track
            on delete cascade,
    IdBetType     int   not null
        constraint FK_IBET_TrackLimits_IBET_BetTypes_IdBetType
            references dbo.IBET_BetTypes
            on delete cascade,
    IsEnabled     bit   not null,
    PerRaceMaxWin money not null,
    MinBet        money not null,
    MaxBet        money not null,
    PerBetMaxWin  money not null,
    MaxPayoutOdds money not null,
    constraint PK_IBET_TrackLimits
        primary key (IdTrack, IdRaceProfile, IdBetType)
)
go

create index IX_IBET_TrackLimits_IdBetType
    on dbo.IBET_TrackLimits (IdBetType)
go

create index IX_IBET_TrackLimits_IdRaceProfile
    on dbo.IBET_TrackLimits (IdRaceProfile)
go

create index IX_IBET_TrackLimits_IdTrack
    on dbo.IBET_TrackLimits (IdTrack)
go

create table dbo.__EFMigrationsHistory
(
    MigrationId    nvarchar(150) not null
        constraint PK___EFMigrationsHistory
            primary key,
    ProductVersion nvarchar(32)  not null
)
go

CREATE PROCEDURE dbo.CalculateMaxBetPercentages
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

CREATE PROCEDURE dbo.CalculateMaxPayoutOddsPercentages
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

CREATE PROCEDURE dbo.CalculateMinBetPercentages
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

CREATE PROCEDURE dbo.CalculatePerBetMaxWinPercentages
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

CREATE PROCEDURE dbo.CalculatePerRaceMaxWinPercentages
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

CREATE PROCEDURE GetAllPercentages
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
        EXEC CalculatePerRaceMaxWinPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculateMinBetPercentages
    INSERT INTO #TempPercents
        EXEC CalculateMinBetPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculateMaxBetPercentages
    INSERT INTO #TempPercents
        EXEC CalculateMaxBetPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculatePerBetMaxWinPercentages
    INSERT INTO #TempPercents
        EXEC CalculatePerBetMaxWinPercentages @inputIdRaceProfile = @inputIdRaceProfile

-- CalculateMaxPayoutOddsPercentages
    INSERT INTO #TempPercents
        EXEC CalculateMaxPayoutOddsPercentages @inputIdRaceProfile = @inputIdRaceProfile

--Return all of the results
    SELECT * FROM #TempPercents
END
go

