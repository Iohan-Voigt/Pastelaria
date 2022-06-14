CREATE TABLE [dbo].[DOMAIN.PRODUCT] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        VARCHAR (75)     NOT NULL,
    [Value]       DECIMAL (25, 2)  NOT NULL,
    [Description] VARCHAR (100)    NULL,
    [Image]       VARBINARY (MAX)  NULL,
    CONSTRAINT [PK_DOMAIN.PRODUCT] PRIMARY KEY CLUSTERED ([Id] ASC)
);

