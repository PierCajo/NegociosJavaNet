create database reniec
use reniec
drop table Persona
CREATE TABLE Persona 
    ( 
     Dni VARCHAR (15)  NOT NULL , 
     Nombres VARCHAR(50)  NOT NULL , 
     Apellidos VARCHAR(250)  NOT NULL , 
	 direccion  varchar(250),
	 telefono   varchar(20),
     Estado int
    ) 
ALTER TABLE Persona 
    ADD CONSTRAINT Persona_PK PRIMARY KEY ( Dni ) ;