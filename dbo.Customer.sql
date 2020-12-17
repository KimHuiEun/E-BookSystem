CREATE TABLE [dbo].[Customer] (
    [CustomerId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [BirthYear]  INT      NOT NULL,
    [Gender]     NVARCHAR (10) NOT NULL,
    [Phone]      VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

