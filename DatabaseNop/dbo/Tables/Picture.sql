CREATE TABLE [dbo].[Picture] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [PictureBinary] VARBINARY (MAX) NULL,
    [MimeType]      NVARCHAR (40)   NOT NULL,
    [SeoFilename]   NVARCHAR (300)  NULL,
    [IsNew]         BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

