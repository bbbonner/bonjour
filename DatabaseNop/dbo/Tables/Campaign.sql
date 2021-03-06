﻿CREATE TABLE [dbo].[Campaign] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [Subject]      NVARCHAR (MAX) NOT NULL,
    [Body]         NVARCHAR (MAX) NOT NULL,
    [StoreId]      INT            NOT NULL,
    [CreatedOnUtc] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

