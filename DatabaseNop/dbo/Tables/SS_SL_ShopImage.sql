CREATE TABLE [dbo].[SS_SL_ShopImage] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [ShopId]       INT            NOT NULL,
    [PictureId]    INT            NOT NULL,
    [Visible]      BIT            NOT NULL,
    [DisplayOrder] INT            NOT NULL,
    [Alt]          NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [ShopImage_Shop] FOREIGN KEY ([ShopId]) REFERENCES [dbo].[SS_SL_Shop] ([Id]) ON DELETE CASCADE
);

