




CREATE FUNCTION ObtenerInfoProveedor
(
    @NIT VARCHAR(20)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        Nombre,
        Razon,
        Direccion,
        Ciudad,
        Telefono,
        Contacto,
        Email,
        Fecha_Mod,
        Fecha_Creac
    FROM Proveedor
    WHERE NIT = @NIT
);



-- Crear el disparador
CREATE TRIGGER tr_AuditoriaModificacionProveedor
ON Proveedor
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Proveedor
    SET Fecha_Mod = GETDATE()
    FROM Proveedor p
    INNER JOIN inserted i ON p.NIT = i.NIT;
END;