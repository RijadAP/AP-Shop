CREATE TABLE [dbo].[ProductDetails] (
    [Id]            INT           NOT NULL,
    [ProductId]     INT           NOT NULL,
    [DatePublished] DATE          NOT NULL,
    [Condition]     INT           NOT NULL,
    [Gender]        INT           NOT NULL,
    [Color]         INT           NOT NULL,
    [Model]         INT           NOT NULL,
    [PublishedBy]   VARCHAR (150) NOT NULL,
    [ShippingFrom]  VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductDetails_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);



