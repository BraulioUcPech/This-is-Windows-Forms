create database ControlDeAsistencias;

use ControlDeAsistencias;



CREATE TABLE Empleado(
	ID_emplea int identity(1,1) primary key,
	nombre nvarchar(50) not null,
	apellidoP nvarchar(50) not null,
	apellidosM nvarchar(50) not null,
	fecha_nac date not null,
	direccion nvarchar(50) not null,
	telefono nvarchar(10) not null,
	email nvarchar(50) not null,
	ID_depart int,
	ID_posicion int
	FOREIGN KEY (ID_depart) REFERENCES Departamentos(ID_depart) ,
    FOREIGN KEY (ID_posicion) REFERENCES Posicion (ID_posicion)
);
CREATE TABLE Departamentos(
	ID_depart int identity(1,1) primary key,
	departemento nvarchar(50) not null
);
CREATE TABLE Posicion (
	ID_posicion int identity(1,1) PRIMARY KEY,
	posicion varchar(50) not null
);
CREATE TABLE Asistencia(
	ID_asis int identity(1,1) primary key,
	FOREIGN KEY (ID_emplea) REFERENCES Empleado(ID_emplea),
	FOREIGN KEY (ID_turno) REFERENCES Turno(ID_turno),
	hora_entrada time not null,
	hora_salidad time not null,
	fecha date not null,
	horas_trabajadas int not null,
	puntualidad BIT not null,
	ausencias int not null,

	ID_emplea int,
	ID_turno int

);
CREATE TABLE Turno(
	ID_turno int identity(1,1) Primary key,
	turno_correspondiente  nvarchar(50) not null,
	hora_inicio time not null,
	hora_fin time not null
);
CREATE TABLE Horarios(
	ID_horios int identity(1,1) primary key,
	FOREIGN KEY (ID_emplea) REFERENCES Empleado(ID_emplea),
	FOREIGN KEY (ID_depart)REFERENCES Departamentos(ID_depart),

    FOREIGN KEY (ID_posicion) REFERENCES Posicion (ID_posicion),
	FOREIGN KEY (ID_turno) REFERENCES Turno(ID_turno),

	Horas_extras time not null,

	ID_emplea int,
	ID_depart int, 
	ID_posicion int,
	ID_turno int,
);



create table TipoUsuarios(
	ID int identity(1,1) Primary key,
	usuario nvarchar(50) not null, 
	contraseña nvarchar(50) not null,
	FOREIGN KEY (ID_posicion) REFERENCES Posicion (ID_posicion),
	email nvarchar(100) not null,
	ID_posicion int

);


DECLARE @usu nvarchar(50)
DECLARE @pass nvarchar(50)
DECLARE @id nvarchar(50)



DELETE Horarios WHERE ID_emplea = '20';

delete Empleado where ID_emplea LIKE '%[12-34]%'

/*La visualizacion de la tablas creadas*/
SELECT * FROM TipoUsuarios;
select * from Asistencia;
select * from Empleado;
select * from Departamentos;
select * from Horarios;
select * from Posicion;
select * from Turno;



create proc ListaDeEmpleados
as
select ID_emplea, nombre, apellidoP, apellidosM, fecha_nac, direccion, telefono, email, departemento, posicion
 from Empleado 
INNER JOIN Departamentos ON Empleado.ID_depart = Departamentos.ID_depart
INNER JOIN Posicion ON Empleado.ID_posicion = posicion.ID_posicion
go

create proc USERLIST
AS
SELECT 
    t.ID, t.usuario, t.contraseña, t.email,
    p.posicion
FROM 
    TipoUsuarios t
    INNER JOIN Posicion p ON t.ID_posicion = p.ID_posicion;
GO

create proc ListaHorarios
as
SELECT 
    e.ID_emplea, e.nombre, e.apellidoP, e.apellidosM, e.fecha_nac, e.direccion,
    d.departemento, 
    p.posicion,
    t.turno_correspondiente, t.hora_inicio, t.hora_fin,
    h.Horas_extras
FROM 
    Horarios h
    INNER JOIN Empleado e ON h.ID_emplea = e.ID_emplea
    INNER JOIN Departamentos d ON h.ID_depart = d.ID_depart
    INNER JOIN Posicion p ON h.ID_posicion = p.ID_posicion
    INNER JOIN Turno t ON h.ID_turno = t.ID_turno;
go


INSERT INTO Asistencia (hora_entrada, hora_salidad, fecha, horas_trabajadas, puntualidad, ausencias, ID_emplea, ID_turno) VALUES (GETDATE(), GETDATE(), GETDATE(), 23, 'TRUE', 23, 1, 1);
INsert into Horarios (Horas_extras, ID_emplea, ID_depart, ID_posicion, ID_turno) values ('08:30:00', 1, 2, 2, 4);


create proc ListaDeDepartamentos 
as
select *from Departamentos order by departemento asc
go
create proc ListaDePosicion
as
select *from Posicion order by posicion asc
go
create proc listaturno
as
select * from Turno order by turno_correspondiente, hora_inicio, hora_fin asc
go
create proc AgregarEmpleado
@nombre nvarchar(100),
@apellidoP nvarchar(100),
@apellidosM nvarchar (100),
@fecha_nac date,
@direccion nvarchar (100),
@telefono nvarchar (20),
@email nvarchar(100),
@ID_depart int,
@ID_posicion int
as
insert into Empleado values (@nombre,@apellidoP,@apellidosM,@fecha_nac,@direccion,@telefono,@email,@ID_depart,@ID_posicion)
go


insert into Empleado (nombre, apellidoP, apellidosM, fecha_nac, direccion, telefono, email) value ('')

/*Agregar columnas DROP COLUMN*/
ALTER Table Horarios DROP COLUMN  ID_emplea;
alter table TipoUsuarios add email nvarchar(100) not null



Select ID_depart from Departamentos where departemento = ''


alter table Asistencia ALTER COLUMN ausencias INT not null;

SELECT * FROM TipoUsuarios WHERE usuario = 'hola' AND contraseña = 'hola123';


insert into Posicion values ('Supervisor')
insert into Departamentos values ('Bodega');
insert into TipoUsuarios (usuario, contraseña, email) values ('supervisor', '123456', 'example@gmail.com');
insert into Empleado (nombre, apellidoP, apellidosM, fecha_nac, direccion, telefono, email)values	
							( 'braulio', 'uc', 'cp', '2000-02-01', 'unadafd', '999999', 'bralulio@gamil.com');
INSERT INTO Turno (turno_correspondiente, hora_inicio, hora_fin) VALUES ('Vespertino', '08:30:00', '11:45:11');


select C.usuario as 'usuario', C.contraseña as 'Contraseña'
from TipoUsuarios as C


SELECT nombre, email FROM Empleado;

SELECT * FROM Departamentos;


SELECT nombre, email
FROM Empleado
WHERE ID_depart = (SELECT ID_depart FROM Departamentos WHERE departemento = 'Bodega');

SELECT ID_asis, SUM(horas_trabajadas)
FROM Asistencia
GROUP BY ID_asis;


SELECT e.nombre, e.email, d.departemento
FROM Empleado e
JOIN Departamentos d ON e.ID_depart = d.ID_depart
JOIN Asistencia a ON e.ID_emplea = a.ID_emplea
WHERE a.fecha = '2022-03-28' AND a.horas_trabajadas > 8;

SELECT nombre, email
FROM Empleado
WHERE ID_emplea NOT IN (
  SELECT ID_emplea
  FROM Asistencia
  WHERE fecha >= DATEADD(month, -1, GETDATE()) AND ausencias > 0
);








/*Consulta Nood (principiante)*/
/*Seleccionar todos los registros de una tabla*/
SELECT * FROM Empleado;

/*Seleccionar registros con una condición específica*/
SELECT * FROM Empleado WHERE nombre='braulio';

/*Ordenar los resultados por una columna  ASC/DESC*/
SELECT * FROM Empleado ORDER BY nombre DESC;



/*Consulta Pro (intermedio)*/
/*Unir dos o más tablas*/
SELECT apellidoP FROM Empleado JOIN TipoUsuarios ON Empleado.apellidoP = TipoUsuarios.usuario;

/*Filtrar registros por una fecha específica*/
SELECT * FROM Empleado WHERE fecha_nac BETWEEN '2022-01-01' AND '2022-12-31';

/*Agrupar registros por una columna y realizar cálculos en ellas*/
SELECT nombre, AVG(apellidoP) AS Cantidad FROM Empleado GROUP BY nombre;

SELECT ID FROM Empleado JOIN Asistencia ON Empleado.nombre = Asistencia.hora_entrada 
JOIN Departamentos ON Empleado.apellidoP = Departamentos.departemento;

/*Simplificar las consultas*/
WITH cte AS (SELECT apellidoP, apellidosM FROM Empleado)
SELECT apellidoP, COUNT(apellidosM) AS Conteo FROM cte GROUP BY apellidoP;

/*Realizar calculos en un conjunto*/
SELECT Horas_extras, ID_depart, SUM(ID_depart) OVER (PARTITION BY Horas_extras ORDER BY ID_depart) AS Total FROM Horarios;


/*Consulta Master (avanzado)*/
/*crear una vista*/
CREATE VIEW telefono AS SELECT * FROM Empleado;

/*Utilizar una función agregada para contar registros distintos*/
SELECT COUNT(DISTINCT telefono) AS Conteo FROM Empleado;

/*Utilizar una subconsulta para obtener resultados*/
SELECT nombre FROM Empleado WHERE apellidosM IN (SELECT apellidoP FROM TipoUsuarios);


/*procedimiento almacenado para realizar una secuencia de operaciones en la base de datos:*/
CREATE PROCEDURE NombreProcedimiento @parametro1 int, @parametro2 varchar(50)
AS
BEGIN
    SELECT * FROM Empleado WHERE nombre = @parametro1 AND email = @parametro2;
    UPDATE Empleado SET apellidoP = 'Bass' 
END;

select ID_posicion from Posicion union select ID_posicion from Empleado;

SELECT e.nombre, p.posicion
FROM Empleado e
JOIN Posicion p ON e.ID_emplea = e.ID_emplea;

/* consultas básicas */

SELECT * FROM Empleado WHERE nombre = 'Arcenio';
SELECT departemento from Departamentos;

/* consultas intermedias */
SELECT nombre FROM Empleado WHERE nombre LIKE '%a';
SELECT COUNT(*) FROM Departamentos WHERE departemento = 'Bodega';

