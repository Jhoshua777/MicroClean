USE bdMicroclean
GO

CREATE TABLE Proveedor(
	Id_proveedor int IDENTITY(1,1) NOT NULL,
	Nombre varchar(50) NOT NULL,
	Nit int NOT NULL,
	Razon varchar(50) NOT NULL,
	Direccion varchar(50) NOT NULL,
	Ciudad varchar(50) NOT NULL,
	Telefono int NOT NULL,
	Contacto int NOT NULL,
	Email varchar(50) NOT NULL,
	Fecha_Mod datetime NULL,
	Fecha_Creac datetime NULL,
	Estado int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	Id_proveedor ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  UserDefinedFunction ObtenerInfoProveedor    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  View Vista_Prov    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW Vista_Prov AS
SELECT
    id_proveedor,
    Nombre,
  
    Razon AS Razon,
    
    
    telefono,
    Contacto AS Contacto,
    
    Fecha_Mod AS Fecha_Mod,
    estado
FROM
    Proveedor;
GO
/****** Object:  Table Cargo    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Cargo(
	id_Cargo int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	horario_inicio time(7) NULL,
	horario_fin time(7) NULL,
	Salario_base numeric(18, 0) NOT NULL,
	Descripcion_del_Cargo varchar(100) NULL,
	Estado int NOT NULL,
	Fecha_Mod datetime NULL,
	Fecha_Creac datetime NULL,
PRIMARY KEY CLUSTERED 
(
	id_Cargo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table Categoria    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Categoria(
	Id_Categoria int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	Id_Categoria ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table Cliente    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Cliente(
	id_cliente int IDENTITY(1,1) NOT NULL,
	Nit int NOT NULL,
	Razon_Social varchar(50) NOT NULL,
	id_person int NOT NULL,
	Estado int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_cliente ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table Compra    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Compra(
	Id_proveedor int NOT NULL,
	Id_Producto int NOT NULL,
	id_empleado int NOT NULL,
	Cantidad int NOT NULL,
	Precio numeric(18, 2) NOT NULL,
	Fecha datetime NOT NULL,
	Fecha_Mod datetime NULL,
	Fecha_Creac datetime NULL
) ON PRIMARY
GO
/****** Object:  Table Empleado    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Empleado(
	id_empleado int IDENTITY(1,1) NOT NULL,
	id_cargo int NOT NULL,
	id_person int NOT NULL,
	Foto text NOT NULL,
	Estado int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id_empleado ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY TEXTIMAGE_ON PRIMARY
GO
/****** Object:  Table Laboratorio    Script Date: 23/11/2023 17:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Laboratorio(
	Id_Laboratorio int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	Id_Laboratorio ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY
GO

CREATE TABLE Persona(
	id_person int IDENTITY(1,1) NOT NULL,
	Nombre varchar(30) NOT NULL,
	Ap_Paterno varchar(25) NULL,
	Ap_Materno varchar(25) NOT NULL,
	Fecha_nac date NULL,
	CI int NOT NULL,
	Correo varchar(30) NULL,
	Telefono int NOT NULL,
	Estado int NULL,
PRIMARY KEY CLUSTERED 
(
	id_person ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY
GO

CREATE TABLE Producto(
	Id_Producto int IDENTITY(1,1) NOT NULL,
	Id_Categoria int NOT NULL,
	Id_Laboratorio int NOT NULL,
	Nombre varchar(50) NOT NULL,
	Marca varchar(50) NOT NULL,
	Foto text NOT NULL,
	Precio_Venta numeric(18, 0) NOT NULL,
	Precio_Compra numeric(18, 0) NOT NULL,
	Limitestock int NOT NULL,
	Descripcion varchar(50) NOT NULL,
	Estado int NOT NULL,
	Fecha_Mod datetime NULL,
	Fecha_Creac datetime NULL,
PRIMARY KEY CLUSTERED 
(
	Id_Producto ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON PRIMARY
) ON PRIMARY TEXTIMAGE_ON PRIMARY
GO

CREATE TABLE Venta(
	id_cliente int NOT NULL,
	id_Producto int NOT NULL,
	id_empleado int NOT NULL,
	Cantidad int NOT NULL,
	Descuento_o_promocion varchar(250) NOT NULL,
	Metodo_de_pago varchar(25) NOT NULL,
	Precio_total numeric(18, 2) NOT NULL,
	Fecha datetime NOT NULL,
	Fecha_Mod datetime NULL,
	Fecha_Creac datetime NULL
) ON PRIMARY
GO
ALTER TABLE Cargo ADD  DEFAULT ((1)) FOR Estado
GO
ALTER TABLE Cliente ADD  DEFAULT ((1)) FOR Estado
GO
ALTER TABLE Empleado ADD  DEFAULT ((1)) FOR Estado
GO
ALTER TABLE Persona ADD  DEFAULT ((1)) FOR Estado
GO
ALTER TABLE Producto ADD  DEFAULT ((1)) FOR Estado
GO
ALTER TABLE Proveedor ADD  DEFAULT ((1)) FOR Estado
GO
ALTER TABLE Cliente  WITH CHECK ADD FOREIGN KEY(id_person)
REFERENCES Persona (id_person)
GO
ALTER TABLE Compra  WITH CHECK ADD FOREIGN KEY(id_empleado)
REFERENCES Empleado (id_empleado)
GO
ALTER TABLE Compra  WITH CHECK ADD FOREIGN KEY(Id_Producto)
REFERENCES Producto (Id_Producto)
GO
ALTER TABLE Compra  WITH CHECK ADD FOREIGN KEY(Id_proveedor)
REFERENCES Proveedor (Id_proveedor)
GO
ALTER TABLE Empleado  WITH CHECK ADD FOREIGN KEY(id_cargo)
REFERENCES Cargo (id_Cargo)
GO
ALTER TABLE Empleado  WITH CHECK ADD FOREIGN KEY(id_person)
REFERENCES Persona (id_person)
GO
ALTER TABLE Producto  WITH CHECK ADD FOREIGN KEY(Id_Categoria)
REFERENCES Categoria (Id_Categoria)
GO
ALTER TABLE Producto  WITH CHECK ADD FOREIGN KEY(Id_Laboratorio)
REFERENCES Laboratorio (Id_Laboratorio)
GO
ALTER TABLE Venta  WITH CHECK ADD FOREIGN KEY(id_cliente)
REFERENCES Cliente (id_cliente)
GO
ALTER TABLE Venta  WITH CHECK ADD FOREIGN KEY(id_empleado)
REFERENCES Empleado (id_empleado)
GO
ALTER TABLE Venta  WITH CHECK ADD FOREIGN KEY(id_Producto)
REFERENCES Producto (Id_Producto)

------PROCEDIMIENTOS---------------
GO
CREATE PROCEDURE Edit_Produc
@Nombre varchar(50),
@Marca varchar(50),
@Foto text, 
@Precio_Venta numeric(18,0),
@Precio_Compra numeric(18,0),
@Limitestock int,
@Descripcion varchar(50),
@Estado int,
@Id_Producto int,
@Id_Categoria int, 
@Id_Laboratorio int
AS
BEGIN
	UPDATE Producto 
	SET
	Nombre=@Nombre,
	Marca=@Marca,
	Foto=@Foto,
	Precio_Venta=@Precio_Venta,
	Precio_Compra=@Precio_Compra,
	Limitestock=@Limitestock,	
	Estado=@Estado,
	Fecha_Mod=GetDate()
	WHERE @Id_Producto=@Id_Producto
	RETURN 1
END	
GO

CREATE PROCEDURE Edit_Prov
@Nombre varchar(50),
@Nit int,
@Razon varchar(50), 
@Direccion varchar(50),
@Ciudad varchar(50),
@Telefono int,
@Contacto int,
@Email varchar(50),
@Id_proveedor int
AS
BEGIN
	UPDATE Proveedor 
	SET
	Nombre=@Nombre,
	Nit=@Nit,
	Razon=@Razon,
	Direccion=@Direccion,
	Ciudad=@Ciudad,
	Telefono=@Telefono,	
	Contacto=@Contacto,
	Email=@Email,
	Fecha_Mod=GetDate()
	WHERE Id_proveedor=@Id_proveedor
	RETURN 1
END
GO

CREATE PROCEDURE Elim_Prov
@Id_proveedor int
AS
BEGIN
	UPDATE Proveedor 
	SET
	Estado=0
	WHERE Id_proveedor=@Id_proveedor
	RETURN 1
END
GO

CREATE PROCEDURE Insert_Produc
@Nombre varchar(50),
@Marca varchar(50),
@Foto text, 
@Precio_Venta numeric(18,0),
@Precio_Compra numeric(18,0),
@Limitestock int,
@Descripcion varchar(50),
@Estado int,
@Id_Categoria int, 
@Id_Laboratorio int
AS
BEGIN
	INSERT INTO Producto(Nombre,Marca,Foto,Precio_Venta,Precio_Compra,Limitestock,Descripcion,
	Estado,Id_Categoria,Id_Laboratorio) 
	VALUES(@Nombre,@Marca,@Foto,@Precio_Venta,@Precio_Compra,@Limitestock,
	@Descripcion,@Estado,@Id_Categoria,@Id_Laboratorio)
	RETURN 1
END
GO

CREATE PROCEDURE Insert_Prov
@Nombre varchar(50),
@Nit int,
@Razon varchar(50), 
@Direccion varchar(50),
@Ciudad varchar(50),
@Telefono int,
@Contacto int,
@Email varchar(50)
AS
BEGIN
	INSERT INTO Proveedor(Nombre,Nit,Razon,
	Direccion,Ciudad,Telefono,Contacto,Email,Fecha_Mod) 
	VALUES(@Nombre,@Nit,@Razon,@Direccion,@Ciudad,@Telefono,
	@Contacto,@Email,GetDate())
	RETURN 1
END
GO

CREATE PROCEDURE Listado_Prov
AS
BEGIN
	SELECT * FROM Proveedor WHERE Estado = 1
	RETURN 1
END
GO

CREATE FUNCTION EncryptData(@data NVARCHAR(255))
RETURNS VARBINARY(MAX)
AS
BEGIN
    RETURN ENCRYPTBYPASSPHRASE('YourSecretPassphrase', @data);
END;
