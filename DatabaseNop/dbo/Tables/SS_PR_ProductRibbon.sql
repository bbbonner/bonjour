CREATE TABLE [dbo].[SS_PR_ProductRibbon] (
    [Id]                                    INT            IDENTITY (1, 1) NOT NULL,
    [Enabled]                               BIT            NOT NULL,
    [Name]                                  NVARCHAR (MAX) NULL,
    [StopAddingRibbonsAftherThisOneIsAdded] BIT            NOT NULL,
    [Priority]                              INT            NOT NULL,
    [FromDate]                              DATETIME       NULL,
    [ToDate]                                DATETIME       NULL,
    [LimitedToStores]                       BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

