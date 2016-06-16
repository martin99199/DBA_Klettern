
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2016 12:04:46
-- Generated from EDMX file: C:\Users\Pachler Martin\Documents\GitHub\DBA_Klettern\KletterDatenbank_MuellerPachler\KletterDatenbank_MuellerPachler\EF_KletterRouten.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EF_DB_Kletterrouten];
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

-- Creating table 'Personen'
CREATE TABLE [dbo].[Personen] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Vorname] nvarchar(max)  NOT NULL,
    [Nachname] nvarchar(max)  NOT NULL,
    [Geburtsdatum] datetime  NOT NULL
);
GO

-- Creating table 'ZOT_Wunschlisten'
CREATE TABLE [dbo].[ZOT_Wunschlisten] (
    [ID] int  NOT NULL,
    [Kommentar] nvarchar(max)  NULL,
    [PersonID] int  NOT NULL,
    [RouteID] int  NOT NULL
);
GO

-- Creating table 'ZOT_Durchstiegslisten'
CREATE TABLE [dbo].[ZOT_Durchstiegslisten] (
    [ID] int  NOT NULL,
    [Kommentar] nvarchar(max)  NULL,
    [Durchstiegsdatum] datetime  NOT NULL,
    [PersonID] int  NOT NULL,
    [RouteID] int  NOT NULL
);
GO

-- Creating table 'Routen'
CREATE TABLE [dbo].[Routen] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Schwierigkeitsgrad] nvarchar(max)  NOT NULL,
    [IstBoulder] bit  NOT NULL,
    [SektorID] int  NOT NULL
);
GO

-- Creating table 'Sektoren'
CREATE TABLE [dbo].[Sektoren] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NameSektor] nvarchar(max)  NOT NULL,
    [GPS_Exakt] nvarchar(max)  NULL,
    [GebietID] int  NOT NULL
);
GO

-- Creating table 'Gebiete'
CREATE TABLE [dbo].[Gebiete] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NameGebiet] nvarchar(max)  NOT NULL,
    [Ort] nvarchar(max)  NOT NULL,
    [PLZ] int  NOT NULL,
    [GPS_Parkplatz] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Personen'
ALTER TABLE [dbo].[Personen]
ADD CONSTRAINT [PK_Personen]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ZOT_Wunschlisten'
ALTER TABLE [dbo].[ZOT_Wunschlisten]
ADD CONSTRAINT [PK_ZOT_Wunschlisten]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ZOT_Durchstiegslisten'
ALTER TABLE [dbo].[ZOT_Durchstiegslisten]
ADD CONSTRAINT [PK_ZOT_Durchstiegslisten]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Routen'
ALTER TABLE [dbo].[Routen]
ADD CONSTRAINT [PK_Routen]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Sektoren'
ALTER TABLE [dbo].[Sektoren]
ADD CONSTRAINT [PK_Sektoren]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Gebiete'
ALTER TABLE [dbo].[Gebiete]
ADD CONSTRAINT [PK_Gebiete]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonID] in table 'ZOT_Wunschlisten'
ALTER TABLE [dbo].[ZOT_Wunschlisten]
ADD CONSTRAINT [FK_PersonZOT_Wunschliste]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[Personen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonZOT_Wunschliste'
CREATE INDEX [IX_FK_PersonZOT_Wunschliste]
ON [dbo].[ZOT_Wunschlisten]
    ([PersonID]);
GO

-- Creating foreign key on [PersonID] in table 'ZOT_Durchstiegslisten'
ALTER TABLE [dbo].[ZOT_Durchstiegslisten]
ADD CONSTRAINT [FK_PersonZOT_Durchstiegsliste]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[Personen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonZOT_Durchstiegsliste'
CREATE INDEX [IX_FK_PersonZOT_Durchstiegsliste]
ON [dbo].[ZOT_Durchstiegslisten]
    ([PersonID]);
GO

-- Creating foreign key on [RouteID] in table 'ZOT_Wunschlisten'
ALTER TABLE [dbo].[ZOT_Wunschlisten]
ADD CONSTRAINT [FK_RouteZOT_Wunschliste]
    FOREIGN KEY ([RouteID])
    REFERENCES [dbo].[Routen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteZOT_Wunschliste'
CREATE INDEX [IX_FK_RouteZOT_Wunschliste]
ON [dbo].[ZOT_Wunschlisten]
    ([RouteID]);
GO

-- Creating foreign key on [RouteID] in table 'ZOT_Durchstiegslisten'
ALTER TABLE [dbo].[ZOT_Durchstiegslisten]
ADD CONSTRAINT [FK_RouteZOT_Durchstiegsliste]
    FOREIGN KEY ([RouteID])
    REFERENCES [dbo].[Routen]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RouteZOT_Durchstiegsliste'
CREATE INDEX [IX_FK_RouteZOT_Durchstiegsliste]
ON [dbo].[ZOT_Durchstiegslisten]
    ([RouteID]);
GO

-- Creating foreign key on [SektorID] in table 'Routen'
ALTER TABLE [dbo].[Routen]
ADD CONSTRAINT [FK_SektorRoute]
    FOREIGN KEY ([SektorID])
    REFERENCES [dbo].[Sektoren]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SektorRoute'
CREATE INDEX [IX_FK_SektorRoute]
ON [dbo].[Routen]
    ([SektorID]);
GO

-- Creating foreign key on [GebietID] in table 'Sektoren'
ALTER TABLE [dbo].[Sektoren]
ADD CONSTRAINT [FK_GebietSektor]
    FOREIGN KEY ([GebietID])
    REFERENCES [dbo].[Gebiete]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GebietSektor'
CREATE INDEX [IX_FK_GebietSektor]
ON [dbo].[Sektoren]
    ([GebietID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------