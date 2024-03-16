select * from Usuarios
select * from Roles
select * from Contactos
select * from Ubicaciones
select * from EstadosSalud
select * from Pacientes
select * from Servicios ORDER BY Servicio 
select * from Facturas order by FechaEmision desc
select CONVERT(datetime, CONVERT(varchar,GETDATE(), 120),121)

select F.FacturaID, F.FechaEmision, P.PNombre, P.SNombre, P.PApellido, P.SApellido, S.Servicio, S.Precio  
from Facturas F inner join Pacientes P on F.PacienteID2 = P.PacienteID join Servicios S on F.ServicioID = S.ServicioID
order by F.FechaEmision desc



/*FACTURAS*/
INSERT INTO Facturas (FechaEmision, ServicioID, PacienteID2)
VALUES (CONVERT(datetime, CONVERT(varchar,GETDATE(), 120),121),
		24, 1
)
INSERT INTO Facturas (FechaEmision, ServicioID, PacienteID2) 
VALUES (CONVERT(datetime, CONVERT(varchar,GETDATE(), 120),121),
		2, 3
)


/*SERVICIO*/
INSERT INTO Servicios (Servicio, Precio) 
VALUES  ('PROFILAXIS SIMPLE + PULIDO',800),
		('PROFILAXIS PROFUNDA + PULIDO',1200),
		('CLASE I SIMPLE',800),
		('CLASE II SIMPLE',800),
		('CLASE I AMPLIA',1000),
		('CLASE II AMPLIA',1000),
		('CLASE III',600),
		('CLASE IV SIMPLE',1000),
		('CLASE IV AMPLIA',1500),
		('CLASE V',600),
		('BASE CAVITARIA',300),
		('CURA ANALGESICA',600),
		('RADIOGRAFIAS',300),
		('EXTRACCIONES SIMPLES (RESTOS)',600),
		('EXTRACCIONES COLGAJOS',1000),
		('3ER MOLAR SIMPLE',3000),
		('3ER MOLAR RETENIDO',4000),
		('3ER MOLAR SEMI RETENIDO', 3500),
		('ENDODONCIA EN ANTERIOR',6000),
		('ENDODONCIA EN PREMOLAR',7000),
		('ENDODONCIA EN MOLAR',8500),
		('INSTALACION DE ORTODONCIA',6000),
		('CONTROL DE ORTODONCIA',1500),
		('BRAKECT DESPEGADO',200),
		('CEMENTACION IONOMERO DE VIDRIO',800),
		('CEMENTA.ACRILICO O PORCELANA HASTA 5 PIEZAS',700),
		('RECONSTRUCCION',1500),
		('TOMA DE  IMPRESIÓN ',500),
		('PERNO DE FIBRA DE VIDRIO',1700),
		('VALPLAST UNILATERAL',6000),
		('VALPLAST DE 2-4 PIEZAS',8000),
		('VALPLAST DE 6-8 PIEZAS',12000),
		('VALPLAST DE 9 PIEZAS EN ADELA',17000),
		('PARCIAL UNILATERAL',4000),
		('PARCIAL DE 2-4 PIEZAS',7000),
		('PARCIAL DE 5-9 PIEZAS',9000),
		('PARCIAL DE 10 PIEZAS EN ADELANTE',15000),
		('ARMAZON METALICO DE 2 PIEZAS',9000),
		('ARMAZON METALICO DE 3 PIEZAS',12000),
		('ARMAZON METALICO DE 4 PIEZAS',13500),
		('ARMAZON METALICO DE 5 PIEZAS',15000),
		('ARMAZON METALICO DE 6 PIEZAS',16500),
		('ARMAZON METALICO DE 7 PIEZAS',17000),
		('ARMAZON METALICO DE 8 PIEZAS',19500),
		('ARMAZON METALICO DE 9 PIEZAS',21000),
		('ARMAZON METALICO DE 10 PIEZAS',22500),
		('ARMAZON METALICO DE 11 PIEZAS',24000),
		('ARMAZON METALICO DE 2 PIEZAS',25500),
		('ARMAZON METALICO DE 2 PIEZAS',27000),
		('ARMAZON METALICO DE 2 PIEZAS',28500),
		('BLANQUEAMIENTO DENTAL',4500),
		('APLICACION DE FLUOR',300),
		('SELLANTES DE FOSAS Y FISURAS',600),
		('EXTRACCIONES DESIDUAS',500),
		('PERNO COLADO',2000),
		('CORONA DE PORCELANA',10000),
		('CORONA DE ZIRCONIA',18000),
		('CORONA EN ACRILICO',3000),
		('PLACAS MIORELAJANTES',2500),
		('RETENEDOR EN METAL',3000),
		('CEMENTACION CON DICAL',500),
		('REGULARIZACION OSEA',5000),
		('PROTESIS TOTAL SUP E INFE',17000),
		('DESOBTURAR',700)

INSERT INTO Pacientes (PNombre, SNombre, PApellido, SApellido, Edad, Sexo, ContactoID, UbicacionID, UsuarioID, EstadoSaludID)
VALUES ('Dani', 'Warior', 'Perez', 'Disla', 24, 'm', 2, 2, 1, 2)
go

INSERT INTO EstadosSalud (Enfermedad, Medicamento, Alergia, Embarazo)VALUES ('Tos', 'Rabano y Miel', 'No es alergico', 'no')
go

INSERT INTO Ubicaciones (Ciudad, Sector, Calle, NumCasa) VALUES ('Invivienda', 'El parque', 'Avenida B', '112')
go

INSERT INTO Contactos (Celular) VALUES ('8297024694')
go

INSERT INTO Usuarios (
	Nombres,
	Apellidos,
	Usuario,
	Contraseña,
	RolID
	)
VALUES  ('George', 'Rojas', 'DiversOriginal', Encryptbypassphrase('Password','Gerc1998'), 1),
		('Geynis', 'Chanlatte', 'DraChanlatte', Encryptbypassphrase('Password','123456'), 5),
		('Santa', 'Adames', 'Santa', Encryptbypassphrase('Password','123456'), 2),
		('Mabel', 'Ogando', 'DraOgando', Encryptbypassphrase('Password','123456'), 3)

go

select  Nombres, Apellidos, Usuario, 
		CONVERT(VARCHAR, DECRYPTBYPASSPHRASE('Password',Contraseña)) AS Contraseña, RolID 
from Usuarios
go

INSERT INTO Roles (Rol) 
VALUES	('Doctora General'),
		('Administrador'),
		('Recepcionista'),
		('Empleado'),
		('Programador')
