CREATE TABLE [dbo].[DOMAIN.CUSTOMER] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Name]             VARCHAR (75)     NOT NULL,
    [IdentityDocument] VARCHAR (14)     NULL,
    [PhoneNumber]      VARCHAR (20)     NULL,
    CONSTRAINT [PK_DOMAIN.CUSTOMER] PRIMARY KEY CLUSTERED ([Id] ASC)
);

