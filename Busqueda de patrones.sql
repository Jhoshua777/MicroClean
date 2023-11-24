SELECT * FROM Persona;
---Obtener todos los clientes con sus historiales de compras-----
SELECT Cliente.*, Persona.Nombre, Persona.Edad
FROM Cliente
JOIN Persona ON Cliente.PersonaID = Persona.ID;

---Buscar empleados por departamento-------

SELECT Empleado.*, Persona.Nombre, Persona.Edad
FROM Empleado
JOIN Persona ON Empleado.PersonaID = Persona.ID
WHERE Empleado.Departamento = 'Ventas';


---Buscar empleados con un salario mayor a cierta cantidad-----
SELECT Empleado.*, Persona.Nombre, Persona.Edad
FROM Empleado
JOIN Persona ON Empleado.PersonaID = Persona.ID
WHERE Empleado.Salario > 50000;


