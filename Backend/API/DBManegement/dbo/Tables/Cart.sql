CREATE TABLE [dbo].[Cart] (
    [Id]              INT      NOT NULL,
    [UserId]          INT      IDENTITY (1, 1) NOT NULL,
    [DateLastUpdated] DATETIME NULL,
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cart_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

