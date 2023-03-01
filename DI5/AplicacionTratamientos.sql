CREATE TABLE [dbo].AplicacionTratamientos(
	[id] INT IDENTITY (1, 1) NOT NULL, 
	[id_cliente] INT NOT NULL,
	[id_tratamiento] INT NOT NULL,
	[id_trabajador] INT NOT NULL,
	[coste] INT NOT NULL, 
    CONSTRAINT [PK_AplicacionTratamientos] PRIMARY KEY ([id]),
	CONSTRAINT [FK_AplicacionTratamientos_Clientes] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].Clientes([id]),
	CONSTRAINT [FK_AplicacionTratamientos_Tratamientos] FOREIGN KEY ([id_tratamiento]) REFERENCES [dbo].Tratamientos([id]),
	CONSTRAINT [FK_AplicacionTratamientos_Empleados] FOREIGN KEY ([id_trabajador]) REFERENCES [dbo].Empleados([id])
);
