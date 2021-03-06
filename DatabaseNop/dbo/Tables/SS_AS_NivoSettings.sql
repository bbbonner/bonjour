﻿CREATE TABLE [dbo].[SS_AS_NivoSettings] (
    [Id]                                 INT            IDENTITY (1, 1) NOT NULL,
    [SliderId]                           INT            NOT NULL,
    [AutoSlideInterval]                  INT            NOT NULL,
    [AnimationSpeed]                     INT            NOT NULL,
    [EnableDirectionNavigation]          BIT            NOT NULL,
    [DirectionNavigationShowOnHoverOnly] BIT            NOT NULL,
    [KeyboardNavigation]                 BIT            NOT NULL,
    [EnableControlNavigation]            BIT            NOT NULL,
    [EnableControlNavigationThumbs]      BIT            NOT NULL,
    [ThumbsBiggerSize]                   INT            NOT NULL,
    [CaptionOpacity]                     REAL           NOT NULL,
    [PrevText]                           NVARCHAR (MAX) NULL,
    [NextText]                           NVARCHAR (MAX) NULL,
    [Links]                              BIT            NOT NULL,
    [Width]                              INT            NOT NULL,
    [Height]                             INT            NOT NULL,
    [PauseOnHover]                       BIT            NOT NULL,
    [ShowCaption]                        BIT            NOT NULL,
    [Effect]                             NVARCHAR (MAX) NULL,
    [Slices]                             INT            NOT NULL,
    [BoxCols]                            INT            NOT NULL,
    [BoxRows]                            INT            NOT NULL,
    [Theme]                              NVARCHAR (MAX) NULL,
    [RandomStart]                        BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [NivoSettings_Slider] FOREIGN KEY ([SliderId]) REFERENCES [dbo].[SS_AS_AnywhereSlider] ([Id]) ON DELETE CASCADE
);

