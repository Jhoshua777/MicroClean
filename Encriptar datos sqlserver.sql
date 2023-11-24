CREATE FUNCTION dbo.EncryptData(@data NVARCHAR(255))
RETURNS VARBINARY(MAX)
AS
BEGIN
    RETURN ENCRYPTBYPASSPHRASE('YourSecretPassphrase', @data);
END;

-- Actualizar datos cifrados en la tabla Proveedores (reemplazando tel?fono y email)
UPDATE Proveedores
SET 
    Telfono = dbo.EncryptData(Telfono),
    Email = dbo.EncryptData(Email);

-- Seleccionar datos cifrados
SELECT
    Id_proveedor,
    dbo.EncryptData(Telfono) AS telefono_encriptado,
    dbo.EncryptData(Email) AS email_encriptado
FROM
    Proveedores;



	CREATE TABLE Proveedores
(
      Id_proveedor int not null primary key identity(1,1),
	  Nombre varchar(50) not null,
	  Nit numeric(18,2) not null,
	  Direccion varchar (50) not null,
	  Ciudad varchar(50) not null,
	  Telfono numeric(18,2) not null,
	  Contacto numeric(18) not null,
	  Email varchar(50) not null
);



INSERT INTO Proveedores(Nombre, Nit,Direccion,Ciudad,Telfono,Contacto, Email)
VALUES('Juan','123456789','Mendez','sucre',12345678,'124587','jmoya@gmail.com');

INSERT INTO Proveedores(Nombre, Nit,Direccion,Ciudad,Telfono,Contacto, Email)
VALUES('Jose','123456759','Mendesa','Beni',12344678,'134587','jmoya46@gmail.com');

SELECT * FROM Proveedores