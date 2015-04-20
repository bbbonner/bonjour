CREATE TABLE [dbo].[Topic] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [SystemName]          NVARCHAR (MAX) NULL,
    [IncludeInSitemap]    BIT            NOT NULL,
    [IncludeInTopMenu]    BIT            NOT NULL,
    [IsPasswordProtected] BIT            NOT NULL,
    [Password]            NVARCHAR (MAX) NULL,
    [Title]               NVARCHAR (MAX) NULL,
    [Body]                NVARCHAR (MAX) NULL,
    [MetaKeywords]        NVARCHAR (MAX) NULL,
    [MetaDescription]     NVARCHAR (MAX) NULL,
    [MetaTitle]           NVARCHAR (MAX) NULL,
    [LimitedToStores]     BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

