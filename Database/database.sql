create database StoreManagement
go

use StoreManagement
create table Unit
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max)
)
insert into Unit(DisplayName) values (N'kg'), (N'mét'), (N'hùng'), (N'chiếc'), (N'Viên')

create table Suplier
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max),
	Address nvarchar(max),
	Phone nvarchar(20),
	Email nvarchar(200),
	MoreInfo nvarchar(max),
	ContractDate DateTime
)
insert into Suplier(DisplayName, Address, Phone, Email, MoreInfo, ContractDate) 
values (N'suplier1', '123456789', 'suplier1@gmail.com', '', '2020-12-04'),
	   (N'suplier2', '987654321', 'suplier2@gmail.com', '', '2020-11-04')

create table Customer
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max),
	Address nvarchar(max),
	Phone nvarchar(20),
	Email nvarchar(200),
	MoreInfo nvarchar(max),
	ContractDate DateTime
)
insert into Customer(DisplayName, Address, Phone, Email, MoreInfo, ContractDate)
values (N'customer1', '123456789', 'customer1@gmail.com', '', '2020-10-04'),
	   (N'customer2', '987654321', 'customer2@gmail.com', '', '2020-8-04')

create table Object
(
	Id nvarchar(128) primary key,
	DisplayName nvarchar(max),
	IdUnit int not null,
	IdSuplier int not null,
	QRCode nvarchar(max),
	BarCode nvarchar(max)

	foreign key(IdUnit) references Unit(Id),
	foreign key(IdSuplier) references Suplier(Id),
)
insert into Object(DisplayName, IdUnit, IdSuplier, QRCode, BarCode)
values (N'Xi măng', 1, 1, N'12345678', N'11111111'),
       (N'Lụa', 2, 2, N'11112222', N'44448888'),
	   (N'Gạo', 1, 2, N'88881818', N'40409999'),
	   (N'Gạch', 5, 2, N'11117771', N'58473958')

create table UserRole
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max)
)
insert into UserRole(DisplayName) values (N'Admin'), (N'Nhân viên')

create table Users
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max),
	UserName nvarchar(100),
	Password nvarchar(max),
	IdRole int not null

	foreign key (IdRole) references UserRole(Id)
)
insert into Users(DisplayName, Username, Password, IdRole) 
values(N'admin1', N'admin', N'db69fc039dcbd2962cb4d28f5891aae1', 1),
	  (N'employee1', N'staff', N'978aae9bb6bee8fb75de3e4830a1be46', 2)

create table Input
(
	Id nvarchar(128) primary key,
	DateInput DateTime
)
insert into Input(DateInput)
values ('2020-12-04'), ('2018-9-12'), ('2019-09-03'), ('2017-02-03')

create table InputInfo
(
	Id nvarchar(128) primary key,
	IdObject nvarchar(128) not null,
	IdInput nvarchar(128) not null,
	Count int,
	InputPrice float default 0,
	OutputPrice float default 0,
	Status nvarchar(max)

	foreign key (IdObject) references Object(Id),
	foreign key (IdInput) references Input(Id)
)
insert into InputInfo(IdObject, IdInput, Count, InputPrice, OutputPrice, Status)
values

create table Output
(
	Id nvarchar(128) primary key,
	DateOutput DateTime
)

create table OutputInfo
(
	Id nvarchar(128) primary key,
	IdObject nvarchar(128) not null,
	IdOutput nvarchar(128) not null,
	IdCustomer int not null,
	Count int,	
	Status nvarchar(max)

	foreign key (IdObject) references Object(Id),
	foreign key (IdOutput) references Output(Id),
	foreign key (IdCustomer) references Customer(Id)
)