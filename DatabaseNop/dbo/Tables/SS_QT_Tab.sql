CREATE TABLE [dbo].[SS_QT_Tab] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [SystemName]      NVARCHAR (400) NOT NULL,
    [DisplayName]     NVARCHAR (400) NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [LimitedToStores] BIT            NOT NULL,
    [TabMode]         INT            NOT NULL,
    [DisplayOrder]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

