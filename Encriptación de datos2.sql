CREATE FUNCTION dbo.EncryptData(@data NVARCHAR(255))
RETURNS VARBINARY(MAX)
AS
BEGIN
    RETURN ENCRYPTBYPASSPHRASE('YourSecretPassphrase', @data);
END;

-- Actualizar datos cifrados en la tabla Proveedores (reemplazando tel?fono y email)
UPDATE Proveedor
SET 
    Telefono = dbo.EncryptData(Telefono),
    Contacto = dbo.EncryptData( Contacto);

-- Seleccionar datos cifrados
SELECT
    Id_proveedor,
    dbo.EncryptData(Telefono) AS Telefono_encriptado,
    dbo.EncryptData(Contacto ) AS Contacto_encriptado
FROM
    Proveedor;