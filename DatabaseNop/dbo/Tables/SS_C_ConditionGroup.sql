CREATE TABLE [dbo].[SS_C_ConditionGroup] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [ConditionId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [ConditionGroup_ConditionEntity] FOREIGN KEY ([ConditionId]) REFERENCES [dbo].[SS_C_Condition] ([Id]) ON DELETE CASCADE
);

