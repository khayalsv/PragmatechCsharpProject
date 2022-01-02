create database ParfumStore

use ParfumStore

-------------------Create Table
create table Parfum
(
ID int primary key identity,
[Name] nvarchar(50),
Price int,
CatagoriesID int not null,
BrandID int not null,
foreign key (CatagoriesID) references Catagories(ID),
foreign key (BrandID) references Brand(ID)
)


create table Brand
(
ID int primary key identity,
[Name] nvarchar(50)
)

create table Catagories
(
ID int primary key identity,
[Name] nvarchar(50)
)

create table Sale
(
ID int primary key identity,
ParfumID int not null,
Amount int not null
foreign key (ParfumID) references Parfum(ID)
)

drop table Sale


-----------------------Add Procedure------------------------------

create procedure AddParfum
@name nvarchar(max)=null,
@price int,
@catagoriesid int,
@brandid int
as
insert into Parfum(Name,Price,CatagoriesID,BrandID) values
(@name,@price,@catagoriesid,@brandid)

execute AddParfum 'Agonist','50',2,2
execute AddParfum 'Fendi','70',1,1
execute AddParfum 'Escada','30',1,3


-------------------Update Procedure----------
create procedure UpdateParfum
@name nvarchar(max)=null,
@id int
as
update Parfum set Name=@name where ID=@id 

execute UpdateParfum 'Soel',2




-------------------Delete Procedure----------------------------

create procedure DeleteParfum
@id int
as
delete from Parfum where Id=@id

execute DeleteParfum 2

---------------------ParfumInfo---------------------------------------

create view ParfumInfo as
select Parfum.Name 'Name',Catagories.Name 'Catagories',Brand.Name 'Brand' from Parfum
join Catagories on Parfum.CatagoriesID=Catagories.ID
join Brand on Parfum.BrandID=Brand.ID

select *from ParfumInfo


---------------------Sale View-----------------------------

create view SaleInfo as
select Parfum.Name 'Name',Parfum.Price 'Price',Catagories.Name 'Catagories',Brand.Name 'Brand',Sale.Amount 'Amount'
from Parfum
join Sale on Parfum.ID=Sale.ParfumID
join Catagories on Parfum.CatagoriesID=Catagories.ID
join Brand on Parfum.BrandID=Brand.ID


select *from SaleInfo


-------------------------BetweenSale---------------------------

create procedure BetweenSale
@minsum int,
@maxsum int
as
select Parfum.Name 'Name',Parfum.Price 'Price',Catagories.Name 'Catagories',Brand.Name 'Brand',Sale.Amount 'Amount'
from Parfum
join Sale on Parfum.ID=Sale.ParfumID
join Catagories on Parfum.CatagoriesID=Catagories.ID
join Brand on Parfum.BrandID=Brand.ID
where Sale.Amount>@minsum and Sale.Amount<@maxsum

execute BetweenSale '30','80'


-------------------------SearchInfo-------------------------------

create procedure SearchInfo
@search nvarchar(max)=null,
@minsum int,
@maxsum int
as
select Parfum.Name 'Name',Parfum.Price 'Price',Catagories.Name 'Catagories',Brand.Name 'Brand',Sale.Amount 'Amount'
from Parfum
join Sale on Parfum.ID=Sale.ParfumID
join Catagories on Parfum.CatagoriesID=Catagories.ID
join Brand on Parfum.BrandID=Brand.ID
where Parfum.Price>@minsum and Parfum.Price<@maxsum and
Parfum.Name like '%' + ISNULL(@search ,Parfum.Name)+'%' or
Brand.Name like '%' + ISNULL(@search ,Brand.Name)+'%' or
Catagories.Name like '%' + ISNULL(@search ,Catagories.Name)+'%'

execute SearchInfo 'esca','20','90'

