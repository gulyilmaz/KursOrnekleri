Declare @categoryname nvarchar(15),
@description nvarchar(100)
set @categoryname='tah�llar'
set @description='Bu�day,Arpa,Yulaf'
insert into Categories
(CategoryName,Description)
values (@categoryname,@description)
select * from Categories
/*d��ardan �a��rma dinamik sql