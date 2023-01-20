create database shoppingDB

use shoppingDB

create table products
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit)

	insert into products values(101,'Iphone','Electronics',140000,1)
	insert into products values(102,'Nike','Shoes',8000,1)
	insert into products values(103,'Puma','Shoes',12000,1)
	insert into products values(104,'Sandwitch','Fast-Food',240,0)

	select * from products
	-----------------------------------------------------------------------------------------------------------------------------
	create table Orders
	(
		oId int primary key,
		oDate date,
		oStatus varchar(20),
		oPID int,
		oAmount int,

		constraint chk_status check (oStatus in ('Dilivered','Cancelled','In Transit')),
		constraint fk_oPID foreign key (oPID) references Products
	)
	insert into Orders values(501,GETDATE(), 'In Transit',104, 400)
	insert into Orders values(502,GETDATE() - 5, 'Cancelled',104, 400)
	insert into Orders values(503,GETDATE() - 10, 'Dilivered',104, 400)
	insert into Orders values(504,GETDATE() - 8 , 'In Transit',104, 400)
	insert into Orders values(505,GETDATE() - 2, 'In Transit',104, 400)


	alter table products add pMinimumOrderQty int 
	alter table products add constraint chk_minimumOQty check (pMinimumOrderQty > 1)

	select * from products



















