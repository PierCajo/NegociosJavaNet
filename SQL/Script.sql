-- Generated by Oracle SQL Developer Data Modeler Version: 2.0.0 Build: 584
--   at:        2012-10-05 00:18:31
--   site:      SQL Server 2005
--   type:      SQL Server 2005




--Base de datosNegociosJavaNet

CREATE TABLE Articulo 
    (
     IdArticulo VARCHAR (20) NOT NULL , 
     Descripcion VARCHAR (200) , 
     Precio DECIMAL (18,6) , 
     Stock INTEGER , 
     CONSTRAINT Articulo_PK PRIMARY KEY(IdArticulo)
    )


CREATE TABLE Cliente 
    (
     IdCliente VARCHAR (20) NOT NULL , 
     Nombres VARCHAR (60) , 
     Apellidos VARCHAR (60) , 
     Direccion VARCHAR (100) , 
     Estado INTEGER , 
     CONSTRAINT Cliente_PK PRIMARY KEY (IdCliente)
    )
GO 


CREATE TABLE Pedido 
    (
     IdPedido VARCHAR (10) NOT NULL , 
     Fecha DATETIME , 
     CondPago VARCHAR (20) , 
     TipMon VARCHAR (10) , 
     TipCam DECIMAL (18,6) , 
     SubTotal DECIMAL (18,6) , 
     Total DECIMAL (18,6) , 
     IdCliente VARCHAR (20) , 
     CONSTRAINT Pedido_PK PRIMARY KEY (IdPedido)
    )
GO 
    
CREATE TABLE DetallePedido 
    (
     IdPedido VARCHAR (10) , 
     ItemPedido VARCHAR (10) NOT NULL , 
     Precio DECIMAL (18,6) , 
     Cantidad INTEGER , 
     IdArticulo VARCHAR (20) , 
     CONSTRAINT DetallePedido_PK PRIMARY KEY  (ItemPedido)
    )

GO 


ALTER TABLE Pedido 
    ADD CONSTRAINT Relation_1 FOREIGN KEY 
    ( 
     IdCliente
    ) 
    REFERENCES Cliente 
    ( 
     IdCliente 
    ) 
GO 


ALTER TABLE DetallePedido 
    ADD CONSTRAINT Relation_2 FOREIGN KEY 
    ( 
     IdPedido
    ) 
    REFERENCES Pedido 
    ( 
     IdPedido 
    ) 
GO 


ALTER TABLE DetallePedido 
    ADD CONSTRAINT Relation_3 FOREIGN KEY 
    ( 
     IdArticulo
    ) 
    REFERENCES Articulo 
    ( 
     IdArticulo 
    ) 


    


--base de datos BDRiesgo
CREATE TABLE Deuda 
    (
     Iddeuda INTEGER NOT NULL , 
     DNI VARCHAR (20) NOT NULL , 
     Total DECIMAL (18,6) , 
     CONSTRAINT Deuda_PK PRIMARY KEY (Iddeuda)
    )
GO 

    




    
--base datos Reniec


CREATE TABLE Persona 
    (
     Dni VARCHAR (15) NOT NULL , 
     Nombres VARCHAR (50) NOT NULL , 
     Apellidos VARCHAR (250) NOT NULL , 
     Direccion VARCHAR (100) , 
     Estado BIT , 
     CONSTRAINT Persona_PK PRIMARY KEY  (Dni)
    )
GO 

    


--base datos BDProveedor
CREATE TABLE Producto 
    (
     id_producto VARCHAR (20) NOT NULL , 
     Descripcion VARCHAR (250) NOT NULL , 
     Precio DECIMAL (18,6) NOT NULL , 
     Stock INTEGER , 
     CONSTRAINT Producto_PK PRIMARY KEY  (id_producto)
    )
GO 

    
