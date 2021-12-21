--create database Academy

--use Academy

create table Student
(
Id int identity,
Fullname nvarchar(25),
Qrup nvarchar(10),
Birthdate date,
Grade nvarchar(15)
)

insert into dbo.Student (Fullname,Qrup,Birthdate,Grade)
values
('Eli','333T6','1995-10-12','senior')

select Fullname,Qrup from dbo.Student

select *from dbo.Student where Fullname='Xeyal' and Grade='middle'

select *from dbo.Student where Fullname='Xeyal' or Grade='middle'

select *from dbo.Student where Id in(1,3)

select *from dbo.Student where Id between 1 and 3

select *from dbo.Student where Qrup like '305b4'

select top(2) *from dbo.Student

select *from dbo.Student order by Id offset 2 row fetch first 2  rows only