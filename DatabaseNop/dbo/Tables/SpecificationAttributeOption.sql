CREATE TABLE [dbo].[SpecificationAttributeOption] (
    [Id]                       INT            IDENTITY (1, 1) NOT NULL,
    [SpecificationAttributeId] INT            NOT NULL,
    [Name]                     NVARCHAR (MAX) NOT NULL,
    [DisplayOrder]             INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [SpecificationAttributeOption_SpecificationAttribute] FOREIGN KEY ([SpecificationAttributeId]) REFERENCES [dbo].[SpecificationAttribute] ([Id]) ON DELETE CASCADE
);

