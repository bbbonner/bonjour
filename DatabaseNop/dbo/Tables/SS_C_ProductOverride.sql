CREATE TABLE [dbo].[SS_C_ProductOverride] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [ConditionId]  INT NOT NULL,
    [ProductId]    INT NOT NULL,
    [ProductState] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [ProductOverride_ConditionEntity] FOREIGN KEY ([ConditionId]) REFERENCES [dbo].[SS_C_Condition] ([Id]) ON DELETE CASCADE
);

