﻿CREATE TABLE [dbo].[TBCOSTUMER]
(
	[Id] UNIQUEIDENTIFIER NOT NULL ,
	[Name] VARCHAR(75) NOT NULL, 
    [IndentityDocument] VARCHAR(15) NULL, 
    [PhoneNumber] VARCHAR(30) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
