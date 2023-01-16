USE EMPRESA_LIMPIEZA
GO

--RESPONSABLES

CREATE PROCEDURE SP_INSERT_RESPONSABLE
	@NumDNI					char(8),
	@FechaNacimiento		date,
	@Nombre					varchar(40)
as
	INSERT INTO RESPONSABLE (NumDNI, FechaNacimiento, Nombre) 
		VALUES	(@NumDNI, @FechaNacimiento, @Nombre)
go

CREATE PROCEDURE SP_UPDATE_RESPONSABLE
	@CodigoResponsable		varchar(36),
	@NumDNI					char(8),
	@FechaNacimiento		date,
	@Nombre					varchar(40)
as
	UPDATE RESPONSABLE SET 
		NumDNI = @NumDNI,
		FechaNacimiento = @FechaNacimiento,
		Nombre = @Nombre
		where CodigoResponsable = @CodigoResponsable
go

CREATE PROCEDURE SP_DELETE_RESPONSABLE
	@CodigoResponsable		varchar(36)
as
	UPDATE RESPONSABLE SET 
		Borrado = 1
		where CodigoResponsable = @CodigoResponsable
go

CREATE PROCEDURE SP_SEARCH_RESPONSABLExNOMBRE
	@Nombre			varchar(40)
as
	SELECT * FROM RESPONSABLE WHERE Borrado = 0 AND Nombre like '%'+@Nombre+'%'
go


-- PROVEEDORES

CREATE PROCEDURE SP_INSERT_PROVEEDOR
	@RUC			  char(11),
	@Proveedor		  varchar(30),
	@Descripcion      varchar(30),
	@Direccion		  varchar(30),
	@Telefono		  varchar(13),
	@Correo			  varchar(30)
as
	INSERT INTO PROVEEDOR(RUC,Proveedor, Descripcion, Direccion, Telefono, Correo) 
		VALUES	(@RUC,@Proveedor, @Descripcion, @Direccion, @Telefono, @Correo)
go

CREATE PROCEDURE SP_UPDATE_PROVEEDOR
	@IdProveedor	        int,
	@RUC				char(11),
	@Proveedor		  varchar(30),
	@Descripcion      varchar(30),
	@Direccion		  varchar(30),
	@Telefono		  varchar(13),
	@Correo			  varchar(30)
as
	UPDATE PROVEEDOR SET 
		RUC = @RUC,
		Proveedor = @Proveedor,
		Descripcion = @Descripcion,
		Direccion = @Direccion,
		Telefono = @Telefono,
		Correo = @Correo
		where IdProveedor = @IdProveedor
go

CREATE PROCEDURE SP_DELETE_PROVEEDOR
	@IdProveedor	        int
as
	UPDATE PROVEEDOR SET 
		Borrado = 1
		where IdProveedor = @IdProveedor
go

CREATE PROCEDURE SP_SEARCH_PROVEEDOR
	@Proveedor varchar(30)
as
	SELECT * FROM PROVEEDOR WHERE Borrado = 0 AND Proveedor like '%'+@Proveedor+'%'
go