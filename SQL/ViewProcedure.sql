use Csharp03

select *from Students

create table Country
(
ID int primary key identity,
[Name] nvarchar(20)
)

create table City
(
ID int primary key identity,
[Name] nvarchar(20),
CountryID int not null,
Foreign key (CountryID) references Country(ID)
)

alter table Students add CityID int,
foreign key (CityID) references City(ID)


select Students.Firstname 'Telebe', Groups.[Name] 'Qrup',City.[Name],Country.[Name]
from Students
Join Groups on Students.GroupId=Groups.Id
Join City on Students.CityID=City.ID
Join Country on City.CountryID=Country.ID

-----------------Create view---------------------------
create view StudentInfo as
select Students.Firstname 'Telebe', Groups.Name 'Qrup' from Students
Join Groups on Students.GroupId=Groups.Id


select *from StudentInfo
-------------------------------------------------------
alter table Students add Grade int


select *from Students where Grade>40

---------------Procedure------------------------------
create procedure viewGrade @grade int as
select *from Students where Grade>@grade

execute viewGrade 40
execute viewGrade 70


---------------------Procedure Search method-------------------
create procedure StudentView
@firstname nvarchar (max)=null,
@city nvarchar (max)=null,
@country nvarchar (max)=null
as
select Students.Firstname 'Telebe', Groups.[Name] 'Qrup',City.[Name],Country.[Name]
from Students
Join Groups on Students.GroupId=Groups.Id
Join City on Students.CityID=City.ID
Join Country on City.CountryID=Country.ID
where Students.Firstname like '%' + isnull(@firstname, Students.Firstname) + '%' and
City.Name like '%' + isnull(@city, City.Name) + '%' and
Country.Name like '%' + isnull(@country, Country.Name) + '%'

execute StudentView '','','Aze'


------------------------Procedure Insert method--------------------
insert into Students(Firstname,Email,GroupId) values
('Eli','eliyev@mail.ru',2),
('Veli','veliyev@gmail.com',1)


select *from Students
 

create procedure AddMethod
@firstname nvarchar(max)=null,
@email nvarchar(max)=null,
@groupid int
as
insert into Students(Firstname,Email,GroupId) values
(@firstname,@email,@groupid)

execute AddMethod 'selim','selimov@gmail.com',3