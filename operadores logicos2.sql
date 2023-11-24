-- Crear la tabla Persona
CREATE TABLE Persona (
    id_person int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre varchar(30) NOT NULL,
    Ap_Paterno varchar(25) NULL,
    Ap_Materno varchar(25) NOT NULL,
    Fecha_nac date NULL,
    CI int NOT NULL,
    Correo varchar(30) NULL,
    Telefono int NOT NULL,
    Estado int DEFAULT 1
);

-- Insertar algunos datos de ejemplo
INSERT INTO Persona (Nombre, Ap_Paterno, Ap_Materno, Fecha_nac, CI, Correo, Telefono)
VALUES 
    ('Juan', 'Gomez', 'Perez', '1990-05-15', 123456, 'juan@gmail.com', 5551234),
    ('Maria', 'Lopez', 'Gonzalez', '1985-08-20', 789012, 'maria@hotmail.com', 5555678);

-- Consulta utilizando alias
SELECT 
    id_person AS ID,
    Nombre,
    Ap_Paterno AS Paterno,
    Ap_Materno AS Materno,
    Fecha_nac AS FechaNacimiento,
    CI AS CedulaIdentidad,
    Correo,
    Telefono,
    Estado
FROM Persona;
