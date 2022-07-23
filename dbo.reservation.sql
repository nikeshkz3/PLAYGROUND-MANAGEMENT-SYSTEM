CREATE TABLE [dbo].[reservation] (
    [Id]                 INT          IDENTITY (1, 1) NOT NULL,
    [customer_name]      TEXT         NULL,
    [customer_phoneno]   VARCHAR(50)          NULL,
    [date]               VARCHAR (50) NULL,
    [batchID]            INT          NULL,
    [playgroundID]       INT          NULL,
    [reservation_number] INT          NULL,
    [bill]           INT         NULL,
    [payment_feedback] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [rfr_playground] FOREIGN KEY ([playgroundID]) REFERENCES [dbo].[playground] ([Id]),
    CONSTRAINT [rfr_batchID] FOREIGN KEY ([batchID]) REFERENCES [dbo].[batch] ([Id])
);

