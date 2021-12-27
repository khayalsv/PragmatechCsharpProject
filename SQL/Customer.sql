create database Company

use Company

create table Position
(
Id int primary key identity,
[Name] nvarchar(30) not null unique
)


create table Customers
(
Id int primary key identity,
Firstname nvarchar(30) not null,
Surname nvarchar(30) not null,
Salary int,
PositionId int not null,
foreign key (PositionId) references Position(Id)
)


drop table Customers
drop table Position


insert into Customers(Firstname,Surname,Salary,PositionId) values
('Rasim','Aliyev','700',3),
('Nurlan','Hesenli','800',1),
('Xeyal','Selimov','500',2),
('Sadiq','Ilyasli','300',3)


select *from Customers



select Customers.Firstname 'Ad', Position.[Name] 'Posiziya' from Customers
Join Position on Customers.PositionId=Position.Id


update Customers set Firstname='Khayal',Surname='Salimov' where Id=1
update Customers set Firstname='Rasim',Surname='Aliyev' where Id=2


delete from Customers where Firstname='Xeyal'
delete from Customers where Id=3

select avg(Salary) from Customers where Salary>0

select Salary,Firstname from Customers where Salary>(select avg(Salary)from Customers)

select Salary,Firstname from Customers where Salary=(select max(Salary) from Customers)

select Salary,Surname from Customers where Salary=(select min(Salary) from Customers)



insert into Customers(Firstname,Surname,Salary,PositionId) values
('Rasim','Aliyev','700',3),
('Nurlan','Hesenli','800',1),
('Xeyal','Selimov','500',2),
('Sadiq','Ilyasli','300',3)


 

create procedure AddMethod
@firstname nvarchar(max)=null,
@surname nvarchar(max)=null,
@salary int,
@positionid int
as
insert into Customers(Firstname,Surname,Salary,PositionId) values
(@firstname,@surname,@salary,@positionid)

execute AddMethod 'Eli','Eliyev','400',3
