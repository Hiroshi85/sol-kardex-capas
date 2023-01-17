USE EMPRESA_LIMPIEZA
GO

--RESPONSABLES
DROP PROCEDURE IF EXISTS SP_INSERT_RESPONSABLE
GO
CREATE PROCEDURE SP_INSERT_RESPONSABLE
	@NumDNI					char(8),
	@FechaNacimiento		date,
	@Nombre					varchar(40)
as
	INSERT INTO RESPONSABLE (NumDNI, FechaNacimiento, Nombre) 
		VALUES	(@NumDNI, @FechaNacimiento, @Nombre)
go
DROP PROCEDURE IF EXISTS SP_UPDATE_RESPONSABLE
GO

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
DROP PROCEDURE IF EXISTS SP_DELETE_RESPONSABLE
GO

CREATE PROCEDURE SP_DELETE_RESPONSABLE
	@CodigoResponsable		varchar(36)
as
	UPDATE RESPONSABLE SET 
		Borrado = 1
		where CodigoResponsable = @CodigoResponsable
go
DROP PROCEDURE IF EXISTS SP_SEARCH_RESPONSABLExNOMBRE
GO

CREATE PROCEDURE SP_SEARCH_RESPONSABLExNOMBRE
	@Nombre			varchar(40)
as
	SELECT * FROM RESPONSABLE WHERE Borrado = 0 AND Nombre like '%'+@Nombre+'%'
go

DROP PROCEDURE IF EXISTS SP_SEARCH_RESPONSABLExCODIGO
GO
--- B�SQUEDA DE RESPONSABLE POR ID
CREATE PROCEDURE SP_SEARCH_RESPONSABLExCODIGO
	@CodigoResponsable			varchar(36)
as
	SELECT * FROM RESPONSABLE WHERE CodigoResponsable = @CodigoResponsable
go

DROP PROCEDURE IF EXISTS SP_INSERT_PROVEEDOR
GO
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

DROP PROCEDURE IF EXISTS SP_UPDATE_PROVEEDOR
GO
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
DROP PROCEDURE IF EXISTS SP_DELETE_PROVEEDOR
GO
CREATE PROCEDURE SP_DELETE_PROVEEDOR
	@IdProveedor	        int
as
	UPDATE PROVEEDOR SET 
		Borrado = 1
		where IdProveedor = @IdProveedor
go
DROP PROCEDURE IF EXISTS SP_SEARCH_PROVEEDOR
GO
CREATE PROCEDURE SP_SEARCH_PROVEEDOR
	@Proveedor varchar(30)
as
	SELECT * FROM PROVEEDOR WHERE Borrado = 0 AND Proveedor like '%'+@Proveedor+'%'
go
DROP PROCEDURE IF EXISTS SP_SEARCH_PROVEEDORxID
GO
--- B�SQUEDA DE PROVEEDOR POR ID
CREATE PROCEDURE SP_SEARCH_PROVEEDORxID
	@IdProveedor		int
as
	SELECT * FROM PROVEEDOR WHERE Borrado = 0 AND IdProveedor = @IdProveedor
go