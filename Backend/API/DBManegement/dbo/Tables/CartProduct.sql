CREATE TABLE [dbo].[CartProduct] (
    [Id]          INT NOT NULL,
    [CartId]      INT IDENTITY (1, 1) NOT NULL,
    [ProductCode] INT NOT NULL,
    [Quantity]    INT NOT NULL,
    CONSTRAINT [PK_CartProduct] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CartProduct_Cart] FOREIGN KEY ([CartId]) REFERENCES [dbo].[Cart] ([Id])
);

