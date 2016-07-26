sqlite3 filmDBdb;

create table peliculas (
	id int primary key,
	titulo text,
	anio text,
	genero text,
	reseniada int,
	url text,
	valoracion int
);

insert into peliculas (
	titulo, anio, genero, reseniada, url, valoracion
						)
	values
	( 
	'Vanilla Sky', '2001', 'Ciencia ficcion', 0, 'SIN URL', 10
	);