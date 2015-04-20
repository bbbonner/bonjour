CREATE TABLE [dbo].[SS_C_CustomerOverride] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [ConditionId]   INT NOT NULL,
    [CustomerId]    INT NOT NULL,
    [OverrideState] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CustomerOverride_ConditionEntity] FOREIGN KEY ([ConditionId]) REFERENCES [dbo].[SS_C_Condition] ([Id]) ON DELETE CASCADE
);

