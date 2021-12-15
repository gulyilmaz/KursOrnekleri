--SQLde View kullan�m�
--sanal tablo gibidirler
--kendi isted�iniz kriterler ve sorgulara g�re olu�turulular
--raporlama i�lemlerinde s�k�a kullan�l�r
---G�venlik nedeniyle kullan�l�r
use Northwind
create view productname
as
select * from Products where ProductID<=8

select * from productname

exec sp_helptext productname --yazm�� oldu�unuz view in kodlar�n� g�rebiliriz
--bunu �nlemek i�in olu�turuken �ifre koyarsam i�ine bakamazlar


--create encryption view
create view productname_enc
with encryption
as
select * from Products where ProductID<=8


exec sp_helptext productname_enc --g�stermez


--create SchemaBinding view
--belirli kolonlar�n silinmesini ya da de�i�tirilmesini istemeyiz.B�yle bir istekte kolonlar� koruma alt�na alabilirz.kolon ad� ya da tipi de�i�triliemz i�indeki veriyi de�i�tirebilirsiniz
--(*) i�areti ile t�m kolonlar� koruma alt�na alamay�z.hangi kolonlar� koruma alt�na alacaksak onu belirtmeliyiz
--nesneyi SchemaBinding ile olu�tururken kullan�lan tablolar� dbo anahtar s�zc���yle kullanmak gerekir

create view kategoriisimleri
with schemabinding
as
select CategoryName from dbo.Categories


select *  from kategoriisimleri


--bunlar� d�zenlemek isteyelim
alter table Categories
alter column CategoryName varchar(500)--hata verirr
alter table Categories
alter column description varchar(500) --vermez

--witch check option
--viewin i�ersindeki sorguda bulunan �arta uygun kay�tlar�n insert edilmesine m�saade edilip uymayan kay�tlar�n giri�ine izin verilmemesini sa�lar

create table personel(
id int identity,
isim varchar(50),
soyisim varchar(50)
)


create view ornekview2
as
select isim from personel where isim like 'R%'
select * from ornekview2
insert ornekview2 values('g�l')
insert ornekview2 values('rahimeg�l')
select * from personel


--with encryption ve with shemabindingte komutlar� as keywordunden �nce belirtirken with check option komutu where �art�ndan sonra belirtilir
alter view ornekview2
as
select isim from personel where isim like 'R%'
with check option

insert ornekview2 values('g�l')
insert ornekview2 values('rahimeg�l')

--her seferinde tablolar �zerinde i�lem yapmak i�in inner join komutunu yazmadan �zerinde i�lem yapmak istiyorum                                           



create view orderDetail
with encryption
as

select p.ProductName,od.UnitPrice,Quantity,Discount,c.CompanyName from [Order Details] od
inner join Products p on p.ProductID=od.ProductID
inner join Orders o on od.OrderID=o.OrderID
inner join Customers c on c.CustomerID=o.CustomerID

select *from orderDetail 
where Quantity<12


exec sp_helptext orderDetail --yazm�� oldu�unuz view in kodlar�n� g�rebiliriz
--bunu �nlemek i�in olu�turuken �ifre koyarsam i�ine bakamazlar

drop view orderDetail --dersem siler
use odev
---g�ncelleme
alter view deneme
as 
select * from personeller where personeller.isim='ken'

select* from deneme
