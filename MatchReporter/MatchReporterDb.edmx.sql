
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/10/2015 16:36:56
-- Generated from EDMX file: D:\Programiranje\Visual Studio\Desktop\MatchReporter\MatchReporter\MatchReporterDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MatchReporterDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FirstRefereeRefereePair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RefereePairs] DROP CONSTRAINT [FK_FirstRefereeRefereePair];
GO
IF OBJECT_ID(N'[dbo].[FK_SecondRefereeRefereePair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RefereePairs] DROP CONSTRAINT [FK_SecondRefereeRefereePair];
GO
IF OBJECT_ID(N'[dbo].[FK_RefereePairMatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_RefereePairMatch];
GO
IF OBJECT_ID(N'[dbo].[FK_LeagueMatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_LeagueMatch];
GO
IF OBJECT_ID(N'[dbo].[FK_DelegateMatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_DelegateMatch];
GO
IF OBJECT_ID(N'[dbo].[FK_HallMatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_HallMatch];
GO
IF OBJECT_ID(N'[dbo].[FK_CityReferee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Referees] DROP CONSTRAINT [FK_CityReferee];
GO
IF OBJECT_ID(N'[dbo].[FK_CityDelegate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Delegates] DROP CONSTRAINT [FK_CityDelegate];
GO
IF OBJECT_ID(N'[dbo].[FK_CityHall]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Halls] DROP CONSTRAINT [FK_CityHall];
GO
IF OBJECT_ID(N'[dbo].[FK_CityClub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clubc] DROP CONSTRAINT [FK_CityClub];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubClubOfficial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubOfficialSet] DROP CONSTRAINT [FK_ClubClubOfficial];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubPlayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Players] DROP CONSTRAINT [FK_ClubPlayer];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubHomeTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeTeams] DROP CONSTRAINT [FK_ClubHomeTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubGuestTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GuestTeams] DROP CONSTRAINT [FK_ClubGuestTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchGuestTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GuestTeams] DROP CONSTRAINT [FK_MatchGuestTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchHomeTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeTeams] DROP CONSTRAINT [FK_MatchHomeTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchPlay]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Plays] DROP CONSTRAINT [FK_MatchPlay];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerPlay]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Plays] DROP CONSTRAINT [FK_PlayerPlay];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubOfficialManage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Manages] DROP CONSTRAINT [FK_ClubOfficialManage];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchManage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Manages] DROP CONSTRAINT [FK_MatchManage];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Referees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Referees];
GO
IF OBJECT_ID(N'[dbo].[RefereePairs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RefereePairs];
GO
IF OBJECT_ID(N'[dbo].[Delegates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Delegates];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Halls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Halls];
GO
IF OBJECT_ID(N'[dbo].[Clubc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clubc];
GO
IF OBJECT_ID(N'[dbo].[Players]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Players];
GO
IF OBJECT_ID(N'[dbo].[ClubOfficialSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubOfficialSet];
GO
IF OBJECT_ID(N'[dbo].[Leagues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Leagues];
GO
IF OBJECT_ID(N'[dbo].[Matches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Matches];
GO
IF OBJECT_ID(N'[dbo].[Plays]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Plays];
GO
IF OBJECT_ID(N'[dbo].[Manages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Manages];
GO
IF OBJECT_ID(N'[dbo].[HomeTeams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeTeams];
GO
IF OBJECT_ID(N'[dbo].[GuestTeams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GuestTeams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Referees'
CREATE TABLE [dbo].[Referees] (
    [RefereeId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [CityId] int  NOT NULL
);
GO

-- Creating table 'RefereePairs'
CREATE TABLE [dbo].[RefereePairs] (
    [RefereePairId] int IDENTITY(1,1) NOT NULL,
    [FirstRefereeId] int  NOT NULL,
    [SecondRefereeId] int  NOT NULL
);
GO

-- Creating table 'Delegates'
CREATE TABLE [dbo].[Delegates] (
    [DelegateId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [CityId] int  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [CityId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PostalCode] int  NOT NULL,
    [Country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Halls'
CREATE TABLE [dbo].[Halls] (
    [HallId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Capacity] int  NOT NULL,
    [CityId] int  NOT NULL
);
GO

-- Creating table 'Clubs'
CREATE TABLE [dbo].[Clubs] (
    [ClubId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [JerseyColorHome] nvarchar(max)  NOT NULL,
    [JerseyColorGuest] nvarchar(max)  NOT NULL,
    [CityId] int  NOT NULL
);
GO

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [PlayerId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [ClubId] int  NOT NULL
);
GO

-- Creating table 'ClubOfficials'
CREATE TABLE [dbo].[ClubOfficials] (
    [ClubOfficialId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [ClubId] int  NOT NULL
);
GO

-- Creating table 'Leagues'
CREATE TABLE [dbo].[Leagues] (
    [LeagueId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Sex] nvarchar(max)  NULL
);
GO

-- Creating table 'Matches'
CREATE TABLE [dbo].[Matches] (
    [MatchId] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Time] time  NOT NULL,
    [Round] int  NOT NULL,
    [Spectators] int  NOT NULL,
    [RefereePairId] int  NOT NULL,
    [LeagueId] int  NOT NULL,
    [DelegateId] int  NOT NULL,
    [HallId] int  NOT NULL
);
GO

-- Creating table 'Plays'
CREATE TABLE [dbo].[Plays] (
    [PlayId] int IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Goals] nvarchar(max)  NOT NULL,
    [Goals7m] nvarchar(max)  NOT NULL,
    [Warning] nvarchar(max)  NOT NULL,
    [SuspensionFirst] nvarchar(max)  NOT NULL,
    [SuspensionSecond] nvarchar(max)  NOT NULL,
    [SuspensionThird] nvarchar(max)  NOT NULL,
    [Disqualification] nvarchar(max)  NOT NULL,
    [DisqualificationAdnReport] nvarchar(max)  NOT NULL,
    [PlayerId] int  NOT NULL,
    [MatchId] int  NOT NULL
);
GO

-- Creating table 'Manages'
CREATE TABLE [dbo].[Manages] (
    [ManageId] int IDENTITY(1,1) NOT NULL,
    [Warning] nvarchar(max)  NOT NULL,
    [Suspension] nvarchar(max)  NOT NULL,
    [Disqualification] nvarchar(max)  NOT NULL,
    [DisqualificationAndReport] nvarchar(max)  NOT NULL,
    [ClubOfficialId] int  NOT NULL,
    [MatchId] int  NOT NULL
);
GO

-- Creating table 'HomeTeams'
CREATE TABLE [dbo].[HomeTeams] (
    [HomeTeamId] int IDENTITY(1,1) NOT NULL,
    [Goals] smallint  NOT NULL,
    [TTO1] nvarchar(max)  NOT NULL,
    [TTO2] nvarchar(max)  NOT NULL,
    [TTO3] nvarchar(max)  NOT NULL,
    [JerseyColor] nvarchar(max)  NOT NULL,
    [ClubId] int  NOT NULL,
    [MatchId] int  NOT NULL
);
GO

-- Creating table 'GuestTeams'
CREATE TABLE [dbo].[GuestTeams] (
    [GuestTeamId] int IDENTITY(1,1) NOT NULL,
    [Goals] smallint  NOT NULL,
    [TTO1] nvarchar(max)  NOT NULL,
    [TTO2] nvarchar(max)  NOT NULL,
    [TTO3] nvarchar(max)  NOT NULL,
    [JerseyColor] nvarchar(max)  NOT NULL,
    [ClubId] int  NOT NULL,
    [MatchId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [RefereeId] in table 'Referees'
ALTER TABLE [dbo].[Referees]
ADD CONSTRAINT [PK_Referees]
    PRIMARY KEY CLUSTERED ([RefereeId] ASC);
GO

-- Creating primary key on [RefereePairId] in table 'RefereePairs'
ALTER TABLE [dbo].[RefereePairs]
ADD CONSTRAINT [PK_RefereePairs]
    PRIMARY KEY CLUSTERED ([RefereePairId] ASC);
GO

-- Creating primary key on [DelegateId] in table 'Delegates'
ALTER TABLE [dbo].[Delegates]
ADD CONSTRAINT [PK_Delegates]
    PRIMARY KEY CLUSTERED ([DelegateId] ASC);
GO

-- Creating primary key on [CityId] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([CityId] ASC);
GO

-- Creating primary key on [HallId] in table 'Halls'
ALTER TABLE [dbo].[Halls]
ADD CONSTRAINT [PK_Halls]
    PRIMARY KEY CLUSTERED ([HallId] ASC);
GO

-- Creating primary key on [ClubId] in table 'Clubs'
ALTER TABLE [dbo].[Clubs]
ADD CONSTRAINT [PK_Clubs]
    PRIMARY KEY CLUSTERED ([ClubId] ASC);
GO

-- Creating primary key on [PlayerId] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([PlayerId] ASC);
GO

-- Creating primary key on [ClubOfficialId] in table 'ClubOfficials'
ALTER TABLE [dbo].[ClubOfficials]
ADD CONSTRAINT [PK_ClubOfficials]
    PRIMARY KEY CLUSTERED ([ClubOfficialId] ASC);
GO

-- Creating primary key on [LeagueId] in table 'Leagues'
ALTER TABLE [dbo].[Leagues]
ADD CONSTRAINT [PK_Leagues]
    PRIMARY KEY CLUSTERED ([LeagueId] ASC);
GO

-- Creating primary key on [MatchId] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [PK_Matches]
    PRIMARY KEY CLUSTERED ([MatchId] ASC);
GO

-- Creating primary key on [PlayId] in table 'Plays'
ALTER TABLE [dbo].[Plays]
ADD CONSTRAINT [PK_Plays]
    PRIMARY KEY CLUSTERED ([PlayId] ASC);
GO

-- Creating primary key on [ManageId] in table 'Manages'
ALTER TABLE [dbo].[Manages]
ADD CONSTRAINT [PK_Manages]
    PRIMARY KEY CLUSTERED ([ManageId] ASC);
GO

-- Creating primary key on [HomeTeamId] in table 'HomeTeams'
ALTER TABLE [dbo].[HomeTeams]
ADD CONSTRAINT [PK_HomeTeams]
    PRIMARY KEY CLUSTERED ([HomeTeamId] ASC);
GO

-- Creating primary key on [GuestTeamId] in table 'GuestTeams'
ALTER TABLE [dbo].[GuestTeams]
ADD CONSTRAINT [PK_GuestTeams]
    PRIMARY KEY CLUSTERED ([GuestTeamId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FirstRefereeId] in table 'RefereePairs'
ALTER TABLE [dbo].[RefereePairs]
ADD CONSTRAINT [FK_FirstRefereeRefereePair]
    FOREIGN KEY ([FirstRefereeId])
    REFERENCES [dbo].[Referees]
        ([RefereeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirstRefereeRefereePair'
CREATE INDEX [IX_FK_FirstRefereeRefereePair]
ON [dbo].[RefereePairs]
    ([FirstRefereeId]);
GO

-- Creating foreign key on [SecondRefereeId] in table 'RefereePairs'
ALTER TABLE [dbo].[RefereePairs]
ADD CONSTRAINT [FK_SecondRefereeRefereePair]
    FOREIGN KEY ([SecondRefereeId])
    REFERENCES [dbo].[Referees]
        ([RefereeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SecondRefereeRefereePair'
CREATE INDEX [IX_FK_SecondRefereeRefereePair]
ON [dbo].[RefereePairs]
    ([SecondRefereeId]);
GO

-- Creating foreign key on [RefereePairId] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_RefereePairMatch]
    FOREIGN KEY ([RefereePairId])
    REFERENCES [dbo].[RefereePairs]
        ([RefereePairId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RefereePairMatch'
CREATE INDEX [IX_FK_RefereePairMatch]
ON [dbo].[Matches]
    ([RefereePairId]);
GO

-- Creating foreign key on [LeagueId] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_LeagueMatch]
    FOREIGN KEY ([LeagueId])
    REFERENCES [dbo].[Leagues]
        ([LeagueId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LeagueMatch'
CREATE INDEX [IX_FK_LeagueMatch]
ON [dbo].[Matches]
    ([LeagueId]);
GO

-- Creating foreign key on [DelegateId] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_DelegateMatch]
    FOREIGN KEY ([DelegateId])
    REFERENCES [dbo].[Delegates]
        ([DelegateId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DelegateMatch'
CREATE INDEX [IX_FK_DelegateMatch]
ON [dbo].[Matches]
    ([DelegateId]);
GO

-- Creating foreign key on [HallId] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_HallMatch]
    FOREIGN KEY ([HallId])
    REFERENCES [dbo].[Halls]
        ([HallId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HallMatch'
CREATE INDEX [IX_FK_HallMatch]
ON [dbo].[Matches]
    ([HallId]);
GO

-- Creating foreign key on [CityId] in table 'Referees'
ALTER TABLE [dbo].[Referees]
ADD CONSTRAINT [FK_CityReferee]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityReferee'
CREATE INDEX [IX_FK_CityReferee]
ON [dbo].[Referees]
    ([CityId]);
GO

-- Creating foreign key on [CityId] in table 'Delegates'
ALTER TABLE [dbo].[Delegates]
ADD CONSTRAINT [FK_CityDelegate]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityDelegate'
CREATE INDEX [IX_FK_CityDelegate]
ON [dbo].[Delegates]
    ([CityId]);
GO

-- Creating foreign key on [CityId] in table 'Halls'
ALTER TABLE [dbo].[Halls]
ADD CONSTRAINT [FK_CityHall]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityHall'
CREATE INDEX [IX_FK_CityHall]
ON [dbo].[Halls]
    ([CityId]);
GO

-- Creating foreign key on [CityId] in table 'Clubs'
ALTER TABLE [dbo].[Clubs]
ADD CONSTRAINT [FK_CityClub]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityClub'
CREATE INDEX [IX_FK_CityClub]
ON [dbo].[Clubs]
    ([CityId]);
GO

-- Creating foreign key on [ClubId] in table 'ClubOfficials'
ALTER TABLE [dbo].[ClubOfficials]
ADD CONSTRAINT [FK_ClubClubOfficial]
    FOREIGN KEY ([ClubId])
    REFERENCES [dbo].[Clubs]
        ([ClubId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubClubOfficial'
CREATE INDEX [IX_FK_ClubClubOfficial]
ON [dbo].[ClubOfficials]
    ([ClubId]);
GO

-- Creating foreign key on [ClubId] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [FK_ClubPlayer]
    FOREIGN KEY ([ClubId])
    REFERENCES [dbo].[Clubs]
        ([ClubId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubPlayer'
CREATE INDEX [IX_FK_ClubPlayer]
ON [dbo].[Players]
    ([ClubId]);
GO

-- Creating foreign key on [ClubId] in table 'HomeTeams'
ALTER TABLE [dbo].[HomeTeams]
ADD CONSTRAINT [FK_ClubHomeTeam]
    FOREIGN KEY ([ClubId])
    REFERENCES [dbo].[Clubs]
        ([ClubId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubHomeTeam'
CREATE INDEX [IX_FK_ClubHomeTeam]
ON [dbo].[HomeTeams]
    ([ClubId]);
GO

-- Creating foreign key on [ClubId] in table 'GuestTeams'
ALTER TABLE [dbo].[GuestTeams]
ADD CONSTRAINT [FK_ClubGuestTeam]
    FOREIGN KEY ([ClubId])
    REFERENCES [dbo].[Clubs]
        ([ClubId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubGuestTeam'
CREATE INDEX [IX_FK_ClubGuestTeam]
ON [dbo].[GuestTeams]
    ([ClubId]);
GO

-- Creating foreign key on [MatchId] in table 'GuestTeams'
ALTER TABLE [dbo].[GuestTeams]
ADD CONSTRAINT [FK_MatchGuestTeam]
    FOREIGN KEY ([MatchId])
    REFERENCES [dbo].[Matches]
        ([MatchId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchGuestTeam'
CREATE INDEX [IX_FK_MatchGuestTeam]
ON [dbo].[GuestTeams]
    ([MatchId]);
GO

-- Creating foreign key on [MatchId] in table 'HomeTeams'
ALTER TABLE [dbo].[HomeTeams]
ADD CONSTRAINT [FK_MatchHomeTeam]
    FOREIGN KEY ([MatchId])
    REFERENCES [dbo].[Matches]
        ([MatchId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchHomeTeam'
CREATE INDEX [IX_FK_MatchHomeTeam]
ON [dbo].[HomeTeams]
    ([MatchId]);
GO

-- Creating foreign key on [MatchId] in table 'Plays'
ALTER TABLE [dbo].[Plays]
ADD CONSTRAINT [FK_MatchPlay]
    FOREIGN KEY ([MatchId])
    REFERENCES [dbo].[Matches]
        ([MatchId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchPlay'
CREATE INDEX [IX_FK_MatchPlay]
ON [dbo].[Plays]
    ([MatchId]);
GO

-- Creating foreign key on [PlayerId] in table 'Plays'
ALTER TABLE [dbo].[Plays]
ADD CONSTRAINT [FK_PlayerPlay]
    FOREIGN KEY ([PlayerId])
    REFERENCES [dbo].[Players]
        ([PlayerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerPlay'
CREATE INDEX [IX_FK_PlayerPlay]
ON [dbo].[Plays]
    ([PlayerId]);
GO

-- Creating foreign key on [ClubOfficialId] in table 'Manages'
ALTER TABLE [dbo].[Manages]
ADD CONSTRAINT [FK_ClubOfficialManage]
    FOREIGN KEY ([ClubOfficialId])
    REFERENCES [dbo].[ClubOfficials]
        ([ClubOfficialId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubOfficialManage'
CREATE INDEX [IX_FK_ClubOfficialManage]
ON [dbo].[Manages]
    ([ClubOfficialId]);
GO

-- Creating foreign key on [MatchId] in table 'Manages'
ALTER TABLE [dbo].[Manages]
ADD CONSTRAINT [FK_MatchManage]
    FOREIGN KEY ([MatchId])
    REFERENCES [dbo].[Matches]
        ([MatchId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchManage'
CREATE INDEX [IX_FK_MatchManage]
ON [dbo].[Manages]
    ([MatchId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------