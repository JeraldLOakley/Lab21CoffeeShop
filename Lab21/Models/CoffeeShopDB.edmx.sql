
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2018 15:43:50
-- Generated from EDMX file: C:\Users\Jerald\source\repos\Lab21CoffeeShop\Lab21\Models\CoffeeShopDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CoffeeShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NOT NULL,
    [Description] nvarchar(50)  NOT NULL,
    [Price] nvarchar(20)  NOT NULL,
    [Stock] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Email] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(20)  NOT NULL,
    [LastName] nvarchar(20)  NOT NULL,
    [Address] nvarchar(40)  NOT NULL,
    [PhoneNumber] nvarchar(15)  NOT NULL,
    [PreferredCoffee] nvarchar(35)  NULL,
    [FavoriteMusic] nvarchar(20)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Email] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Email] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------