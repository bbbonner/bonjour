CREATE TABLE [dbo].[SS_AS_AnywhereSlider] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [SystemName]      NVARCHAR (400) NOT NULL,
    [SliderType]      INT            NOT NULL,
    [LanguageId]      INT            NOT NULL,
    [LimitedToStores] BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

