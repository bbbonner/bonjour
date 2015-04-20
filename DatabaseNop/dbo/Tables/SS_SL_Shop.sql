CREATE TABLE [dbo].[SS_SL_Shop] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [IsVisible]        BIT            NULL,
    [Name]             NVARCHAR (400) NOT NULL,
    [Latitude]         NVARCHAR (MAX) NULL,
    [Longitude]        NVARCHAR (MAX) NULL,
    [ShortDescription] NVARCHAR (MAX) NULL,
    [FullDescription]  NVARCHAR (MAX) NULL,
    [MetaTitle]        NVARCHAR (MAX) NULL,
    [MetaKeywords]     NVARCHAR (MAX) NULL,
    [MetaDescription]  NVARCHAR (MAX) NULL,
    [DisplayOrder]     INT            NULL,
    [LimitedToStores]  BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

