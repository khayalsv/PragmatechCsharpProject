create database Market

use Market

create table Product
(
Id int primary key identity,
[Name] nvarchar (20),
Price int
)

alter table Product add Brand int
alter table Product drop column Brand

select * from Product

create procedure AddProduct
@name nvarchar (max)=null,
@price int,
@brand int
as
insert into Product([Name],Price,Brand) values (@name,@price,@brand)

execute AddProduct 'makaron','20','60'

select * from Product where Price<10

select * from Product where Price<(select avg(Price) from Product)

create view ProductInfo as
select Name ,Brand from Product where Brand>5

select *from ProductInfo 