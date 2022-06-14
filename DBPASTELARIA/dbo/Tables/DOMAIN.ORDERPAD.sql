CREATE TABLE [dbo].[DOMAIN.ORDERPAD] (
    [Id]                    UNIQUEIDENTIFIER NOT NULL,
    [EmployeeId]            UNIQUEIDENTIFIER NULL,
    [CustomerId]            UNIQUEIDENTIFIER NULL,
    [OpenTime]              DATE             NOT NULL,
    [OrderPadStatus]        INT              NOT NULL,
    [OrderPadPaymentStatus] INT              NOT NULL,
    [Total]                 DECIMAL (25, 2)  NOT NULL,
    CONSTRAINT [PK_DOMAIN.ORDERPAD] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DOMAIN.ORDERPAD_DOMAIN.CUSTOMER_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[DOMAIN.CUSTOMER] ([Id]),
    CONSTRAINT [FK_DOMAIN.ORDERPAD_DOMAIN.EMPLOYEE_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[DOMAIN.EMPLOYEE] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_DOMAIN.ORDERPAD_EmployeeId]
    ON [dbo].[DOMAIN.ORDERPAD]([EmployeeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_DOMAIN.ORDERPAD_CustomerId]
    ON [dbo].[DOMAIN.ORDERPAD]([CustomerId] ASC);

