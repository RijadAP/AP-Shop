CREATE TABLE [dbo].[Product] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Code]             VARCHAR (200) NOT NULL,
    [isActive]         BIT           NOT NULL,
    [Name]             VARCHAR (50)  NOT NULL,
    [Image]            VARCHAR (500) NOT NULL,
    [ShortDescription] VARCHAR (500) NOT NULL,
    [Price]            FLOAT (53)    NOT NULL,
    [ShippingPrice]    FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);



