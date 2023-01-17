use master
go
DROP DATABASE IF EXISTS EMPRESA_LIMPIEZA 
GO
create database EMPRESA_LIMPIEZA
go
USE EMPRESA_LIMPIEZA
GO

CREATE TABLE CATEGORIA
(
	IdCategoria int identity primary key NOT NULL ,
	Descripcion nvarchar(30) NOT NULL
)
go

CREATE TABLE MEDIDA
(
	IdMedida int identity primary key NOT NULL ,
	Unidad nvarchar(20) not NULL
)
go

CREATE TABLE PRODUCTO
(
	CodigoProducto int identity primary key NOT NULL ,
	NombreProducto varchar(255) NOT NULL ,
	DescripcionProducto varchar(255) NOT NULL ,
	PrecioBase money not null,
	IdCategoria int not NULL
		foreign key references CATEGORIA(IdCategoria),
	IdMedida int not NULL
		foreign key references MEDIDA(IdMedida),
	Borrado smallint default 0
)
go


CREATE TABLE KARDEX
(
	CodigoProducto int not NULL primary key,
	foreign key(CodigoProducto) references PRODUCTO(CodigoProducto),
	StockMinRepo float not NULL DEFAULT 0,
	FechaApertura date not NULL DEFAULT GetDate(),
	CantidadReposicion float not null DEFAULT 0,
)
go

CREATE TABLE PROVEEDOR
(
	IdProveedor int identity primary key ,
	RUC				char(11) not null unique,
	Proveedor		nvarchar(30) not null,
	Descripcion		nvarchar(30) not NULL,
	Direccion		nvarchar(30) not null,
	Telefono		nvarchar(13) not null,
	Correo			nvarchar(30) not null,
	Borrado smallint default 0
)
go

CREATE TABLE RESPONSABLE
(
	CodigoResponsable varchar(36) primary key default CONVERT(VARCHAR(36), NEWID()),
	NumDNI nchar(8) not null unique,
	FechaNacimiento date not NULL ,
	Nombre nvarchar(40) not NULL,
	Borrado smallint default 0
)
go

CREATE TABLE TIPO_DOCUMENTO
(
	IdTipoDoc int identity primary key,
	Descripcion nvarchar(18) not NULL
)
go


CREATE TABLE DOCUMENTO
(
	NumDocumento int identity primary key ,
	Fecha date not NULL default GetDate(),
	IdTipoDoc int not  NULL foreign key REFERENCES TIPO_DOCUMENTO(IdTipoDoc),
	IdProveedor int NULL foreign key REFERENCES PROVEEDOR(IdProveedor),
	CodigoResponsable varchar(36) NULL foreign key REFERENCES RESPONSABLE(CodigoResponsable),
	Cerrado	smallint default 0
)
go

CREATE TABLE TIPO_MOVIMIENTO
(
	IdTipoMov int identity primary key ,
	Descripcion nchar(1) not NULL
)
go

CREATE TABLE MOVIMIENTO
(
	NumItem int NOT NULL default 0,
	CodigoProducto int not null,
	NumDocumento int NOT NULL,
	NumHoja int NOT NULL default 0,
	primary key(CodigoProducto, NumDocumento, NumItem),
	foreign key (NumDocumento) references DOCUMENTO(NumDocumento),
	foreign key (CodigoProducto) references KARDEX(CodigoProducto),
	PrecioDocumento money NULL,
	StockAnterior float NULL,
	CantidadEntrada float NULL ,
	CantidadSalida float NULL ,
	StockActual float NULL ,
	IdTipoMov int not NULL foreign key REFERENCES TIPO_MOVIMIENTO(IdTipoMov) default 1
)
go



INSERT INTO CATEGORIA (Descripcion) VALUES ('BAÑO'),('COCINA'),('LIMPIEZA') 
GO
INSERT INTO MEDIDA (Unidad) VALUES ('UNIDAD'),('CAJA'),('PAQUETE'),('BOLSA'),('GALON'),('LITRO'),('KILO'),('GRAMO'),('METRO'),('CENTIMETRO'),('MILIMETRO') 
GO
INSERT INTO TIPO_DOCUMENTO (Descripcion) VALUES ('F'),('B'),('Guia') 
GO
INSERT INTO TIPO_MOVIMIENTO (Descripcion) VALUES ('I'),('S') 
GO
INSERT INTO PROVEEDOR (RUC,Proveedor,Descripcion,Direccion,Telefono,Correo) VALUES ('94990879972','Medhurst - Gleason LLC','open-source embrace','216 Senger Shoal','680145801','Marina_Bogisich10@yahoo.com'),('68101738393','Fritsch LLC Group','granular brand','92517 Elisha Pass','600442541','Cora71@hotmail.com'),('52230803179','Abernathy - Wolff Group','distributed orchestrate','82296 Brycen Pine','666668518','Laura97@hotmail.com'),('57569840596','Berge, Jenkins and OConnell Gr','out-of-the-box scale','6161 Carolyn Extensions','546228684','Missouri_Lowe@yahoo.com'),('70919026201','Weissnat, Metz and Goodwin Gro','vertical orchestrate','9187 Oleta Course','795250454','Clark29@yahoo.com'),('66956437961','Wolf, Rohan and Wisozk LLC','open-source strategize','168 Dena Ways','632949718','Oral70@gmail.com'),('27339353994','Maggio - Cronin Inc','intuitive benchmark','94820 Vandervort Vista','598606932','Aleen_Dibbert@yahoo.com'),('7185709825','Fisher, Yundt and Blick LLC','frictionless integrate','82907 Regan Trace','453200365','Gianni_Klein@hotmail.com'),('75946904299','Koss Group Inc','global transform','6741 Destin Extensions','864699374','Rosendo.Kilback79@yahoo.com'),('84286990622','Erdman Inc Group','innovative strategize','251 Ledner Ville','132769855','Liliane58@yahoo.com')
GO


-- Funci�n para obtener la cantidad d�gitos repetidos en el DNI
if OBJECT_ID('dbo.fnNumDigitosRepetidos','fn') is not null
	drop function dbo.fnNumDigitosRepetidos
go
create function dbo.fnNumDigitosRepetidos(
	@dni				varchar(8),
	@cadAuxiliar		varchar(8), 
	@contador			int, 
	@repetidos			int, 
	@numRepeticiones	int
)
	returns int
as
begin
	if LEN(@dni) > 0
	begin
		while @contador <= LEN(@dni)
		begin 
			if SUBSTRING(@dni, 1, 1) <> SUBSTRING(@dni, @contador, 1)
				set @cadAuxiliar += SUBSTRING (@dni, @contador, 1)
			else
				set @numRepeticiones += 1
			set @contador += 1
		end
		if @numRepeticiones > 0
			set @repetidos += 1
		set @repetidos = dbo.fnNumDigitosRepetidos(@cadAuxiliar, '', 2, @repetidos, 0)
		
	end
	return @repetidos
end
go

CREATE TRIGGER AutogenerarCodigo
ON RESPONSABLE
FOR INSERT, UPDATE
AS 
BEGIN
	DECLARE
	@CodigoResponsable varchar(36),
	@NumDNI nchar(8),
	@FechaNacimiento date,

	@correlativo int,
	@autogenerado char(3),
	-- �ltimo c�digo con autogenerado repetido
	@auxiliar varchar(36)
	
	select 
		@NumDNI = NumDNI,
		@FechaNacimiento = FechaNacimiento
		from inserted
	--Autogenerar c�digos (tres primeros d�gitos)
	set @autogenerado = CONCAT (dbo.fnNumDigitosRepetidos(@NumDNI, '', 2, 0, 0), SUBSTRING(CAST(YEAR(@FechaNacimiento) as CHAR(4)), 3, 2)) 
	--Asignar correlativo a c�digo autogenerado
	if exists (SELECT CodigoResponsable 
				FROM RESPONSABLE 
				WHERE Substring(CodigoResponsable,1,3) = @autogenerado)
	begin
		-- Obtenemos el c�digo con el mayor valor registrado (�ltimo correlativo)
		set @auxiliar = (SELECT MAX(CAST(CodigoResponsable AS INT)) 
						FROM RESPONSABLE WHERE Substring(CodigoResponsable,1,3) = @autogenerado)
		-- El �ltimo correlativo se incrementa en 1
		set @correlativo = CAST(SUBSTRING(@auxiliar, 4, LEN(@auxiliar)-3) AS INT) + 1 
	end
	else 
		set @correlativo = 0

	set @CodigoResponsable = CONCAT (@autogenerado, @correlativo) 
	update RESPONSABLE set CodigoResponsable = @CodigoResponsable where NumDNI = @NumDNI
END
go



DROP TRIGGER IF EXISTS TRG_VERIF_FKEY_DOCUMENTO
GO

CREATE TRIGGER TRG_VERIF_FKEY_DOCUMENTO
ON DOCUMENTO
INSTEAD OF INSERT,UPDATE
AS
	DECLARE
	@tam					int,
	@NumDocumento			int,
	@Fecha					date,
	@IdTipoDoc				int,
	@IdProveedor			int,
	@CodigoResponsable		varchar(36),

	@aux_IdTipoDoc			int,
	@aux_IdProveedor		int,
	@aux_CodigoResponsable	varchar(36)
	select @tam = count(*) from inserted;
	IF @tam <> 1
	BEGIN
		PRINT 'Se deben insertar solo 1 dato a la vez'
		RETURN
	END
	--DATOS DE LA TABLA INSERTED
	SELECT @Fecha = Fecha,
	@NumDocumento=NumDocumento,
	@IdTipoDoc=IdTipoDoc,
	@IdProveedor=IdProveedor,
	@CodigoResponsable=CodigoResponsable 
	FROM INSERTED
	SELECT @aux_IdTipoDoc=IdTipoDoc FROM TIPO_DOCUMENTO WHERE IdTipoDoc=@IdTipoDoc
	SELECT @aux_IdProveedor=IdProveedor FROM PROVEEDOR WHERE IdProveedor=@IdProveedor 
	SELECT @aux_CodigoResponsable=CodigoResponsable 
	FROM RESPONSABLE WHERE CodigoResponsable=@CodigoResponsable
	--INSERTAR
	IF (SELECT NumDocumento FROM INSERTED) IS NOT NULL AND (SELECT NumDocumento FROM DELETED) IS NULL
	BEGIN
		print 'HELLO'  
		IF 
		@IdTipoDoc IS NOT NULL AND @aux_IdTipoDoc IS NOT NULL
		BEGIN
			if @IdTipoDoc in (1, 2) and (@CodigoResponsable is null or @aux_CodigoResponsable is null or @IdProveedor is not null)
				begin
				print 'Verifique datos. Si es boleta o factura, ingrese datos del Responsable de Empresa.'
				return;
			end

			if @IdTipoDoc = 3 and (@IdProveedor is null or @aux_IdProveedor is null or @CodigoResponsable is not null)
				begin
				print 'Verifique datos. Si es Guia de Remision, ingrese datos de proveedor y deje en blanco el responsable'
				return;
			end

			INSERT INTO DOCUMENTO (Fecha,IdTipoDoc,IdProveedor,CodigoResponsable) 
			VALUES (@Fecha, @IdTipoDoc,@IdProveedor,@CodigoResponsable)
			PRINT 'Datos válidos registrados en el DOCUMENTO.'
		END
		ELSE
		BEGIN
			PRINT 'Datos no válidos.'
			RETURN
		END
	END
	--ACTUALIZAR
	IF (SELECT NumDocumento FROM INSERTED) IS NOT NULL AND (SELECT NumDocumento FROM DELETED) IS NOT NULL
	BEGIN
		IF  @IdProveedor IS NOT NULL AND @aux_IdProveedor IS NOT NULL
		BEGIN
			UPDATE DOCUMENTO SET IdProveedor=@IdProveedor WHERE NumDocumento=@NumDocumento
		END
		IF @IdTipoDoc IS NOT NULL AND @aux_IdTipoDoc IS NOT NULL
		BEGIN
			UPDATE DOCUMENTO SET IdTipoDoc=@IdTipoDoc WHERE NumDocumento=@NumDocumento
		END
		IF @CodigoResponsable IS NOT NULL AND @aux_CodigoResponsable IS NOT NULL
		BEGIN
			UPDATE DOCUMENTO SET CodigoResponsable=@CodigoResponsable WHERE NumDocumento=@NumDocumento
		END
		PRINT 'Datos válidos registrados en el Producto.'
	END
GO


DROP TRIGGER IF EXISTS TRG_VERIF_FKEY_KARDEX
GO

-- Verificar Foreign Keys en TABLA KARDEX
CREATE TRIGGER TRG_VERIF_FKEY_KARDEX
ON KARDEX
INSTEAD OF INSERT,UPDATE
AS
BEGIN TRANSACTION T_VERIF_FKEY_KARDEX
	DECLARE
	@tam					int,
	@tam_aux				int,
	@StockMinRepo			float,
	@CantidadReposicion		float,
	@CodigoProducto			int,
	@aux_CodigoProducto		int
	save transaction T_VERIF_FKEY_KARDEX;
	select @tam = count(*) from inserted;
	IF @tam <> 1
	BEGIN
		PRINT 'Se deben insertar solo 1 dato a la vez'
		ROLLBACK TRANSACTION T_VERIF_FKEY_KARDEX
		RETURN
	END
	--DATOS DE LA TABLA INSERTED
	SELECT @StockMinRepo=StockMinRepo,
	@CodigoProducto=CodigoProducto, @CantidadReposicion = CantidadReposicion FROM INSERTED
	SELECT @aux_CodigoProducto=CodigoProducto 
	FROM PRODUCTO WHERE CodigoProducto=@CodigoProducto
	--INSERTAR
	IF (SELECT CodigoProducto FROM INSERTED) IS NOT NULL AND (SELECT CodigoProducto FROM DELETED) IS NULL
	BEGIN
		IF  @CodigoProducto IS NOT NULL AND @aux_CodigoProducto IS NOT NULL AND
		@StockMinRepo IS NOT NULL
		BEGIN
			select @tam_aux = count(CodigoProducto) from KARDEX where CodigoProducto = @CodigoProducto;
			if @tam_aux <> 0
			begin
				PRINT 'Solo puede haber un kardex por producto. Las hojas se crean automaticamente'
				ROLLBACK TRAN
				RETURN
			end
			IF @StockMinRepo<=0
			BEGIN
				print 'Stock mínimo debe ser mayor a 0'
				rollback tran
				return;
			END
			IF @CantidadReposicion<=0 or @CantidadReposicion IS NULL
				SET @CantidadReposicion=2*@StockMinRepo
			INSERT INTO KARDEX (StockMinRepo,CantidadReposicion,CodigoProducto) 
			VALUES (@StockMinRepo,@CantidadReposicion,@CodigoProducto)

			PRINT 'Datos válidos registrados en el KARDEX.'
			COMMIT TRANSACTION T_VERIF_FKEY_KARDEX
		END
		ELSE
		BEGIN
			PRINT 'Datos no válidos.'
			ROLLBACK TRANSACTION T_VERIF_FKEY_KARDEX
			RETURN
		END
	END
	--ACTUALIZAR
	IF (SELECT CodigoProducto FROM INSERTED) IS NOT NULL AND (SELECT CodigoProducto FROM DELETED) IS NOT NULL
	BEGIN

		IF @StockMinRepo > 0 
		BEGIN
			UPDATE KARDEX SET StockMinRepo=@StockMinRepo WHERE CodigoProducto=@CodigoProducto
		END

		IF @CantidadReposicion > 0 
		BEGIN
			UPDATE KARDEX SET CantidadReposicion=@CantidadReposicion WHERE CodigoProducto=@CodigoProducto
		END
		
		PRINT 'Datos válidos registrados en el KARDEX.'
		COMMIT TRANSACTION T_VERIF_FKEY_KARDEX
	END
GO



DROP TRIGGER IF EXISTS TRG_VERIF_FKEY_PRODUCTO
GO

-- Verificar Foreign Keys en TABLA PRODUCTO
CREATE TRIGGER TRG_VERIF_FKEY_PRODUCTO
ON PRODUCTO
INSTEAD OF INSERT,UPDATE
AS
BEGIN TRANSACTION T_VERIF_FKEY_PRODUCTO
	DECLARE
	@tam					int,
	@CodigoProducto			int,
	@NombreProducto	        varchar(255),
	@DescripcionProducto	varchar(255),
	@PrecioBase				money,
	@IdCategoria			int,
	@IdMedida				int,
	@borrado				int,
	@aux_CodigoProducto		int,
	@aux_IdCategoria		int,
	@aux_IdMedida			int
	save transaction T_VERIF_FKEY_PRODUCTO;
	select @tam = count(*) from inserted;
	IF @tam <> 1
	BEGIN
		PRINT 'Se deben insertar solo 1 dato a la vez'
		ROLLBACK TRANSACTION T_VERIF_FKEY_PRODUCTO
		RETURN
	END
	--DATOS DE LA TABLA INSERTED
	SELECT @CodigoProducto=CodigoProducto, @NombreProducto=NombreProducto,@DescripcionProducto=DescripcionProducto,@PrecioBase=PrecioBase,@IdCategoria=Idcategoria,@IdMedida=IdMedida, @borrado = Borrado FROM INSERTED
	-- @aux_... 
	SELECT @aux_IdCategoria=IdCategoria FROM CATEGORIA WHERE IdCategoria=@IdCategoria
	SELECT @aux_IdMedida=IdMedida FROM MEDIDA WHERE IdMedida=@IdMedida 
	--INSERTAR
	IF (SELECT CodigoProducto FROM INSERTED) IS NOT NULL AND (SELECT CodigoProducto FROM DELETED) IS NULL
	BEGIN
		IF  @IdCategoria IS NOT NULL AND @aux_IdCategoria IS NOT NULL AND
		@IdMedida IS NOT NULL AND @aux_IdMedida IS NOT NULL AND 
		@NombreProducto IS NOT NULL AND @DescripcionProducto IS NOT NULL AND @PrecioBase IS NOT NULL
		BEGIN
			INSERT INTO PRODUCTO (NombreProducto,DescripcionProducto,PrecioBase,IdCategoria,IdMedida) 
			VALUES (@NombreProducto,@DescripcionProducto,@PrecioBase,@IdCategoria,@IdMedida)
			PRINT 'Datos válidos registrados en el Producto.'
			COMMIT TRANSACTION T_VERIF_FKEY_PRODUCTO
		END
		ELSE
		BEGIN
			PRINT 'Datos no válidos.'
			ROLLBACK TRANSACTION T_VERIF_FKEY_PRODUCTO
			RETURN
		END
	END
	--ACTUALIZAR
	IF (SELECT CodigoProducto FROM INSERTED) IS NOT NULL AND (SELECT CodigoProducto FROM DELETED) IS NOT NULL
	BEGIN
		IF  @IdCategoria IS NOT NULL AND @aux_IdCategoria IS NOT NULL
		BEGIN
			UPDATE PRODUCTO SET IdCategoria=@IdCategoria WHERE CodigoProducto=@CodigoProducto
		END
		IF @IdMedida IS NOT NULL AND @aux_IdMedida IS NOT NULL
		BEGIN
			UPDATE PRODUCTO SET IdMedida=@IdMedida WHERE CodigoProducto=@CodigoProducto
		END
		IF @NombreProducto IS NOT NULL
		BEGIN
			UPDATE PRODUCTO SET NombreProducto=@NombreProducto WHERE CodigoProducto=@CodigoProducto
		END
		IF @DescripcionProducto IS NOT NULL
		BEGIN
			UPDATE PRODUCTO SET DescripcionProducto=@DescripcionProducto WHERE CodigoProducto=@CodigoProducto
		END
		IF @PrecioBase IS NOT NULL
		BEGIN
			UPDATE PRODUCTO SET PrecioBase=@PrecioBase WHERE CodigoProducto=@CodigoProducto
		END
		IF @Borrado IS NOT NULL
		BEGIN
			UPDATE PRODUCTO SET Borrado=@Borrado WHERE CodigoProducto=@CodigoProducto
			PRINT 'Borrado Lógico.'
		END
		PRINT 'Datos válidos registrados en el Producto'
		COMMIT TRANSACTION T_VERIF_FKEY_PRODUCTO
	END
GO



drop trigger if exists TRG_VERIF_MOVIMIENTO
go

CREATE TRIGGER TRG_VERIF_MOVIMIENTO
ON MOVIMIENTO
INSTEAD OF INSERT
AS
	DECLARE
	@tam					int,
	@NumItem				int,
	@NumDocumento			int,
	@IdTipoMov				int,
	@PrecioDocumento		money,
	@CodigoProducto			int,
	@StockAnterior			float,
	@CantidadEntrada		float,
	@CantidadSalida			float,
	@StockActual			float,
	@StockMinRepo			float,
	@CantidadReposicion		float,
	@aux_CodigoProducto		int,
	@aux_NumDocumento		int,
	@IdTipoDoc				int
	select @tam = count(*) from inserted;
	IF @tam <> 1
	BEGIN
		PRINT 'Se deben insertar solo 1 dato a la vez'
		RETURN
	END
	--DATOS DE LA TABLA INSERTED
	SELECT @NumItem=NumItem,
	@CodigoProducto=i.CodigoProducto,
	@NumDocumento=D.NumDocumento,
	@PrecioDocumento=PrecioDocumento,
	@StockAnterior=StockAnterior,
	@CantidadEntrada=CantidadEntrada,
	@CantidadSalida=CantidadSalida,
	@StockActual=StockActual,
	@IdTipoMov=IdTipoMov,
	@StockMinRepo = K.StockMinRepo,
	@CantidadReposicion = K.CantidadReposicion,
	@IdTipoDoc = D.IdTipoDoc
	FROM INSERTED i
	inner join DOCUMENTO D on D.NumDocumento = i.NumDocumento
	inner join KARDEX K on K.CodigoProducto = i.CodigoProducto
	
	
	SELECT @aux_CodigoProducto=CodigoProducto FROM KARDEX WHERE CodigoProducto = @CodigoProducto
	SELECT @aux_NumDocumento=NumDocumento FROM DOCUMENTO WHERE NumDocumento=@NumDocumento
	--INSERTAR
	IF @NumItem is not null and @CodigoProducto is not null and @NumDocumento is not null
	BEGIN
		IF  @aux_CodigoProducto IS NOT NULL AND 
			@aux_NumDocumento IS NOT NULL
		BEGIN
			declare @anterior_item int, @nuevo_item int, @nueva_Hoja int, @ultima_Hoja int;
			select @ultima_Hoja = max(NumHoja) from MOVIMIENTO where CodigoProducto = @CodigoProducto;
			select @anterior_item = max(NumItem) from MOVIMIENTO where CodigoProducto = @CodigoProducto and NumHoja = @ultima_Hoja;

			if @anterior_item is NULL
				set @anterior_item=0

			if @ultima_Hoja is NULL
				set @ultima_Hoja=1

			set @nuevo_item = @anterior_item + 1
			set @nueva_Hoja = @ultima_Hoja

			if @nuevo_item >10
			begin	
				set @nueva_Hoja+=1
				set @nuevo_item=1
			end
			
			select @StockAnterior = StockActual from MOVIMIENTO where NumItem = @anterior_item and NumHoja = @ultima_Hoja and CodigoProducto = @CodigoProducto;
			if(@StockAnterior is NULL)
				set @StockAnterior = 0;

			if @IdTipoDoc in (1, 2)
			begin
				if @CantidadSalida is null
				begin
					print 'No se ha ingresado Cantidad Salida. Verifique tipo de documento'
					return;
				end
				set @StockActual = @StockAnterior - @CantidadSalida;
				if @StockActual < 0 
				begin
					print 'Stock actual debe ser siempre mayor o igual a 0.'
					return;
				end
				
				INSERT INTO MOVIMIENTO(CodigoProducto,NumHoja, NumItem,NumDocumento,PrecioDocumento,StockAnterior,
				CantidadEntrada,CantidadSalida,StockActual,IdTipoMov) 
				VALUES (@CodigoProducto,@nueva_Hoja, @nuevo_item,@NumDocumento,@PrecioDocumento,@StockAnterior,
				NULL,@CantidadSalida,@StockActual,2)
			end
			
			if @IdTipoDoc = 3 --ingresa
			begin
				if @CantidadEntrada is null
				begin
					print 'No se ha ingresado Cantidad Entrada. Verifique tipo de documento'
					return;
				end
				set @StockActual = @StockAnterior + @CantidadEntrada;
				INSERT INTO MOVIMIENTO(CodigoProducto,NumHoja, NumItem,NumDocumento,PrecioDocumento,StockAnterior,
				CantidadEntrada,CantidadSalida,StockActual,IdTipoMov) 
				VALUES (@CodigoProducto,@nueva_Hoja, @nuevo_item,@NumDocumento,@PrecioDocumento,@StockAnterior,
				@CantidadEntrada,NULL,@StockActual,1)
			end
			
			PRINT 'Datos válidos registrados en el Movimiento.'
			RETURN;
		END
		ELSE
		BEGIN
			PRINT 'Datos no válidos'
			RETURN
		END
	END
GO

use EMPRESA_LIMPIEZA;
GO

DROP PROCEDURE IF EXISTS SP_INSERT_MOV_ENTRADA
GO 
CREATE PROCEDURE SP_INSERT_MOV_ENTRADA
    @CodigoProducto INT,
    @NumDocumento INT,
    @PrecioDocumento MONEY,
    @CantidadEntrada FLOAT
AS
BEGIN
	declare @aux_kardex int;
	select @aux_kardex = CodigoProducto from Kardex WHERE CodigoProducto = @CodigoProducto;
	if @aux_kardex is NULL
	begin
		print CONCAT('El producto ', STR(@CodigoProducto) ,' no tiene aun un kardex asociado o creado aun.')
		return;
	end
    INSERT INTO
	    MOVIMIENTO
        (
        CodigoProducto,
        NumDocumento,
        PrecioDocumento,
        CantidadEntrada
        )
    VALUES
        (
            @CodigoProducto,
            @NumDocumento,
            @PrecioDocumento,
            @CantidadEntrada
	    )
END 
GO

DROP PROCEDURE IF EXISTS SP_INSERT_MOV_SALIDA;
GO
CREATE PROCEDURE SP_INSERT_MOV_SALIDA
	@CodigoProducto INT,
	@NumDocumento INT,
	@PrecioDocumento MONEY,
	@CantidadSalida FLOAT
AS
BEGIN
	declare @aux_kardex int;
	select @aux_kardex = CodigoProducto
	from Kardex
	WHERE CodigoProducto = @CodigoProducto;
	if @aux_kardex is NULL
	begin
		print CONCAT('El producto ', STR(@CodigoProducto) ,' no tiene aun un kardex asociado o creado aun.')
		return;
	end
	INSERT INTO
		MOVIMIENTO
		(
		CodigoProducto,
		NumDocumento,
		PrecioDocumento,
		CantidadSalida
		)
	VALUES
		(
			@CodigoProducto,
			@NumDocumento,
			@PrecioDocumento,
			@CantidadSalida
		)
END
GO

USE EMPRESA_LIMPIEZA;
go
DROP procedure if exists SP_INSERT_NEW_PRODUCTO;
GO
CREATE PROCEDURE SP_INSERT_NEW_PRODUCTO
    @NombreProd VARCHAR(255),
    @DescProd VARCHAR(255),
    @PrecioB MONEY,
    @IdCategoria INT,
    @IdMedida INT,
    @StockMin FLOAT,
    @CantRepo FLOAT
AS
BEGIN
    BEGIN TRANSACTION
    declare @LastId INT;
    IF @StockMin <= 0 
		begin
        print 'Cantidad reposicion debe ser mayor a 0';
        rollback tran;
        return;
    end
    INSERT INTO
		PRODUCTO
        (
        NombreProducto,
        DescripcionProducto,
        PrecioBase,
        IdCategoria,
        IdMedida
        )
    VALUES
        (
            @NombreProd,
            @DescProd,
            @PrecioB,
            @IdCategoria,
            @IdMedida
	    )
    SELECT @LastId=MAX(CodigoProducto)
    from PRODUCTO;
    INSERT INTO KARDEX
        (StockMinRepo, CantidadReposicion, CodigoProducto)
    VALUES
        (@StockMin, @CantRepo, @LastId)
    COMMIT TRANSACTION
END 
GO

USE EMPRESA_LIMPIEZA;
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
	where NumItem = @maxItem
end
GO


DROP PROCEDURE IF EXISTS SP_MOVS_KARDEX
GO

CREATE PROCEDURE SP_MOVS_KARDEX
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
    SELECT *
    FROM MOVIMIENTO
    WHERE
    CodigoProducto = @CodigoProducto
    ORDER BY 
    NumItem
    COMMIT TRANSACTION
END
GO
