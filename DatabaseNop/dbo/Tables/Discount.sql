CREATE TABLE [dbo].[Discount] (
    [Id]                        INT             IDENTITY (1, 1) NOT NULL,
    [Name]                      NVARCHAR (200)  NOT NULL,
    [DiscountTypeId]            INT             NOT NULL,
    [UsePercentage]             BIT             NOT NULL,
    [DiscountPercentage]        DECIMAL (18, 4) NOT NULL,
    [DiscountAmount]            DECIMAL (18, 4) NOT NULL,
    [StartDateUtc]              DATETIME        NULL,
    [EndDateUtc]                DATETIME        NULL,
    [RequiresCouponCode]        BIT             NOT NULL,
    [CouponCode]                NVARCHAR (100)  NULL,
    [DiscountLimitationId]      INT             NOT NULL,
    [LimitationTimes]           INT             NOT NULL,
    [MaximumDiscountedQuantity] INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

