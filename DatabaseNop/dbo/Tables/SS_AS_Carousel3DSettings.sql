CREATE TABLE [dbo].[SS_AS_Carousel3DSettings] (
    [Id]              INT        IDENTITY (1, 1) NOT NULL,
    [SliderId]        INT        NOT NULL,
    [Width]           INT        NOT NULL,
    [Height]          INT        NOT NULL,
    [PictureWidth]    INT        NOT NULL,
    [PictureHeight]   INT        NOT NULL,
    [YRadius]         INT        NOT NULL,
    [XPosition]       INT        NOT NULL,
    [YPosition]       INT        NOT NULL,
    [Speed]           FLOAT (53) NOT NULL,
    [MouseWheel]      FLOAT (53) NOT NULL,
    [AutoRotateDelay] INT        NOT NULL,
    [AutoRotate]      BIT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Carousel3DSettings_SLider] FOREIGN KEY ([SliderId]) REFERENCES [dbo].[SS_AS_AnywhereSlider] ([Id]) ON DELETE CASCADE
);

