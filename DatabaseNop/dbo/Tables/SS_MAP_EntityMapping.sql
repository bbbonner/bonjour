CREATE TABLE [dbo].[SS_MAP_EntityMapping] (
    [Id]             INT IDENTITY (1, 1) NOT NULL,
    [EntityType]     INT NOT NULL,
    [EntityId]       INT NOT NULL,
    [MappedEntityId] INT NOT NULL,
    [DisplayOrder]   INT NOT NULL,
    [MappingType]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

