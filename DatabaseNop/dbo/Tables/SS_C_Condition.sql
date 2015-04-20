CREATE TABLE [dbo].[SS_C_Condition] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (MAX) NULL,
    [Active] BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

