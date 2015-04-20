CREATE TABLE [dbo].[SS_AS_CarouselSettings] (
    [Id]                INT IDENTITY (1, 1) NOT NULL,
    [SliderId]          INT NOT NULL,
    [AutoSlideInterval] INT NOT NULL,
    [Navigation]        BIT NOT NULL,
    [Links]             BIT NOT NULL,
    [Width]             INT NOT NULL,
    [Height]            INT NOT NULL,
    [HoverPause]        BIT NOT NULL,
    [ShowTitle]         BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CarouselSettings_Slider] FOREIGN KEY ([SliderId]) REFERENCES [dbo].[SS_AS_AnywhereSlider] ([Id]) ON DELETE CASCADE
);

