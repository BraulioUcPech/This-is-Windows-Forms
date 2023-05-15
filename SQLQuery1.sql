/*La creacion de la base de datos*/
CREATE DATABASE CURSO;

/*Indicar el uso de la base de datos*/
USE CURSO;

/*La creacion de tablas: en este caso fueron cuatro, con sus perpectivos atributos con llaver primary key*/
USE CURSO;

CREATE TABLE PARTICIPANTES(
	matricula nvarchar(8) primary key,
	nombre nvarchar(50) not null,
	apellidos1 nvarchar(50) not null,
	apellidos2 nvarchar(50) not null,
	fecha_nac date not null,

	edad int


);


CREATE TABLE CATEGORIAS(
	id int identity(1,1) primary key,
	nombre nvarchar(70) not null,
	fecha_captura date not null
);

/*La creacion de una tabla y con su foreing key*/
CREATE TABLE CURSOS(
	id int identity(1,1) primary key,
	nombre nvarchar(100) not null,
	descripcion nvarchar(250) not null,
	fecha_captura date not null,
	categoria int not null
	foreign key (categoria) references CATEGORIAS(id)
);


CREATE TABLE INSCRITOS(
	
	participante nvarchar(8) not null,
	curso int not null,
	fecha_hora_inscrito datetime not null,
	foreign key(participante) references PARTICIPANTES(matricula),
	foreign key(curso) references CURSOS(id),

	primary key(participante, curso)
);

/*La visualizacion de la tablas creadas*/
select * from PARTICIPANTES;
select * from CURSOS;
select * from CATEGORIAS;
select * from INSCRITOS;
DELETE PARTICIPANTES WHERE matricula = '5';

/*El llenar de los datos a las tablas tambien indicando lo especifico osea a que atributo se tiene que llenar*/
insert into PARTICIPANTES values
			('22090004', 'braulio5', 'uc', 'Pech', '2004-02-22', 20);
ALTER TABLE PARTICIPANTES
ADD  CONSTRAINT CK_PARCIPANTES CHECK (fecha_nac>='2000-02-22');

Insert into CATEGORIAS(nombre, fecha_captura) values
			('TI', '2023-02-17');

Insert into CURSOS(nombre, descripcion, fecha_captura, categoria)values
			('Base de datos', 'modelado de datos conceptual, logico y fisico', '2023-02-17',1);

Insert into INSCRITOS values
			('22090001', 1, '2023-02-18');

select matricula, PARTICIPANTES.nombre, apellidos1, apellidos2, fecha_nac,edad, CATEGORIAS.nombre, CURSOS.nombre
 from PARTICIPANTES 
INNER JOIN CATEGORIAS ON PARTICIPANTES.matricula = CATEGORIAS.id
INNER JOIN CURSOS ON PARTICIPANTES.matricula = CURSOS.id




select count(*) as 'No_Participantes_Instritos' from INSCRITOS

select C.nombre as 'NOMBRE_CURSO', CAT.nombre as 'CATEGORIA_CURSOS'
from CATEGORIAS as CAT	, CURSOS as C
where C.categoria = CAT.id

select CONCAT(P.nombre, ' ', P.apellidos1, ' ', P.apellidos2) as 'Nombre_completo', I.curso as 'id_curso'
from PARTICIPANTES as P, INSCRITOS as I
where I.participante = P.matricula

select P.nombre as 'PARTICIPANTE', C.nombre as 'CURSO', CAT.nombre as 'CATEGORIA', I.fecha_hora_inscrito
from ((INSCRITOS as I
inner join PARTICIPANTES as P ON I.participante = P.matricula)
inner join CURSOS as C ON I.curso = C.id
inner join CATEGORIAS as CAT ON C.categoria = CAT.id);






















/*EJEMPLO DE LA CLASE 1/03/2023*/

use CURSO;

/*realizar consultas a la BD - SQL-DML*/
select * from alumno;
select * from procendencia;
select * from alumno, precendencia;

/*sql-dml*/
alter table alumno add escuela int null;

alter table alumno alter column escuela int not null;

alter table alumno;
add foreing key(escuela) references procedencia(id) ;


/*sql-dml*/
update alumno set escuela = 1 where matricula = '22050124';
select * from alumno;
select * from procendencia;


select * from alumno as a
inner join procedencia as p on a.escuela = p.id;

select a.nombre as ALUMNO, p.nombre as ESCUELA from alumno as a
inner join procedencia as p on a.escuela = p.id
where a.escuela = 1 and a.nombre like '%a';

select count(*) from alumno;
select distinct escuela, procedencia.nombre from alumno;
inner join procedencia on alumno.escuela = precedencia.id;

select concat(a.nombre , 'estudia en la ' , p.nombre) from alumno as a
inner join procedencia as p on a.escuela = p.id;
