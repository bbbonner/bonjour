CREATE TABLE [dbo].[SS_AS_SliderImage] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [DisplayText]  NVARCHAR (MAX) NULL,
    [Url]          NVARCHAR (MAX) NULL,
    [Alt]          NVARCHAR (MAX) NULL,
    [Visible]      BIT            NOT NULL,
    [DisplayOrder] INT            NOT NULL,
    [PictureId]    INT            NOT NULL,
    [SliderId]     INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [SliderImage_Slider] FOREIGN KEY ([SliderId]) REFERENCES [dbo].[SS_AS_AnywhereSlider] ([Id]) ON DELETE CASCADE
);

