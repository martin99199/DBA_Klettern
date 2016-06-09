
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2016 09:49:59
-- Generated from EDMX file: C:\Users\Pachler Martin\Documents\_1Studium FH_ATMaster\Semester2\Datenbanken_ILV\KletterDatenbank_MuellerPachler\KletterDatenbank_MuellerPachler\EF_KletterRouten.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EF_KletterRouten];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GebietSektor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SektorSet] DROP CONSTRAINT [FK_GebietSektor];
GO
IF OBJECT_ID(N'[dbo].[FK_SektorRoute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RouteSet] DROP CONSTRAINT [FK_SektorRoute];
GO
IF OBJECT_ID(N'[dbo].[FK_RouteZOT_Durchstiegsliste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZOT_DurchstiegslisteSet] DROP CONSTRAINT [FK_RouteZOT_Durchstiegsliste];
GO
IF OBJECT_ID(N'[dbo].[FK_RouteZOT_Wunschliste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZOT_WunschlisteSet] DROP CONSTRAINT [FK_RouteZOT_Wunschliste];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonZOT_Durchstiegsliste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZOT_DurchstiegslisteSet] DROP CONSTRAINT [FK_PersonZOT_Durchstiegsliste];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonZOT_Wunschliste]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZOT_WunschlisteSet] DROP CONSTRAINT [FK_PersonZOT_Wunschliste];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[ZOT_WunschlisteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZOT_WunschlisteSet];
GO
IF OBJECT_ID(N'[dbo].[ZOT_DurchstiegslisteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZOT_DurchstiegslisteSet];
GO
IF OBJECT_ID(N'[dbo].[RouteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RouteSet];
GO
IF OBJECT_ID(N'[dbo].[SektorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SektorSet];
GO
IF OBJECT_ID(N'[dbo].[GebietSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GebietSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [ID_Person] int IDENTITY(1,1) NOT NULL,
    [Vorname] nvarchar(max)  NOT NULL,
    [Nachname] nvarchar(max)  NOT NULL,
    [Geburtsdatum] datetime  NOT NULL
);
GO

-- Creating table 'ZOT_WunschlisteSet'
CREATE TABLE [dbo].[ZOT_WunschlisteSet] (
    [ID_Person] int  NOT NULL,
    [ID_Sektor] int  NOT NULL,
    [ID_Route] int  NOT NULL,
    [Kommentar] nvarchar(max)  NULL,
    [Route_ID_Route] int  NOT NULL,
    [Route_ID_Sektor] int  NOT NULL,
    [Person_ID_Person] int  NOT NULL
);
GO

-- Creating table 'ZOT_DurchstiegslisteSet'
CREATE TABLE [dbo].[ZOT_DurchstiegslisteSet] (
    [ID_Person] int  NOT NULL,
    [ID_Sektor] int  NOT NULL,
    [ID_Route] int  NOT NULL,
    [Kommentar] nvarchar(max)  NULL,
    [Durchstiegsdatum] datetime  NOT NULL,
    [Route_ID_Route] int  NOT NULL,
    [Route_ID_Sektor] int  NOT NULL,
    [Person_ID_Person] int  NOT NULL
);
GO

-- Creating table 'RouteSet'
CREATE TABLE [dbo].[RouteSet] (
    [ID_Route] int IDENTITY(1,1) NOT NULL,
    [ID_Sektor] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Schwierigkeitsgrad] nvarchar(max)  NOT NULL,
    [IstBoulder] bit  NOT NULL,
    [Sektor_ID_Sektor] int  NOT NULL,
    [Sektor_ID_Gebiet] int  NOT NULL
);
GO

-- Creating table 'SektorSet'
CREATE TABLE [dbo].[SektorSet] (
    [ID_Sektor] int IDENTITY(1,1) NOT NULL,
    [ID_Gebiet] int  NOT NULL,
    [NameSektor] nvarchar(max)  NOT NULL,
    [GPS_Exakt] nvarchar(max)  NULL,
    [Gebiet_ID_Gebiet] int  NOT NULL
);
GO

-- Creating table 'GebietSet'
CREATE TABLE [dbo].[GebietSet] (
    [ID_Gebiet] int IDENTITY(1,1) NOT NULL,
    [NameGebiet] nvarchar(max)  NOT NULL,
    [Ort] nvarchar(max)  NOT NULL,
    [PLZ] int  NOT NULL,
    [GPS_Parkplatz] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_Person] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([ID_Person] ASC);
GO

-- Creating primary key on [ID_Person], [ID_Sektor], [ID_Route] in table 'ZOT_WunschlisteSet'
ALTER TABLE [dbo].[ZOT_WunschlisteSet]
ADD CONSTRAINT [PK_ZOT_WunschlisteSet]
    PRIMARY KEY CLUSTERED ([ID_Person], [ID_Sektor], [ID_Route] ASC);
GO

-- Creating primary key on [ID_Person], [ID_Sektor], [ID_Route] in table 'ZOT_DurchstiegslisteSet'
ALTER TABLE [dbo].[ZOT_DurchstiegslisteSet]
ADD CONSTRAINT [PK_ZOT_DurchstiegslisteSet]
    PRIMARY KEY CLUSTERED ([ID_Person], [ID_Sektor], [ID_Route] ASC);
GO

-- Creating primary key on [ID_Route], [ID_Sektor] in table 'RouteSet'
ALTER TABLE [dbo].[RouteSet]
ADD CONSTRAINT [PK_RouteSet]
    PRIMARY KEY CLUSTERED ([ID_Route], [ID_Sektor] ASC);
GO

-- Creating primary key on [ID_Sektor], [ID_Gebiet] in table 'SektorSet'
ALTER TABLE [dbo].[SektorSet]
ADD CONSTRAINT [PK_SektorSet]
    PRIMARY KEY CLUSTERED ([ID_Sektor], [ID_Gebiet] ASC);
GO

-- Creating primary key on [ID_Gebiet] in table 'GebietSet'
ALTER TABLE [dbo].[GebietSet]
ADD CONSTRAINT [PK_GebietSet]
    PRIMARY KEY CLUSTERED ([ID_Gebiet] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Gebiet_ID_Gebiet] in table 'SektorSet'
ALTER TABLE [dbo].[SektorSet]
ADD CONSTRAINT [FK_GebietSektor]
    FOREIGN KEY ([Gebiet_ID_Gebiet])
    REFERENCES [dbo].[GebietSet]
        ([ID_Gebiet])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GebietSektor'
CREATE INDEX [IX_FK_GebietSektor]
ON [dbo].[SektorSet]
    ([Gebiet_ID_Gebiet]);
GO

-- Creating foreign key on [Sektor_ID_Sektor], [Sektor_ID_Gebiet] in table 'RouteSet'
ALTER TABLE [dbo].[RouteSet]
ADD CONSTRAINT [FK_SektorRoute]
    FOREIGN KEY ([Sektor_ID_Sektor], [Sektor_ID_Gebiet])
    REFERENCES [dbo].[SektorSet]
        ([ID_Sektor], [ID_Gebiet])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SektorRoute'
CREATE INDEX [IX_FK_SektorRoute]
ON [dbo].[RouteSet]
    ([Sektor_ID_Sektor], [Sektor_ID_Gebiet]);
GO

-- Creating foreign key on [Route_ID_Route], [Route_ID_Sektor] in table 'ZOT_DurchstiegslisteSet'
ALTER TABLE [dbo].[ZOT_DurchstiegslisteSet]
ADD CONSTRAINT [FK_RouteZOT_Durchstiegsliste]
    FOREIGN KEY ([Route_ID_Route], [Route_ID_Sektor])
    REFERENCES [dbo].[RouteSet]
        ([ID_Route], [ID_Sektor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteZOT_Durchstiegsliste'
CREATE INDEX [IX_FK_RouteZOT_Durchstiegsliste]
ON [dbo].[ZOT_DurchstiegslisteSet]
    ([Route_ID_Route], [Route_ID_Sektor]);
GO

-- Creating foreign key on [Route_ID_Route], [Route_ID_Sektor] in table 'ZOT_WunschlisteSet'
ALTER TABLE [dbo].[ZOT_WunschlisteSet]
ADD CONSTRAINT [FK_RouteZOT_Wunschliste]
    FOREIGN KEY ([Route_ID_Route], [Route_ID_Sektor])
    REFERENCES [dbo].[RouteSet]
        ([ID_Route], [ID_Sektor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteZOT_Wunschliste'
CREATE INDEX [IX_FK_RouteZOT_Wunschliste]
ON [dbo].[ZOT_WunschlisteSet]
    ([Route_ID_Route], [Route_ID_Sektor]);
GO

-- Creating foreign key on [Person_ID_Person] in table 'ZOT_DurchstiegslisteSet'
ALTER TABLE [dbo].[ZOT_DurchstiegslisteSet]
ADD CONSTRAINT [FK_PersonZOT_Durchstiegsliste]
    FOREIGN KEY ([Person_ID_Person])
    REFERENCES [dbo].[PersonSet]
        ([ID_Person])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonZOT_Durchstiegsliste'
CREATE INDEX [IX_FK_PersonZOT_Durchstiegsliste]
ON [dbo].[ZOT_DurchstiegslisteSet]
    ([Person_ID_Person]);
GO

-- Creating foreign key on [Person_ID_Person] in table 'ZOT_WunschlisteSet'
ALTER TABLE [dbo].[ZOT_WunschlisteSet]
ADD CONSTRAINT [FK_PersonZOT_Wunschliste]
    FOREIGN KEY ([Person_ID_Person])
    REFERENCES [dbo].[PersonSet]
        ([ID_Person])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonZOT_Wunschliste'
CREATE INDEX [IX_FK_PersonZOT_Wunschliste]
ON [dbo].[ZOT_WunschlisteSet]
    ([Person_ID_Person]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------