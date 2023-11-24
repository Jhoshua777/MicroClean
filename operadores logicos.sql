-- Insertar proveedores ficticios
INSERT INTO Proveedor (Nombre, Nit, Razon, Direccion, Ciudad, Telefono, Contacto, Email, Fecha_Mod, Fecha_Creac, Estado)
VALUES 
    ('Proveedor A', 123456789, 'Razón A', 'Calle 123', 'La Paz', 5551234, 987654321, 'proveedora@example.com', GETDATE(), GETDATE(), 1),
    ('Proveedor B', 987654321, 'Razón B', 'Avenida 456', 'Santa Cruz', 5555678, 123456789, 'proveedorb@example.com', GETDATE(), GETDATE(), 1),
    ('Proveedor C', 555555555, 'Razón C', 'Calle Principal', 'Cochabamba', 5559876, 456789012, 'proveedorc@example.com', GETDATE(), GETDATE(), 1);

-- Insertar un proveedor inactivo (Estado = 0)
INSERT INTO Proveedor (Nombre, Nit, Razon, Direccion, Ciudad, Telefono, Contacto, Email, Fecha_Mod, Fecha_Creac, Estado)
VALUES 
    ('Proveedor Inactivo', 111111111, 'Razón Inactiva', 'Calle Inactiva', 'La Paz', 5551111, 111111111, 'proveedorinactivo@example.com', GETDATE(), GETDATE(), 0);

-- Seleccionar proveedores cuyo estado sea activo (Estado = 1) y estén en la ciudad 'La Paz'
SELECT *
FROM Proveedor
WHERE Estado = 1 AND Ciudad = 'La Paz';

-- Seleccionar proveedores cuyo estado no sea activo (Estado ≠ 1)
SELECT *
FROM Proveedor
WHERE Estado <> 1;

-- Seleccionar proveedores cuyo estado sea activo (Estado = 1) y estén en una ciudad específica o tengan un correo electrónico válido
SELECT *
FROM Proveedor
WHERE Estado = 1 AND (Ciudad = 'Santa Cruz' OR Email LIKE '%@dominio.com');


