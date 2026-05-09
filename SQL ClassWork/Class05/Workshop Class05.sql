use [master]
go




alter database [PizzaOrdering]
set SINGLE_USER
with rollback immediate;
go 

DROP database if exists PizzaOrdering 

create database [PizzaOrdering]
go

use [PizzaOrdering]
go

drop table if exists Users
drop table if exists Pizzas
drop table if exists PizzaSizes
drop table if exists Toppings
drop table if exists Orders
drop table if exists OrderDetails
drop table if exists PizzaToppings
drop table if exists OrderDetailToppings


create table Users(
	Id int identity (1,1) primary key,
	FirstName nvarchar (100) not null,
	LastName nvarchar (100) not null,
	Address nvarchar (150) not null,
	Phone nvarchar (30) not null

)
create table PizzaSizes (
	Id int identity (1,1) primary key,
	Name nvarchar (50) not null,
)


create table Pizzas (
	Id int identity (1,1) primary key,
	Name nvarchar (100) not null,
	Price decimal (10,2) not null,
	Description nvarchar (max),
	SizeId int not null

)



create table Toppings(
	Id int identity (1,1) primary key,
	Name nvarchar (100) not null,
	Price decimal (4,2) not null

)

create table Orders (
	Id int identity (1,1) primary key,
	UserId int not null,
	IsDelivered bit not null DEFAULT 0,
	TotalPrice decimal (10,2) not null
)


create table OrderDetails(
	Id int identity (1,1) primary key,
	PizzaId int not null,
	OrderId int not null,
	Quantity int not null,
	Price decimal(10,2) not null

)

create table PizzaToppings (	
	Id int identity (1,1) primary key,
	PizzaId int not null,
	ToppingId int not null
)

create table OrderDetailToppings(
	Id int identity (1,1) primary key,
	OrderDetailId int not null,
	ToppingId int not null
)

alter table Pizzas
add constraint FK_Pizzas_PizzaSizes
foreign key (SizeId) references PizzaSizes(Id)

alter table PizzaToppings 
add constraint FK_PizzaToppings_pizzas
foreign key (PizzaId) references Pizzas(Id)

alter table PizzaToppings
add constraint FK_PizzaToppings_Toppings
foreign key (ToppingId) references Toppings(Id)


alter table Orders 
add constraint FK_Orders_Users
foreign key (USerId) references Users(Id)


alter table OrderDetails
add constraint FK_OrderDetails_Pizzas
foreign key (PizzaId) references Pizzas(Id)



alter table OrderDetails
add constraint FK_OrdreDetails_Orders
foreign key (OrderId) references Orders(Id)


alter table OrderDetailToppings
add constraint FK_OrderDetailToppings_OrderDetails
foreign key (OrderDetailId) references OrderDetails(Id)


alter table OrderDetailToppings
add constraint FK_OrderDetailToppings_Toppings
foreign key (ToppingId) references Toppings(Id)







select * from Pizzas
go



create or alter function dbo.GetUserFullName
(
	@FirstName nvarchar(50),
	@LastName nvarchar (50)
)
returns nvarchar (101)
as 
begin
	return concat (@FirstName,' ', @LastName);
end
go

 create or alter view dbo.vv_UndeliverdPizzas
 as
 select o.Id, dbo.GetUserFullName (u.FirstName, u.LastName) as UserFullName, p.Name as PizzaName,
 od.Quantity, od.Price as SingleItemPrice,
 od.Quantity * od.Price as TotalOrderPrice
 from Orders o
 inner join Users u on u.Id = o.UserId
 inner join OrderDetails od on od.OrderId = o.Id
 inner join Pizzas p on p.Id = od.PizzaId
 where o.IsDelivered = 0;
 go


 select * from dbo.vv_UndeliverdPizzas
 go



 create or alter view dbo.vw_PizzasByPopularity 
 as
 select 
	p.Id,
	p.Name as PizzaName,
	sum(od.Quantity) as TotalQuantity
 from Pizzas p
 inner join OrderDetails od on od.PizzaId = p.Id
 group by p.Id, p.Name
 go

 select * from vw_PizzasByPopularity 
 order by TotalQuantity desc