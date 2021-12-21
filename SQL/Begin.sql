--SQL-Structure Query Language
--3 type:
--DML-Data Manipalutaion Language-> select,insert,uptade,delete-> (bazanı redakte edir)
--DDL-Data Definition Language-> create,alter(edit),add,drop(silmək),rename-> (baza və ya table yaratmaq,dəyişmək)
--DCL-Data Control Language-> (bazaya giriş-çıxışları yoxluyur,təhlükəsizlik)

--create database Csharp03

--use Csharp03

--create table Employee
--(
--Id int identity(100,1),
--Firstname nvarchar(25),
--Email nvarchar(50),
--Birthdate date,
--Salary int
--)

insert into dbo.Employee (Firstname,Email,Birthdate,Salary)
values
('Nurlan','nurlan@gmail.com','2001.5.16',2000),
('Eli','veliyev@gmail.com','1994.5.16',1800)

select Firstname,Salary,Email from dbo.Employee

delete from dbo.Employee where Firstname='Eli'

delete from dbo.Employee where Id in (115,116)

select *from dbo.Employee where Email like '%gmail%'

select *from dbo.Employee where not Salary='1500'

select top(2) *from dbo.Employee

select *from dbo.Employee order by Id offset 2 rows

update dbo.Employee set Firstname='Khayal',Email='khayal@gmail.com'
where Id=100

alter table dbo.Employee add Country nvarchar(50)
alter table dbo.Employee drop column Birthdate

select *from dbo.Employee where Country='Azerbaijan' and Firstname='Khayal'
