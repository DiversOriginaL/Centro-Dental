create database CentroDental
go 

use CentroDental
go

create table Roles(
	RolID int identity(1,1) primary key,
	Rol varchar(250)
	)

go

create table Usuarios(
	UsuarioID int primary key IDENTITY(1,1),
	Nombres varchar(50),
	Apellidos varchar(50),
	Usuario varchar(50) unique,
	Contraseña varbinary(8000),
	RolID int,
	Foreign key(RolID) references Roles(RolID)
	)
go

create table Contactos(
	ContactoID int primary key identity(1,1),
	Celular varchar(250),
	Telefono varchar(250)
	)
go

create table Ubicaciones(
	UbicacionID int primary key identity (1,1),
	Ciudad varchar(250),
	Sector varchar(250),
	Calle varchar(250),
	NumCasa varchar(250)
	)
go

create table EstadosSalud(
	EstadoSaludID int primary key identity(1,1),
	Enfermedad varchar(1000),
	Medicamento varchar(1000),
	Alergia varchar(1000),
	Embarazo varchar(1000)
	)
go

create table Pacientes(
	PacienteID int primary key identity(1,1),
	PNombre varchar(250),
	SNombre varchar(250),
	PApellido varchar(250),
	SApellido varchar(250),
	Edad int,
	Sexo char(2),
	ContactoID int,
	Foreign key(ContactoID) References Contactos(ContactoID),
	UbicacionID int,
	Foreign key(UbicacionID) References Ubicaciones(UbicacionID),
	UsuarioID int,
	Foreign key(UsuarioID) References Usuarios(UsuarioID),
	EstadoSaludID int,
	Foreign key(EstadoSaludID) References EstadosSalud(EstadoSaludID)
	)
go

create table Servicios(
	ServicioID int primary key identity(1,1),
	Servicio varchar(250),
	Precio decimal(10,2)
	)
go

create table DetallesFacturas(
	Id int primary key identity(1,1),
	Servicio varchar(250),
	Precio decimal(10,2),
	SubTotal decimal(10,2),
	Descuento decimal(10,2),
	Total decimal(10,2),
	FechaEmision Datetime,
)
go

create table Facturas(
	FacturaID int primary key identity(1,1),
	ServicioID int,
	Foreign key (ServicioID) References Servicios(ServicioID),
	PacienteID2 int,
	Foreign key (PacienteID2) References Pacientes(PacienteID),
	DetalleFacturaID int,
	Foreign key (DetalleFacturaID) References DetallesFacturas(Id)
)
