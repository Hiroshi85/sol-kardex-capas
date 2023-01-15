USE EMPRESA_LIMPIEZA
GO
select * from RESPONSABLE
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