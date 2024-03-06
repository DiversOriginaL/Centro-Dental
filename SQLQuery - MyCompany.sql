create database MyCompany
go
use MyCompany
go

create table Usuarios(
	Id int identity(1,1) primary key,
	Usuario nvarchar(100) not null,
	Contrasena nvarchar(100) not null,
	Nombre nvarchar(100) not null,
	Apellido nvarchar(100) not null,
	Posicion nvarchar(100) not null,
	Email nvarchar(150) not null

)
go

insert into Usuarios values('admin', 'admin', 'Hector', 'Rojas', 'Programador','etbrojas02@gmail.com')
insert into Usuarios values('Juan', '123456', 'Chanlatte', 'Rojas', 'administrador','etbrojas02@gmail.com')
insert into Usuarios values('Sierva', '123456', 'Estefanie', 'Corripio', 'Recepcionista','etbrojas02@gmail.com')

go

select * from Usuarios

declare @user nvarchar(100)
declare @pass nvarchar(100)
select*from Usuarios where Usuario = @user and Contrasena = @pass