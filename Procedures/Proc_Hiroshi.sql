USE EMPRESA_LIMPIEZA;
GO

DROP PROCEDURE IF EXISTS SP_MOVS_KARDEX_PAG
GO

CREATE PROCEDURE SP_MOVS_KARDEX_PAG
    @CodigoProducto int,
	@NumHoja int
AS
BEGIN
    BEGIN TRANSACTION
    DECLARE  @aux INT
    SELECT @aux = COUNT(*)
    from KARDEX
    where CodigoProducto = @CodigoProducto
    IF @aux = 0
    BEGIN
        PRINT 'No existe el kardex'
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
        RETURN
    END
    SELECT *
    FROM MOVIMIENTO
    WHERE
    CodigoProducto = @CodigoProducto
	and NumHoja = @NumHoja
    ORDER BY 
    NumItem
    COMMIT TRANSACTION
END
GO

DROP PROCEDURE IF EXISTS SP_ULTIMA_HOJA_KARDEX
GO

CREATE PROCEDURE SP_ULTIMA_HOJA_KARDEX
    @CodigoProducto int
AS
BEGIN
    BEGIN TRANSACTION
    DECLARE  @aux INT
    SELECT @aux = COUNT(*)
    from KARDEX
    where CodigoProducto = @CodigoProducto
    IF @aux = 0
    BEGIN
        PRINT 'No existe el kardex'
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
        RETURN
    END
    SELECT MAX(NumHoja) AS [Ultima Hoja]
    FROM MOVIMIENTO
    WHERE
    CodigoProducto = @CodigoProducto
    COMMIT TRANSACTION
END
GO

DROP PROCEDURE IF EXISTS SP_GET_KARDEX
GO

CREATE PROCEDURE SP_GET_KARDEX
    @CodigoProducto int
AS
BEGIN
    BEGIN TRANSACTION
    SELECT *
    FROM KARDEX
    WHERE
    CodigoProducto = @CodigoProducto
    COMMIT TRANSACTION
END
GO

drop procedure if exists SP_StockProducto
go
create procedure SP_StockProducto 
	@CodigoProducto int
AS
begin
	declare @maxItem int, @ultima_hoja int;
	select @ultima_hoja = max(NumHoja) from MOVIMIENTO where CodigoProducto = @CodigoProducto
	if @ultima_hoja is NULL
	begin
		print 'Producto inexistente o sin Kardex registrado'
		return;
	end
	select @maxItem = MAX(NumItem) from MOVIMIENTO WHERE CodigoProducto = @CodigoProducto and NumHoja = @ultima_hoja;

	select m.CodigoProducto, StockActual as 'Stock de Producto', p.DescripcionProducto as 'Descripcion Producto' 
	from MOVIMIENTO m
	inner join PRODUCTO P ON p.CodigoProducto = m.CodigoProducto
	where NumItem = @maxItem and p.CodigoProducto = @CodigoProducto and NumHoja = @ultima_hoja
end
GO