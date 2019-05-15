-- Generado por Oracle SQL Developer Data Modeler 18.4.0.339.1532
--   en:        2019-05-11 21:55:44 CDT
--   sitio:      SQL Server 2012
--   tipo:      SQL Server 2012
CREATE DATABASE ADINHE2

USE ADINHE2

CREATE SCHEMA inventario

CREATE TABLE inventario.bodega (
    bodegaid            INTEGER NOT NULL,
    nombre              VARCHAR(100) NOT NULL,
    descripcion         VARCHAR(200) NOT NULL,
    tipo                VARCHAR(20) NOT NULL,
    cantidad            INTEGER NOT NULL,
    precio              money NOT NULL,
    usuario_usuarioid   INTEGER NOT NULL
)

go

ALTER TABLE inventario.bodega ADD constraint bodega_pk PRIMARY KEY CLUSTERED (BodegaId)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE inventario.detalle_proyecto (
    detalle_proectoid     INTEGER NOT NULL,
    proyecto_proyectoid   INTEGER NOT NULL,
    preparar_prepararid   INTEGER NOT NULL
)

go

ALTER TABLE inventario.detalle_proyecto ADD constraint detalle_proyecto_pk PRIMARY KEY CLUSTERED (Detalle_ProectoId)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE inventario.preparar (
    prepararid        INTEGER NOT NULL,
    fechasalida       DATE,
    fechaentrega      datetime,
    cantsolicitada    INTEGER NOT NULL,
    bodega_bodegaid   INTEGER NOT NULL
)

go

ALTER TABLE inventario.preparar ADD constraint preparar_pk PRIMARY KEY CLUSTERED (PrepararId)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE inventario.proyecto (
    proyectoid          INTEGER NOT NULL,
    descripcion         VARCHAR(150) NOT NULL,
    usuario_usuarioid   INTEGER NOT NULL
)

go

ALTER TABLE inventario.proyecto ADD constraint proyecto_pk PRIMARY KEY CLUSTERED (ProyectoId)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE inventario.usuario (
    usuarioid     INTEGER NOT NULL,
    descripcion   VARCHAR(100),
    contraseña    VARCHAR(50) NOT NULL,
    rol           INTEGER NOT NULL
)

go

ALTER TABLE inventario.usuario ADD constraint usuario_pk PRIMARY KEY CLUSTERED (UsuarioId)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

ALTER TABLE inventario.Bodega
    ADD CONSTRAINT bodega_usuario_fk FOREIGN KEY ( usuario_usuarioid )
        REFERENCES inventario.usuario ( usuarioid )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE inventario.Detalle_Proyecto
    ADD CONSTRAINT detalle_proyecto_preparar_fk FOREIGN KEY ( preparar_prepararid )
        REFERENCES inventario.preparar ( prepararid )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE inventario.Detalle_Proyecto
    ADD CONSTRAINT detalle_proyecto_proyecto_fk FOREIGN KEY ( proyecto_proyectoid )
        REFERENCES inventario.proyecto ( proyectoid )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE inventario.Preparar
    ADD CONSTRAINT preparar_bodega_fk FOREIGN KEY ( bodega_bodegaid )
        REFERENCES inventario.bodega ( bodegaid )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE inventario.Proyecto
    ADD CONSTRAINT proyecto_usuario_fk FOREIGN KEY ( usuario_usuarioid )
        REFERENCES inventario.usuario ( usuarioid )
ON DELETE NO ACTION 
    ON UPDATE no action 



-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                             5
-- CREATE INDEX                             0
-- ALTER TABLE                             10
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE DATABASE                          0
-- CREATE DEFAULT                           0
-- CREATE INDEX ON VIEW                     0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE ROLE                              0
-- CREATE RULE                              0
-- CREATE SCHEMA                            0
-- CREATE SEQUENCE                          0
-- CREATE PARTITION FUNCTION                0
-- CREATE PARTITION SCHEME                  0
-- 
-- DROP DATABASE                            0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0


create proc InsertarRegistro
@usuarioid int,
@descripcion varchar(100),
@contraseña varchar(50),
@rol int,
as
insert into inventario.usuario values (@usuarioid int,@descripcion varchar(100),@contraseña varchar(50),@rol int,),
go


create proc InsertarProyecto
@proyectoid int,
@descripcion VARCHAR(150),
@usuario_usuarioid int,
as
insert into inventario.proyecto values ( @proyectoid int, @descripcion VARCHAR(150),usuario_usuarioid int),
go

create proc ListarUsuario
as
select from descripcion order by inventario.usuario asc
go

create proc ListarProyecto_M
as
select bodegaid,detalle_proectoid,descripcion 
from inventario.detalle_proyecto
inner join inventario.bodega on inventario.detalle_proyecto.preparar_prepararid=inventario.bodega.bodegaid
inner join inventario.proyecto on inventario.detalle_proyecto.proyecto_proyectoid=inventario.proyecto.descripcion
go

