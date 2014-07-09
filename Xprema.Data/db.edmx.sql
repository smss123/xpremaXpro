
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/09/2014 00:32:37
-- Generated from EDMX file: C:\Users\Sezer\Documents\GitHub\xpremaXpro\Xprema.Data\db.edmx
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

IF OBJECT_ID(N'[dbo].[FK_SystemPermessionGroupPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupPermessions] DROP CONSTRAINT [FK_SystemPermessionGroupPermession];
GO
IF OBJECT_ID(N'[dbo].[FK_UserGroupGroupPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupPermessions] DROP CONSTRAINT [FK_UserGroupGroupPermession];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileAttachment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attachments] DROP CONSTRAINT [FK_ProjectProfileAttachment];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectOrderAttachment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attachments] DROP CONSTRAINT [FK_ProjectOrderAttachment];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeContract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_EmployeeContract];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileContract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_ProjectProfileContract];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Accounts] DROP CONSTRAINT [FK_ContractAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileProjectActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectActivities] DROP CONSTRAINT [FK_ProjectProfileProjectActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectActivityProjectSubActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_ProjectActivityProjectSubActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSubActivityProjectExpens]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectSubActivityProjectExpens];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileThefinancier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Thefinanciers] DROP CONSTRAINT [FK_ProjectProfileThefinancier];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_AccountTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Accounts] DROP CONSTRAINT [FK_ProjectProfileAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectProfileProjectOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectOrders] DROP CONSTRAINT [FK_ProjectProfileProjectOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountProjectActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectActivities] DROP CONSTRAINT [FK_AccountProjectActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountProjectSubActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_AccountProjectSubActivity];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountProjectExpens]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_AccountProjectExpens];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountProjectActivity1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectActivities] DROP CONSTRAINT [FK_AccountProjectActivity1];
GO
IF OBJECT_ID(N'[dbo].[FK_SupplierProjectExpens]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_SupplierProjectExpens];
GO
IF OBJECT_ID(N'[dbo].[FK_UserGroupUserSystem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSystems] DROP CONSTRAINT [FK_UserGroupUserSystem];
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
IF OBJECT_ID(N'[dbo].[Attachments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attachments];
GO
IF OBJECT_ID(N'[dbo].[Contracts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contracts];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[ProjectActivities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectActivities];
GO
IF OBJECT_ID(N'[dbo].[ProjectExpenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectExpenses];
GO
IF OBJECT_ID(N'[dbo].[ProjectOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectOrders];
GO
IF OBJECT_ID(N'[dbo].[ProjectProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[ProjectSubActivities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectSubActivities];
GO
IF OBJECT_ID(N'[dbo].[Thefinanciers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Thefinanciers];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts];
GO
IF OBJECT_ID(N'[dbo].[DailyMovemnts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DailyMovemnts];
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
    [UserGroup_Id] int  NULL
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

-- Creating table 'Attachments'
CREATE TABLE [dbo].[Attachments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AttachmentName] nvarchar(max)  NULL,
    [CreateDate] datetime  NOT NULL,
    [fileContent] varbinary(max)  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL,
    [ProjectOrder_ID] int  NOT NULL
);
GO

-- Creating table 'Contracts'
CREATE TABLE [dbo].[Contracts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [SelaryAmount] float  NOT NULL,
    [Status] bit  NOT NULL,
    [EmplyeeAccount_ID] int  NULL,
    [Employee_ID] int  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [EmployeeName] nvarchar(max)  NULL,
    [EmployeejobNumber] nvarchar(max)  NULL,
    [EmployeeGender] nvarchar(max)  NULL,
    [EmployeeNationalNumber] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Mobilenumber] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'ProjectActivities'
CREATE TABLE [dbo].[ProjectActivities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ActivityName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Status] nvarchar(max)  NULL,
    [Progress] int  NOT NULL,
    [TotalCost] float  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL,
    [Account_ID] int  NOT NULL,
    [Account1_ID] int  NOT NULL
);
GO

-- Creating table 'ProjectExpenses'
CREATE TABLE [dbo].[ProjectExpenses] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ExpensesName] nvarchar(max)  NULL,
    [DateofProcess] datetime  NOT NULL,
    [BillNumber] nvarchar(max)  NULL,
    [RequiarAmount] float  NOT NULL,
    [CashingNumber] nvarchar(max)  NULL,
    [ProjectSubActivity_ID] int  NOT NULL,
    [Account_ID] int  NOT NULL,
    [Supplier_ID] int  NOT NULL
);
GO

-- Creating table 'ProjectOrders'
CREATE TABLE [dbo].[ProjectOrders] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [OrderTitle] nvarchar(max)  NULL,
    [OrderBody] nvarchar(max)  NULL,
    [OrderDate] datetime  NOT NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'ProjectProfiles'
CREATE TABLE [dbo].[ProjectProfiles] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProjectName] nvarchar(max)  NULL,
    [ProjectDescription] nvarchar(max)  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Status] nvarchar(max)  NULL,
    [progress] int  NOT NULL,
    [TotalCost] float  NOT NULL
);
GO

-- Creating table 'ProjectSubActivities'
CREATE TABLE [dbo].[ProjectSubActivities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SubActivityName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [Startdate] datetime  NOT NULL,
    [enddate] datetime  NOT NULL,
    [Status] nvarchar(max)  NULL,
    [Persentage] int  NOT NULL,
    [TotalCost] nvarchar(max)  NOT NULL,
    [ProjectActivity_ID] int  NOT NULL,
    [Account_ID] int  NOT NULL
);
GO

-- Creating table 'Thefinanciers'
CREATE TABLE [dbo].[Thefinanciers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [financiername] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [agentName] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DateOfTransaction] datetime  NOT NULL,
    [TotalIn] float  NOT NULL,
    [TotalOut] float  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [CommandNames] nvarchar(max)  NULL,
    [Account_ID] int  NOT NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [SuppliersNatural] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL
);
GO

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AccountName] nvarchar(max)  NULL,
    [AccountDescription] nvarchar(max)  NULL,
    [Coin] nvarchar(max)  NULL,
    [AccountNatural] nvarchar(max)  NULL,
    [Contract_ID] int  NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'DailyMovemnts'
CREATE TABLE [dbo].[DailyMovemnts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FromAccout] int  NOT NULL,
    [ToAccount] int  NOT NULL,
    [Amount] float  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateOfProcess] datetime  NOT NULL
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

-- Creating primary key on [ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [PK_Attachments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [PK_Contracts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [PK_ProjectActivities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [PK_ProjectExpenses]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectOrders'
ALTER TABLE [dbo].[ProjectOrders]
ADD CONSTRAINT [PK_ProjectOrders]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectProfiles'
ALTER TABLE [dbo].[ProjectProfiles]
ADD CONSTRAINT [PK_ProjectProfiles]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [PK_ProjectSubActivities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Thefinanciers'
ALTER TABLE [dbo].[Thefinanciers]
ADD CONSTRAINT [PK_Thefinanciers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'DailyMovemnts'
ALTER TABLE [dbo].[DailyMovemnts]
ADD CONSTRAINT [PK_DailyMovemnts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SystemPermession_Id] in table 'GroupPermessions'
ALTER TABLE [dbo].[GroupPermessions]
ADD CONSTRAINT [FK_SystemPermessionGroupPermession]
    FOREIGN KEY ([SystemPermession_Id])
    REFERENCES [dbo].[SystemPermessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

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
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroupGroupPermession'
CREATE INDEX [IX_FK_UserGroupGroupPermession]
ON [dbo].[GroupPermessions]
    ([UserGroup_Id]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [FK_ProjectProfileAttachment]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileAttachment'
CREATE INDEX [IX_FK_ProjectProfileAttachment]
ON [dbo].[Attachments]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectOrder_ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [FK_ProjectOrderAttachment]
    FOREIGN KEY ([ProjectOrder_ID])
    REFERENCES [dbo].[ProjectOrders]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectOrderAttachment'
CREATE INDEX [IX_FK_ProjectOrderAttachment]
ON [dbo].[Attachments]
    ([ProjectOrder_ID]);
GO

-- Creating foreign key on [Employee_ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_EmployeeContract]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeContract'
CREATE INDEX [IX_FK_EmployeeContract]
ON [dbo].[Contracts]
    ([Employee_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_ProjectProfileContract]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileContract'
CREATE INDEX [IX_FK_ProjectProfileContract]
ON [dbo].[Contracts]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [Contract_ID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_ContractAccount]
    FOREIGN KEY ([Contract_ID])
    REFERENCES [dbo].[Contracts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractAccount'
CREATE INDEX [IX_FK_ContractAccount]
ON [dbo].[Accounts]
    ([Contract_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [FK_ProjectProfileProjectActivity]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileProjectActivity'
CREATE INDEX [IX_FK_ProjectProfileProjectActivity]
ON [dbo].[ProjectActivities]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectActivity_ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [FK_ProjectActivityProjectSubActivity]
    FOREIGN KEY ([ProjectActivity_ID])
    REFERENCES [dbo].[ProjectActivities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectActivityProjectSubActivity'
CREATE INDEX [IX_FK_ProjectActivityProjectSubActivity]
ON [dbo].[ProjectSubActivities]
    ([ProjectActivity_ID]);
GO

-- Creating foreign key on [ProjectSubActivity_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_ProjectSubActivityProjectExpens]
    FOREIGN KEY ([ProjectSubActivity_ID])
    REFERENCES [dbo].[ProjectSubActivities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectSubActivityProjectExpens'
CREATE INDEX [IX_FK_ProjectSubActivityProjectExpens]
ON [dbo].[ProjectExpenses]
    ([ProjectSubActivity_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Thefinanciers'
ALTER TABLE [dbo].[Thefinanciers]
ADD CONSTRAINT [FK_ProjectProfileThefinancier]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileThefinancier'
CREATE INDEX [IX_FK_ProjectProfileThefinancier]
ON [dbo].[Thefinanciers]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [Account_ID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_AccountTransaction]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountTransaction'
CREATE INDEX [IX_FK_AccountTransaction]
ON [dbo].[Transactions]
    ([Account_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [FK_ProjectProfileAccount]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileAccount'
CREATE INDEX [IX_FK_ProjectProfileAccount]
ON [dbo].[Accounts]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectOrders'
ALTER TABLE [dbo].[ProjectOrders]
ADD CONSTRAINT [FK_ProjectProfileProjectOrder]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectProfileProjectOrder'
CREATE INDEX [IX_FK_ProjectProfileProjectOrder]
ON [dbo].[ProjectOrders]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [Account_ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [FK_AccountProjectActivity]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountProjectActivity'
CREATE INDEX [IX_FK_AccountProjectActivity]
ON [dbo].[ProjectActivities]
    ([Account_ID]);
GO

-- Creating foreign key on [Account_ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [FK_AccountProjectSubActivity]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountProjectSubActivity'
CREATE INDEX [IX_FK_AccountProjectSubActivity]
ON [dbo].[ProjectSubActivities]
    ([Account_ID]);
GO

-- Creating foreign key on [Account_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_AccountProjectExpens]
    FOREIGN KEY ([Account_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountProjectExpens'
CREATE INDEX [IX_FK_AccountProjectExpens]
ON [dbo].[ProjectExpenses]
    ([Account_ID]);
GO

-- Creating foreign key on [Account1_ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [FK_AccountProjectActivity1]
    FOREIGN KEY ([Account1_ID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountProjectActivity1'
CREATE INDEX [IX_FK_AccountProjectActivity1]
ON [dbo].[ProjectActivities]
    ([Account1_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_SupplierProjectExpens]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierProjectExpens'
CREATE INDEX [IX_FK_SupplierProjectExpens]
ON [dbo].[ProjectExpenses]
    ([Supplier_ID]);
GO

-- Creating foreign key on [UserGroup_Id] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [FK_UserGroupUserSystem]
    FOREIGN KEY ([UserGroup_Id])
    REFERENCES [dbo].[UserGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroupUserSystem'
CREATE INDEX [IX_FK_UserGroupUserSystem]
ON [dbo].[UserSystems]
    ([UserGroup_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------