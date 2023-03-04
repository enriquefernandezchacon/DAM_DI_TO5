-- Seleccionar aleatoriamente clientes, tratamientos y empleados
WITH cteClientes AS (
  SELECT TOP 20 id FROM [dbo].Clientes ORDER BY NEWID()
), cteTratamientos AS (
  SELECT TOP 15 id FROM [dbo].Tratamientos ORDER BY NEWID()
), cteEmpleados AS (
  SELECT TOP 10 id FROM [dbo].Empleados ORDER BY NEWID()
)
-- Insertar 50 registros aleatorios en la tabla AplicacionTratamientos
INSERT INTO [dbo].AplicacionTratamientos ([id_cliente], [id_tratamiento], [id_trabajador], [coste])
SELECT 
    cteClientes.id AS id_cliente,
    cteTratamientos.id AS id_tratamiento,
    cteEmpleados.id AS id_trabajador,
    FLOOR(RAND()*(100-30+1)+30) AS coste
FROM 
    cteClientes 
    CROSS JOIN cteTratamientos 
    CROSS JOIN cteEmpleados;