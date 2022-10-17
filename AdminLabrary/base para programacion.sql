use master;
go
drop database if exists  Bibliotecaprogram;
go
create database Bibliotecaprogram;
go

use Bibliotecaprogram;
go

--Creando las tablas que contendra nuestra base de datos:
create table Editoriales(Id_Editorial int identity (1,1) primary key not null
,Editorial varchar (50) not null,Fundada date,Direccion varchar (100),estado int
);
go
create table Categorias(Id_categoria int identity (1,1) primary key not null,Categoria varchar (30),estado int);
go
create table Autores(Id_autor int identity (1,1) primary key not null, Nombre varchar (50) not null,
fecha_nacimiento date, Nacionalidad varchar (20),
estado int
);
go
create table Libros(Id_libro int identity (1,1) primary key not null,Nombre varchar (50) not null,
cantidad int not null,Año date,Numero_edicion int not null, Id_autor int not null,Id_Editorial int not null,
Id_categoria int not null,estado int
);
go

create table Lectores(Id_Lector int identity (1,1) primary key not null, Nombres varchar (50) not null,Apellidos varchar (50),estado int);
go
create table Roles(Id_rol int identity (1,1) primary key not null,Usuario varchar (30) not null, Contraseña varchar (30),Id_Lector int not null foreign key references Lectores (Id_lector),estado int,Rol int not null);
go
create table Alquileres (Id_alquiler int identity (1,1) primary key not null,Id_Lector int not null,
Id_libro int not null,cantidad int not null, Entregado int not null foreign key references Roles (Id_rol), fecha_salida date not null, fecha_prevista_de_entrega date not null, fecha_de_entrega date,Recibido int foreign key references Roles (Id_rol) );
go
create table solicitudes(id_soli int primary key identity (1,1),id_lector int not null foreign key references Lectores (Id_lector),libros int not null foreign key references Libros (Id_libro), Cantidad int, estado int);
go
-- Creando las relaciones

alter table Libros add foreign key (Id_Editorial) references Editoriales (Id_Editorial);
go

alter table Libros add foreign key (Id_categoria) references Categorias (Id_categoria);
go

alter table Libros add foreign key (Id_autor) references Autores (Id_autor);
go

alter table Alquileres add foreign key (Id_lector) references Lectores (Id_lector);
go


alter table Alquileres add foreign key (Id_libro) references Libros (Id_libro);
go

create trigger Actualizar_cantidad on alquileres after insert 
as 
	begin
			declare @id_libro int,
			@cantidadPrestamo int
			select 
			@id_libro=id_libro,@cantidadPrestamo=cantidad
			from inserted
			declare @cantidad int
			select 
			@cantidad=cantidad
			from Libros
			where Id_libro=@id_libro
			set @cantidad=@cantidad-@cantidadPrestamo
			update Libros
			set cantidad = @cantidad
			where Id_libro=@id_libro
	end 
go

create trigger Regresar_libros on alquileres after update
as
	begin
	declare @id_libro int,
			@cantidadPrestamo int
			select 
			@id_libro=id_libro,@cantidadPrestamo=cantidad
			from inserted
			declare @cantidad int
			select 
			@cantidad=cantidad
			from Libros
			where Id_libro=@id_libro
			set @cantidad=@cantidad+@cantidadPrestamo
			update Libros
			set cantidad = @cantidad
			where Id_libro=@id_libro
	end
go

 --Creacion de procedimientos almacenados

 --Insertar autores
 
create procedure sp_insertarAutores
@Nombre varchar (50),
@Fecha_nacimiento date,
@Nacionalidad varchar (20)
as
begin
insert into Autores (Nombre,fecha_nacimiento,Nacionalidad,estado)values(@Nombre,@Fecha_nacimiento,@Nacionalidad,0)
end
go

-- Insertar editoriales

create proc sp_InsertarEditoriales
@Editorial varchar (50),
@Fundada date,
@Direccion varchar (100)
as
begin
insert into Editoriales (Editorial,Fundada,Direccion,estado)values(@Editorial, @Fundada,@Direccion,0)
end
go

--  Insertar Categoria
create proc sp_InsertarCategoria 
@Categoria varchar (30)
as
begin 
insert into Categorias (Categoria, estado) values (@Categoria,0)
end
go

-- Insertar Lectores

create proc sp_InsertarLectores
@Nombres varchar(50),
@Apellidos varchar (50)

as
begin
insert into Lectores (Nombres,Apellidos,estado) values (@Nombres,@Apellidos,0)
end
go

-- Insertar Libros

create proc sp_InsertarLibros
@Nombre varchar (50) ,
@cantidad int ,@Año date,
@Numero_edicion int , @Id_autor int,
@Id_Editorial int ,
@Id_categoria int
as
declare @mensaje varchar (100)
begin
	if (@cantidad>0) begin
	insert into Libros(Nombre,cantidad, Año, Numero_edicion, Id_autor, Id_Editorial, Id_categoria,estado) values
	(@Nombre,@cantidad,@Año ,@Numero_edicion, @Id_autor,@Id_Editorial,@Id_categoria,0)
	
	print @mensaje
	end
else 
	begin 
	set @mensaje = 'No se puenden insertar libros con cantidad cero'
	print @mensaje
	end
end
go



-- Insertar Categorias

exec sp_InsertarCategoria 'Obras generales' 
exec sp_InsertarCategoria 'Filosofia/Psicologia'
exec sp_InsertarCategoria 'Religion'
exec sp_InsertarCategoria 'Ciencias Sociales'
exec sp_InsertarCategoria 'Ciencias aplicadas'
exec sp_InsertarCategoria 'Artes'
exec sp_InsertarCategoria 'Lengua/Literatura' 
exec sp_InsertarCategoria 'Geografia/Historia'
exec sp_InsertarCategoria 'Tesis'



--Insertar autores

exec sp_insertarAutores 'Alvaro Menen Desleal','1931-03-13','Salvadoreño'
exec sp_insertarAutores 'George Armitage Miller','1920-02-03','Estadounidense'
exec sp_insertarAutores 'Jose Maria Zavala','1962-01-12','Español'
exec sp_insertarAutores 'Juan Torres Lopez','1954-06-11','Español'
exec sp_insertarAutores 'Andrea Pastor','1961-08-15','Español'
exec sp_insertarAutores 'Fernando de rojas','1470-02-02','España'

--insertar Editoriales

exec sp_InsertarEditoriales 'Anagrama','1969-03-24','Barcelona, España'
exec sp_InsertarEditoriales 'Luis Miracle S.A','1964-12-03','New York, U.S'
exec sp_InsertarEditoriales 'Ediciones Martinez Roca','1965-07-26','Madrid, España'
exec sp_InsertarEditoriales 'Bohodon Ediciones','1969-04-01','Barcelona, España'
exec sp_InsertarEditoriales 'Coleccion Pensamiento','1999-03-17','1a Calle Poniente Bis # 1040 San Salvador, El Salvador'

--insertar libros

exec sp_InsertarLibros 'Luz Negra',20,'1962-01-05',1,1,1,7
exec sp_InsertarLibros 'Introduccion a la Psicologia',5,'1980-09-04',2,2,1,1
exec sp_InsertarLibros 'El cuarto vidente de Fatima',12,'1860-11-23',1,3,2,2
exec sp_InsertarLibros 'Introduccion a la economia',12,'1920-10-29',2,4,3,3
exec sp_InsertarLibros 'Introduccion a la economia',12,'1920-10-29',2,4,3,3
exec sp_InsertarLibros 'Ciencias aplicadas',14,'2005-05-30',3,5,4,4
exec sp_Insertarlibros 'La Celestina',5,'1814-09-12',8,6,5,7
exec sp_Insertarlibros 'Matematica aplicada',10,'1814-09-12',8,6,5,7


--Insertar Lectores

exec sp_InsertarLectores 'Rafael Antonio ','Gonzalez Portillo'
exec sp_InsertarLectores 'Kevin Josue',' Rodriguez Portillo'
exec sp_InsertarLectores 'Cristina Beatriz',' Rodriguez Valle'
exec sp_InsertarLectores 'Carlos Alexander',' Menjivar Lopez'
exec sp_InsertarLectores 'Jacqueline Jasmin',' Robles Galdamez '
exec sp_InsertarLectores 'Fatima de Jesus',' Robles Galdamez'



insert into roles (usuario,contraseña,id_lector,estado,rol)values('Rafta','123',1,0,1)
insert into roles (usuario,contraseña,id_lector,estado,rol)values('Jasmin','123',5,0,1)



