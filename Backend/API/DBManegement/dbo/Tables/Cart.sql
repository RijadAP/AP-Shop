CREATE TABLE [dbo].[Cart] (
    [Id]              INT      IDENTITY (1, 1) NOT NULL,
    [UserId]          INT      NOT NULL,
    [DateLastUpdated] DATETIME NOT NULL,
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cart_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);















