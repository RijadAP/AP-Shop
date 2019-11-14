CREATE TABLE [dbo].[ProductDetails] (
    [Id]            INT           NOT NULL,
    [ProductId]     INT           NOT NULL,
    [DatePublished] DATE          NOT NULL,
    [Condition]     VARCHAR (20)  NOT NULL,
    [Gender]        VARCHAR (20)  NOT NULL,
    [Color]         VARCHAR (20)  NOT NULL,
    [Model]         VARCHAR (20)  NOT NULL,
    [PublishedBy]   VARCHAR (150) NOT NULL,
    [ShippingFrom]  VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductDetails_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

