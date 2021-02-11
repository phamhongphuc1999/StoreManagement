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
values (N'suplier1', N'Vietname', '123456789', 'suplier1@gmail.com', N'', '2020-12-04'),
	   (N'suplier2', N'Vietname', '987654321', 'suplier2@gmail.com', N'', '2020-11-04')

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
values (N'customer1', N'Vietnam', '123456789', 'customer1@gmail.com', N'', '2020-10-04'),
	   (N'customer2', N'Vietnam', '987654321', 'customer2@gmail.com', N'', '2020-08-04'),
	   (N'customer3', N'Vietnam', '112233445', 'customer2@gmail.com', N'', '2020-01-11')

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
insert into Object(Id, DisplayName, IdUnit, IdSuplier, QRCode, BarCode)
values (N'object1', N'Xi măng', 1, 1, N'12345678', N'11111111'),
       (N'object2', N'Lụa', 2, 2, N'11112222', N'44448888'),
	   (N'object3', N'Gạo', 1, 2, N'88881818', N'40409999'),
	   (N'object4', N'Gạch', 5, 2, N'11117771', N'58473958')

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
	Username nvarchar(100),
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
insert into Input(Id, DateInput)
values (N'input1', '2020-12-04'), (N'input2', '2018-09-12'), 
       (N'input3', '2019-09-03'), (N'input4', '2017-02-03')

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
insert into InputInfo(Id, IdObject, IdInput, Count, InputPrice, OutputPrice, Status)
values(N'inputinfo1', N'object1', N'input1', 100, 100000, 120000, N''),
      (N'inputinfo2', N'object2', N'input2', 500, 500000, 520000, N''),
	  (N'inputinfo3', N'object3', N'input3', 600, 600000, 620000, N''),
	  (N'inputinfo4', N'object4', N'input4', 450, 50000, 55000, N''),
	  (N'inputinfo5', N'object2', N'input1', 600, 550000, 560000, N''),
	  (N'inputinfo6', N'object2', N'input2', 1200, 600000, 550000, N'')

create table Output
(
	Id nvarchar(128) primary key,
	DateOutput DateTime
)
insert into Output(Id, DateOutput)
values (N'output1', '2020-12-05'), (N'output2', '2018-08-12'), 
	   (N'output3', '2019-09-14'), (N'output4', '2017-03-21')

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
insert into OutputInfo(Id, IdObject, IdOutput, IdCustomer, Count, Status)
values(N'outputinfo1', N'object1', N'output1', 1, 10, N''),
      (N'outputinfo2', N'object2', N'output2', 2, 50, N''),
	  (N'outputinfo3', N'object3', N'output3', 3, 70, N''),
	  (N'outputinfo4', N'object4', N'output4', 2, 40, N''),
	  (N'outputinfo5', N'object1', N'output2', 3, 55, N'')