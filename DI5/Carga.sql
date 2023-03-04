BEGIN TRAN

-- Insertar 50 clientes aleatorios
INSERT INTO Clientes (nombre, apellidos, email, telefono)
SELECT TOP 50
CONCAT('Cliente', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CONCAT('Apellido', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CONCAT('cliente', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CAST(RAND()*100000000 AS VARCHAR(15))
FROM sys.objects

-- Insertar 50 empleados aleatorios
INSERT INTO Empleados (nombre, apellidos, dni, email, telefono, puesto)
SELECT TOP 50
CONCAT('Empleado', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CONCAT('Apellido', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CAST(RAND()*100000000 AS VARCHAR(9)),
CONCAT('empleado', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CAST(RAND()*100000000 AS VARCHAR(15)),
CONCAT('Puesto', ROW_NUMBER() OVER (ORDER BY (SELECT NULL)))
FROM sys.objects

-- Insertar 50 tratamientos aleatorios
INSERT INTO Tratamientos (nombre, tipo, descripcion, precio)
SELECT TOP 50
CONCAT('Tratamiento', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CONCAT('Tipo', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CONCAT('Descripción', ROW_NUMBER() OVER (ORDER BY (SELECT NULL))),
CAST(RAND()*100 AS INT)
FROM sys.objects

-- Insertar 50 aplicaciones de tratamiento aleatorios
INSERT INTO AplicacionTratamientos (id_cliente, id_tratamiento, id_trabajador, coste)
SELECT TOP 50
ROUND(RAND()*49 + 1, 0),
ROUND(RAND()*49 + 1, 0),
(SELECT TOP 1 id FROM Empleados ORDER BY NEWID()),
CAST(RAND()*100 AS INT)
FROM sys.objects

-- Insertar 50 citas aleatorias
INSERT INTO Citas (fecha, hora, forma_pago, id_cliente, id_tratamiento, observaciones)
SELECT TOP 50
DATEADD(day, ROUND(RAND()*730, 0), '2021-01-01'),
CONVERT(time, DATEADD(minute, ROUND(RAND()*1360, 0), '2021-01-01 09:00')),
CASE WHEN ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) % 2 = 0 THEN 'Efectivo' ELSE 'Tarjeta' END,
ROUND(RAND()*49 + 1, 0),
ROUND(RAND()*49 + 1, 0),
CONCAT('Observaciones', ROW_NUMBER() OVER (ORDER BY (SELECT NULL)))
FROM sys.objects

-- Insertar 7 citas con la misma fecha
DECLARE @fecha DATE = '2023-01-01'

INSERT INTO Citas (fecha, hora, forma_pago, id_cliente, id_tratamiento, observaciones)
SELECT TOP 7
@fecha,
CONVERT(time, DATEADD(minute, ROUND(RAND()*1360, 0), @fecha)),
CASE WHEN ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) % 2 = 0 THEN 'Efectivo' ELSE 'Tarjeta' END,
ROUND(RAND()*49 + 1, 0),
ROUND(RAND()*49 + 1, 0),
CONCAT('Observaciones', ROW_NUMBER() OVER (ORDER BY (SELECT NULL)))
FROM sys.objects

-- Finalizar la transacción
IF @@ERROR <> 0
BEGIN
ROLLBACK
END
ELSE
BEGIN
COMMIT
END