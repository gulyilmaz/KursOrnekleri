--SQLde View kullanýmý
--sanal tablo gibidirler
--kendi istedðiniz kriterler ve sorgulara göre oluþturulular
--raporlama iþlemlerinde sýkça kullanýlýr
---Güvenlik nedeniyle kullanýlýr
use Northwind
create view productname
as
select * from Products where ProductID<=8

select * from productname

exec sp_helptext productname --yazmýþ olduðunuz view in kodlarýný görebiliriz
--bunu önlemek için oluþturuken þifre koyarsam içine bakamazlar


--create encryption view
create view productname_enc
with encryption
as
select * from Products where ProductID<=8


exec sp_helptext productname_enc --göstermez


--create SchemaBinding view
--belirli kolonlarýn silinmesini ya da deðiþtirilmesini istemeyiz.Böyle bir istekte kolonlarý koruma altýna alabilirz.kolon adý ya da tipi deðiþtriliemz içindeki veriyi deðiþtirebilirsiniz
--(*) iþareti ile tüm kolonlarý koruma altýna alamayýz.hangi kolonlarý koruma altýna alacaksak onu belirtmeliyiz
--nesneyi SchemaBinding ile oluþtururken kullanýlan tablolarý dbo anahtar sözcüðüyle kullanmak gerekir

create view kategoriisimleri
with schemabinding
as
select CategoryName from dbo.Categories


select *  from kategoriisimleri


--bunlarý düzenlemek isteyelim
alter table Categories
alter column CategoryName varchar(500)--hata verirr
alter table Categories
alter column description varchar(500) --vermez

--witch check option
--viewin içersindeki sorguda bulunan þarta uygun kayýtlarýn insert edilmesine müsaade edilip uymayan kayýtlarýn giriþine izin verilmemesini saðlar

create table personel(
id int identity,
isim varchar(50),
soyisim varchar(50)
)


create view ornekview2
as
select isim from personel where isim like 'R%'
select * from ornekview2
insert ornekview2 values('gül')
insert ornekview2 values('rahimegül')
select * from personel


--with encryption ve with shemabindingte komutlarý as keywordunden önce belirtirken with check option komutu where þartýndan sonra belirtilir
alter view ornekview2
as
select isim from personel where isim like 'R%'
with check option

insert ornekview2 values('gül')
insert ornekview2 values('rahimegül')

--her seferinde tablolar üzerinde iþlem yapmak için inner join komutunu yazmadan üzerinde iþlem yapmak istiyorum                                           



create view orderDetail
with encryption
as

select p.ProductName,od.UnitPrice,Quantity,Discount,c.CompanyName from [Order Details] od
inner join Products p on p.ProductID=od.ProductID
inner join Orders o on od.OrderID=o.OrderID
inner join Customers c on c.CustomerID=o.CustomerID

select *from orderDetail 
where Quantity<12


exec sp_helptext orderDetail --yazmýþ olduðunuz view in kodlarýný görebiliriz
--bunu önlemek için oluþturuken þifre koyarsam içine bakamazlar

drop view orderDetail --dersem siler
use odev
---güncelleme
alter view deneme
as 
select * from personeller where personeller.isim='ken'

select* from deneme
