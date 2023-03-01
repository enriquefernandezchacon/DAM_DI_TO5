CREATE TABLE [dbo].Empleados(
	[id] INT IDENTITY (1, 1) NOT NULL, 
    [nombre] VARCHAR(50) NOT NULL,
	[apellidos] VARCHAR(100) NOT NULL,
	[dni] VARCHAR(9) NOT NULL,
	[email] VARCHAR(100) NOT NULL,
	[telefono] VARCHAR(20) NOT NULL,
	[puesto] VARCHAR(50) NOT NULL,
	CONSTRAINT [PK_Empleados] PRIMARY KEY ([id])
);
