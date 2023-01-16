USE EMPRESA_LIMPIEZA;
go
DROP procedure if exists SP_INSERTAR_DOCUMENTO;
GO
CREATE PROCEDURE SP_INSERTAR_DOCUMENTO
    @Fecha DATE,
	@IdTipoDoc INT,
	@IdProveedor INT,
	@CodigoResponsable VARCHAR(36)
AS
BEGIN
    BEGIN TRANSACTION
    IF @IdTipoDoc=3
		INSERT INTO documento (Fecha,IdTipoDoc,IdProveedor,CodigoResponsable) VALUES (@Fecha,@IdTipoDoc,@IdProveedor,null) 
	ELSE
		INSERT INTO documento (Fecha,IdTipoDoc,IdProveedor,CodigoResponsable) VALUES (@Fecha,@IdTipoDoc,null,@CodigoResponsable) 
    COMMIT TRANSACTION
END 
GO
