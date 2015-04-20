CREATE TABLE [dbo].[SS_C_EntityCondition] (
    [Id]              INT IDENTITY (1, 1) NOT NULL,
    [ConditionId]     INT NOT NULL,
    [EntityType]      INT NOT NULL,
    [EntityId]        INT NOT NULL,
    [LimitedToStores] BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [EntityCondition_ConditionEntity] FOREIGN KEY ([ConditionId]) REFERENCES [dbo].[SS_C_Condition] ([Id]) ON DELETE CASCADE
);

