Declare @categoryname nvarchar(15),
@description nvarchar(100)
set @categoryname='tahýllar'
set @description='Buðday,Arpa,Yulaf'
insert into Categories
(CategoryName,Description)
values (@categoryname,@description)
select * from Categories
/*dýþardan çaðýrma dinamik sql