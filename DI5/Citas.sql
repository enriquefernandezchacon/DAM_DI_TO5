CREATE TABLE [dbo].Citas(
	[id] INT IDENTITY (1, 1) NOT NULL, 
    [fecha] DATE NOT NULL,
    [hora] TIME NOT NULL,
    [forma_pago] VARCHAR(50) NOT NULL,
    [id_aplicaciontratamiento] INT NOT NULL,
    [observaciones] VARCHAR(500) NULL,
    CONSTRAINT [PK_Citas] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Citas_AplicacionTratamientos] FOREIGN KEY ([id_aplicaciontratamiento]) REFERENCES [dbo].AplicacionTratamientos);
