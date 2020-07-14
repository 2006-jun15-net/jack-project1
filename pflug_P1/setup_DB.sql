drop table Customer;
drop table customerOrder;
drop table OrderItem;
drop table StoreLocation;
drop table OrderHistory

Create table Customer(
CustomerId int not null identity primary key,
firstName nvarchar (30),
lastName nvarchar (30),


)

Create table storeLocation(
locationName nvarchar(30) primary key,
)

create table OrderItem (
ProductId int not null identity primary key,
ProductName nvarchar(30) not null unique,
Price numeric(10,2)

)


create table Inventory(
ProductId int not null references OrderItem(ProductId) on delete cascade on update cascade,
LocationName nvarchar (30) foreign key references storeLocation(LocationName) on delete cascade on update cascade,
Stock int
)

create table customerOrder(
OrderId int not null primary key identity,
ProductId int not null references OrderItem(ProductId) on delete cascade on update cascade,
amountPurchased int
)

create table OrderHistory(

OrderId int not null ,
ProductName nvarchar(30) foreign key references OrderItem(ProductName) on delete cascade on update cascade,
CustomerId int not null references Customer(CustomerId) on delete cascade on update cascade,
OrderDate Date,
OrderTime Time,
LocationName nvarchar(30) references storeLocation(locationName) on delete cascade on update cascade,
CustomerName nvarchar(30),

)

--load some dummy data

insert into Customer values ('Jack', 'Pflug')
insert into Customer values ('Morgan', 'Pflug')
insert into Customer values ('Luke', 'Maffei')
insert into Customer values ('Mark', 'Feocco')

select * from Customer,

select * from customerOrder
select * from storeLocation
--adding fk constraint to customer orders

alter table customerOrder
	add LocationName nvarchar(30)

Alter table customerOrder
	Add constraint FK_customerOrder_LocationName Foreign Key (LocationName)
	references storeLocation(locationName)
	on delete cascade
	on update cascade;