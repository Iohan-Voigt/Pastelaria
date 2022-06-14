CREATE TABLE [dbo].[DOMAIN.EMPLOYEE] (
    [Id]                      UNIQUEIDENTIFIER NOT NULL,
    [AcessUser]               VARCHAR (20)     NOT NULL,
    [Password]                VARCHAR (20)     NOT NULL,
    [Registration]            VARCHAR (30)     NOT NULL,
    [EmployeePermissionsEnum] INT              NOT NULL,
    [EmployeeActiveEnum]      INT              NOT NULL,
    [Name]                    VARCHAR (75)     NOT NULL,
    [IdentityDocument]        VARCHAR (14)     NOT NULL,
    [PhoneNumber]             VARCHAR (20)     NOT NULL,
    CONSTRAINT [PK_DOMAIN.EMPLOYEE] PRIMARY KEY CLUSTERED ([Id] ASC)
);

