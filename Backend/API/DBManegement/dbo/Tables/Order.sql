CREATE TABLE [dbo].[Order] (
    [Id]     INT  IDENTITY (1, 1) NOT NULL,
    [UserId] INT  NOT NULL,
    [Date]   DATE NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Order_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

