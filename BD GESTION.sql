CREATE DATABASE GESTIONBD

CREATE TABLE CLIENTE (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
CORREOELECTRONICO NVARCHAR (20) NULL,
TELEFONO NVARCHAR (50) NULL,
DIRECCION NVARCHAR (50) NOT NULL,
PRIMARY KEY (IDCLIENTE),
);

CREATE TABLE PEDIDO (
IDPEDIDO INT IDENTITY (1,1) NOT NULL,
IDCLIENTE INT NOT NULL,
FECHA DATETIME NOT NULL,
TOTAL MONEY NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPEDIDO),
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE),
);


insert into CLIENTE values('Jesus','Aviles','jesusito@gmail.com','+59171548964','Barrio Los Olivos');
insert into CLIENTE values('Cristian','Romero','cristitan@gmail.com','+59174584578','Barrio Moto Mendez');
insert into CLIENTE values('Manuel','Velasquez','manuelito@gmail.com','+59174562546','Barrio San Martin');

insert into PEDIDO values(1,'2022-02-01 14:00:00',100,'Pendiente');
insert into PEDIDO values(2,'2022-03-01 14:00:00',50,'Completado');
insert into PEDIDO values(3,'2022-04-01 14:00:00',80,'Proceso');
insert into PEDIDO values(1,'2022-05-01 14:00:00',201,'Proceso');
insert into PEDIDO values(2,'2022-06-01 14:00:00',650,'Completado');
insert into PEDIDO values(3,'2022-07-01 14:00:00',80,'Completado');
insert into PEDIDO values(1,'2022-08-01 14:00:00',120,'Pendiente');
insert into PEDIDO values(2,'2022-09-01 14:00:00',30,'Completado');
insert into PEDIDO values(3,'2022-10-01 14:00:00',40,'Proceso');