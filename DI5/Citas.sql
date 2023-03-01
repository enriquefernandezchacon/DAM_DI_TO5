CREATE TABLE [dbo].Citas(
	[id] INT IDENTITY (1, 1) NOT NULL, 
    [fecha] DATE NOT NULL,
    [hora] TIME NOT NULL,
    [forma_pago] VARCHAR(50) NOT NULL,
    [id_cliente] INT NOT NULL,
    [id_tratamiento] INT NOT NULL,
    [observaciones] VARCHAR(500) NULL,
    CONSTRAINT [PK_Citas] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Citas_Clientes] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].Clientes([id]),
    CONSTRAINT [FK_Citas_Tratamientos] FOREIGN KEY ([id_tratamiento]) REFERENCES [dbo].Tratamientos([id])
);
