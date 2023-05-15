
USE CURSO;

select * from CATEGORIAS;
select * from INSCRITOS;
select * from CURSOS;
select * from PARTICIPANTES;

Alter Table PARTICIPANTES DROP COLUMN  turno_correspondiente;
alter table PARTICIPANTES add 	edad int

insert into CATEGORIAS (fecha_captura, nombre) VALUES (GETDATE(), 'BASE DE DATOS 8');
UPDATE CATEGORIAS SET nombre = 'ciberseguridad avanzada' WHERE id  = '2';
DELETE PARTICIPANTES WHERE matricula = '6';

select * from CATEGORIAS  WHERE fecha_captura  = '2023-03-15'  

SELECT * FROM CATEGORIAS WHERE fecha_captura = '' OR nombre = 'ti';

SELECT * FROM CATEGORIAS WHERE fecha_captura = '2023-03-15' and fecha_captura = '2023-02-17'

SELECT * FROM CATEGORIAS WHERE fecha_captura BETWEEN '2023-03-15' AND '2023-02-17'

insert into CATEGORIAS (fecha_captura, nombre) VALUES ('2022-01-15', 'ciberseguridad avanzada');

SELECT * FROM CATEGORIAS where nombre like 'ciber%';

SELECT * FROM PARTICIPANTES where matricula LIKE '%[0-10]%'













