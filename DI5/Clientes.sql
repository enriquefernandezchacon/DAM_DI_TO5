﻿CREATE TABLE [dbo].Clientes(
	[id] INT NOT NULL, 
    [nombre] VARCHAR(50) NOT NULL, 
    [apellidos] VARCHAR(100) NOT NULL,
    [email] VARCHAR(100) NOT NULL,
    [telefono] VARCHAR(20) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([id])
);
