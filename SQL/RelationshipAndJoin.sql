--Constraints
--not null
--unique 
--not null + unique=primary key
--check
--default

use Csharp03

----------------------Table------------------------
create table Groups(
Id int primary key identity ,
[Name] nvarchar(50) not null unique
)

drop table Groups

create table Students(
Id int primary key identity ,
Firstname nvarchar(30) not null check(len(Firstname)>2),
Email Nvarchar(50) not null unique,
Gender nvarchar(6) check(Gender in('male','female')),
Country nvarchar(200) Default 'Azerbaijan',
GroupId int not null,
foreign key (GroupId) references Groups(Id)
)
alter table Students add Grade int

select *from Students
Join Groups on Students.GroupId=Groups.Id

select Students.Firstname 'Telebe', Groups.Name 'Qrup' from Students
Join Groups on Students.GroupId=Groups.Id
--------------------------------------------------------------------------
--Aggregation function

select sum(Grade) from Students where Grade>30

select avg(Grade) from Students where Grade>30

select count(Grade) from Students where Grade>30

select min(Grade) from Students where Grade>30
select max(Grade) from Students where Grade>30

--------------------------------------------------------------------------------------------------------------------------------
--3 type
--One to One (unique olur) (məs: 1 müəllifin 1 kitabı olur)
--One to Many (məs: 1 müəllifin bir neçə kitabı olur)
--Many to Many (məs: müəllifin bir neçə kitabı və həmin kitabın bir neçə müəllifi olur)



----------------One to One and One to Many---------------------
create table Author
(
Id int primary key identity ,
[Name] nvarchar(50)
)

create table Book(
Id int primary key identity ,
[Name] nvarchar(50),
AuthorId int unique not null,
foreign key (AuthorId) references Author(Id)
)

drop table Book


----------------Many to Many---------------------
create table Author
(
Id int primary key identity ,
[Name] nvarchar(50)
)

create table Book
(
Id int primary key identity ,
[Name] nvarchar(50)
)

create table AuthorToBook
(
AuthorId int  not null,
foreign key (AuthorId) references Author(Id),
BookId int  not null,
foreign key (BookId) references Book(Id)
)

select *from Students

select *from AuthorToBook
join Author on AuthorToBook.AuthorId=Author.Id
join Book on AuthorToBook.BookId=Book.Id


select Author.Name 'Muellif', Book.Name 'Kitab' from AuthorToBook
join Author on AuthorToBook.AuthorId=Author.Id
join Book on AuthorToBook.BookId=Book.Id