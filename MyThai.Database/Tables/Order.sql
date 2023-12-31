﻿CREATE TABLE [dbo].[Order]
(
	[Id_Order] INT NOT NULL, 
	[ClientPhone] VARCHAR(50) NOT NULL,
	[ClientName] NVARCHAR(50) NOT NULL,
	[OrdeRDate] DATETIME2 NOT NULL DEFAULT(GETDATE()),
	[ReadyDate] DATETIME2 NOT NULL,
	[OrderPrice] DECIMAL(9,2) NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY ([Id_Order]) 
)
