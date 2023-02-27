CREATE TABLE [dbo].Tratamientos(
	[id] INT NOT NULL, 
    [nombre] VARCHAR(50) NOT NULL, 
    [tipo] VARCHAR(150) NOT NULL,
    [descripcion] VARCHAR(200) NOT NULL,
    [precio] INT NOT NULL,
    CONSTRAINT [PK_Tratamientos] PRIMARY KEY ([id])
);
