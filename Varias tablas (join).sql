
---INNER JOIN para encontrar proveedores con información de contacto de la persona----
SELECT 
    P.Id_proveedor,
    P.Nombre AS NombreProveedor,
    P.Nit,
    P.Razon,
    P.Direccion,
    P.Ciudad,
    P.Telefono AS TelefonoProveedor,
    Pe.Nombre AS NombreContacto,
    Pe.Ap_Paterno AS ApellidoContacto,
    Pe.Telefono AS TelefonoContacto
FROM Proveedor P
INNER JOIN Persona Pe ON P.Contacto = Pe.id_person;

----LEFT JOIN para mostrar todos los proveedores y sus contactos ------
SELECT 
    P.Id_proveedor,
    P.Nombre AS NombreProveedor,
    P.Nit,
    P.Razon,
    P.Direccion,
    P.Ciudad,
    P.Telefono AS TelefonoProveedor,
    Pe.Nombre AS NombreContacto,
    Pe.Ap_Paterno AS ApellidoContacto,
    Pe.Telefono AS TelefonoContacto
FROM Proveedor P
LEFT JOIN Persona Pe ON P.Contacto = Pe.id_person;


-----EN SQL SERVER---------BEST SGBD