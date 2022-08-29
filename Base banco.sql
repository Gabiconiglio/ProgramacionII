
create database Banco
use Banco

create table tipos_dni
(
	id_tipo_dni int,
	tipo_dni varchar (20),
	constraint pk_tipos_dni primary key (id_tipo_dni)
)

create table tipos_cuenta
(
	id_tipo_cuenta int,
	tipo_cuenta varchar (30)
	constraint pk_tipos_cuenta primary key (id_tipo_cuenta)
)

create table ultimos_movimientos
(
	id_ultimo_movimiento int,
	ultimo_movimiento varchar(30)
	constraint pk_ultimos_movimientos primary key(id_ultimo_movimiento)
)

create table tipo_moneda
(
	id_tipo_moneda int,
	tipo_moneda varchar(30)
	constraint pk_tipo_moneda primary key(id_tipo_moneda)
)

create table cuentas
(
	cbu int,
	nombre varchar(50),
	apellido varchar(50),
	id_tipo_dni int,
	dni int,
	id_tipo_cuenta int,
	id_tipo_moneda int,
	id_ultimo_movimiento int,
	saldo float 
	constraint pk_cuentas primary key(cbu),
	constraint fk_cuentas_tipo_dni foreign key(id_tipo_dni)
	references tipos_dni(id_tipo_dni), 
	constraint fk_cuentas_tipos_cuentas foreign key(id_tipo_cuenta)
	references tipos_cuenta (id_tipo_cuenta),
	constraint fk_cuenta_tipo_moneda foreign key(id_tipo_moneda)
	references tipo_moneda (id_tipo_moneda),
	constraint fk_cuentas_ultimo_movimiento foreign key(id_ultimo_movimiento)
	references ultimos_movimientos (id_ultimo_movimiento)
)


select* from tipos_dni

insert into tipos_dni values(1,'Documento unico') 
insert into tipos_dni values(2,'Libreta Enrolamiento')
insert into tipos_dni values(3,'Cedula Civica') 
insert into tipos_dni values(4,'Pasaporte') 

select* from tipos_cuenta

insert into tipos_cuenta values(1,'Caja de Ahorro')
insert into tipos_cuenta values(2,'Cuenta corriente') 

select * from tipo_moneda

insert into tipo_moneda values (1,'Pesos')
insert into tipo_moneda values (2,'Dolares')
insert into tipo_moneda values (3,'Euros')

select * from ultimos_movimientos

insert into ultimos_movimientos values (1,'Deposito')
insert into ultimos_movimientos values (2,'Extración')


select * from cuentas

insert into cuentas values (343728401,'Gabriel','Coniglio',1,35055274,1,1,1,25000.87)
-----

--sp para saber la cantidad de cajas de ahorros que tenemos
create proc pa_cantidad_cajas_ahorro
@cantidad int output
as
select @cantidad=Sum(id_tipo_cuenta)
from cuentas
where id_tipo_cuenta =1

declare @cantidad int
exec pa_cantidad_cajas_ahorro @cantidad output
select @cantidad 'Cantidad de Cajas de Ahorro'
select * from cuentas
--

---sp para saber cantidad de cuentas corrientes
drop proc pa_cantidad_cuentas_corrientes
create proc pa_cantidad_cuentas_corrientes
@cantidad int output
as
select @cantidad=Sum(id_tipo_cuenta)/2
from cuentas
where id_tipo_cuenta=2

declare @cantidad int
exec pa_cantidad_cuentas_corrientes @cantidad output
select @cantidad 'Cantidad cuentas corrientes'
select * from cuentas


-----
--sp para la carga del combo tipo cuentas
drop proc sp_tipos_cuentas

create proc sp_tipos_cuentas
@id_cuenta int output,
@cuentas varchar(20) output
as
select id_tipo_cuenta, tipo_cuenta from tipos_cuenta

declare  @id int ,@tipos_cuenta varchar
exec sp_tipos_cuentas @id output, @tipos_cuenta output
select @id 'codigo' , @tipos_cuenta 'Tipo'
-----

---sp para la carga de la lista sin parametros
create proc Sp_Cuenta
as
select * from tipos_cuenta

exec Sp_Cuenta

create proc lista_cuentas
as
select * from cuentas

exec lista_cuentas
---

--cargar datos de la lista con parametros

drop proc sp_datos
create proc sp_datos
@id_cuenta int,
@apellido varchar(20) output
as
select cbu, nombre, apellido, id_tipo_dni, dni, id_tipo_cuenta, id_tipo_moneda, id_ultimo_movimiento,saldo from cuentas
where cbu=@id_cuenta

declare @ap varchar
exec sp_datos 4324324, @ap output

----
--sp calculo promedio de pesos por cajas de ahorro
create proc sp_promedio_pesos





--sp insert
drop proc sp_insert_cuentas
create proc sp_insert_cuentas
@cbu int,
@nombre varchar(30),
@apellido varchar(30),
@tipo_dni int,
@dni int,
@tipo_cuenta int,
@tipo_moneda int,
@movimiento int,
@saldo float
as
begin
insert into cuentas
values(@cbu,@nombre,@apellido,@tipo_dni,@dni,@tipo_cuenta,@tipo_moneda,@movimiento,@saldo)
end

exec sp_insert_cuentas 1212,'Marcerlo','Gallardo',1,28423123,1,1,1,385709.27
exec sp_insert_cuentas 84734,'Diego','Maradona',1,22832313,2,2,2,429000