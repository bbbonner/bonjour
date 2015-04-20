CREATE TABLE [dbo].[SS_C_ConditionStatement] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [ConditionType]     INT            NOT NULL,
    [ConditionProperty] INT            NOT NULL,
    [OperatorType]      INT            NOT NULL,
    [Value]             NVARCHAR (MAX) NULL,
    [ConditionGroupId]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [ConditionStatement_ConditionGroupEntity] FOREIGN KEY ([ConditionGroupId]) REFERENCES [dbo].[SS_C_ConditionGroup] ([Id]) ON DELETE CASCADE
);

