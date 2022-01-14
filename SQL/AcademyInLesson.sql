create database Akademiya

use Akademiya

create table [Group]
(
ID int primary key identity,
[Name] nvarchar(20)
)


create table Students
(
ID int primary key identity,
[Name] nvarchar(20) not null unique,
Surname nvarchar(20) not null unique,
GroupID int,
foreign key (GroupID) references [Group](ID)
)


alter table Students add Grade int
------------------------

insert into [Group](Name) values
('PPPPPPPPPPP')

------------------------

select Students.Name 'Telebe',[Group].Name 'Qrup' from Students 
Join [Group] on Students.GroupID=[Group].ID

-------------------------

select *from Students where [GroupID]=1
-------------------

select count(Students.Name) from Students where GroupID=1
select count(Students.Name) from Students 




----------------------------------------------------------
create view StudendsInfo as
select Students.Name 'Telebe',Students.Surname 'Soyad',Students.Grade,[Group].Name 'Qrup' from Students 
Join [Group] on Students.GroupID=[Group].ID

select *from StudendsInfo



--------------------------
create procedure SumInfo
@sum int
as
select Students.Name 'Telebe',Students.Surname 'Soyad',Students.Grade,[Group].Name 'Qrup' from Students 
Join [Group] on Students.GroupID=[Group].ID
where Students.Grade>@sum

execute SumInfo 30