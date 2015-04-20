CREATE TABLE [dbo].[SS_MAP_EntityWidgetMapping] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [EntityType]   INT            NOT NULL,
    [EntityId]     INT            NOT NULL,
    [WidgetZone]   NVARCHAR (MAX) NULL,
    [DisplayOrder] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

