
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2014 06:31:35
-- Generated from EDMX file: C:\Users\Sezer\Documents\Visual Studio 2012\Projects\Xprema Pro\Xprema.Data\db.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Xprema Prject];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserGroupUserSystem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSystems] DROP CONSTRAINT [FK_UserGroupUserSystem];
GO
IF OBJECT_ID(N'[dbo].[FK_SystemPermessionGroupPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupPermessions] DROP CONSTRAINT [FK_SystemPermessionGroupPermession];
GO
IF OBJECT_ID(N'[dbo].[FK_UserGroupGroupPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupPermessions] DROP CONSTRAINT [FK_UserGroupGroupPermession];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserGroups];
GO
IF OBJECT_ID(N'[dbo].[UserSystems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSystems];
GO
IF OBJECT_ID(N'[dbo].[SystemPermessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemPermessions];
GO
IF OBJECT_ID(N'[dbo].[GroupPermessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupPermessions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserGroups'
CREATE TABLE [dbo].[UserGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupName] nvarchar(max)  NOT NULL,
    [GroupDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSystems'
CREATE TABLE [dbo].[UserSystems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UserGroup_Id] int  NOT NULL
);
GO

-- Creating table 'SystemPermessions'
CREATE TABLE [dbo].[SystemPermessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PermessionName] nvarchar(max)  NOT NULL,
    [PropertyName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GroupPermessions'
CREATE TABLE [dbo].[GroupPermessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [permessionValue] bit  NOT NULL,
    [SystemPermession_Id] int  NOT NULL,
    [UserGroup_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserGroups'
ALTER TABLE [dbo].[UserGroups]
ADD CONSTRAINT [PK_UserGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [PK_UserSystems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SystemPermessions'
ALTER TABLE [dbo].[SystemPermessions]
ADD CONSTRAINT [PK_SystemPermessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [PK_GroupPermessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserGroup_Id] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [FK_UserGroupUserSystem]
    FOREIGN KEY ([UserGroup_Id])
    REFERENCES [dbo].[UserGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroupUserSystem'
CREATE INDEX [IX_FK_UserGroupUserSystem]
ON [dbo].[UserSystems]
    ([UserGroup_Id]);
GO

-- Creating foreign key on [SystemPermession_Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [FK_SystemPermessionGroupPermession]
    FOREIGN KEY ([SystemPermession_Id])
    REFERENCES [dbo].[SystemPermessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SystemPermessionGroupPermession'
CREATE INDEX [IX_FK_SystemPermessionGroupPermession]
ON [dbo].[GroupPermessions]
    ([SystemPermession_Id]);
GO

-- Creating foreign key on [UserGroup_Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [FK_UserGroupGroupPermession]
    FOREIGN KEY ([UserGroup_Id])
    REFERENCES [dbo].[UserGroups]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroupGroupPermession'
CREATE INDEX [IX_FK_UserGroupGroupPermession]
ON [dbo].[GroupPermessions]
    ([UserGroup_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------