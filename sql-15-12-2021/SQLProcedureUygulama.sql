create database odev
use odev
---personeller
--id int primary key
--isim nvarchar 50 zorunlu alan
--soyisim nvarchar 50
--cinsiyet nchar(1)
--emailadress nvarchar 200 zorunlu ve benzersiz alan

--oluturma tarihi zorunlu
--durum bool default true

create table personeller
(
id int primary key,
isim varchar(50) not null,
soyisim varchar(50),
cinsiyet nchar(1),
email nvarchar(200) unique not null,
olusturma_tarihi datetime not null,
durum bit default 'true'

)

select 
pp.BusinessEntityID ,--id
pp.FirstName,--isim
pp.LastName,--soisim
hre.Gender,--cinsiyet
--sonradan ekle
pp.FirstName+'.'+pp.LastName+'@'+'abc.com' as Email
from AdventureWorks2019.Person.Person pp
inner join AdventureWorks2019.HumanResources.Employee hre
on pp.BusinessEntityID=hre.BusinessEntityID
 --ayn� sql serverda darl� dblerden d�nen resultlar� farkl� tablolara ekleyebilirim

 ---burdan d�nen resultu email kolonu i�in isim.soyisim@abc.com olarak ekleyin ve
 --d�nen data i�erisindeki t�m kay�tlar� personeller tablosuna ekle

 insert into personeller(id,isim,soyisim,cinsiyet,email,olusturma_tarihi) 
select 
pp.BusinessEntityID ,--id
pp.FirstName,--isim
pp.LastName,--soisim
hre.Gender,--cinsiyet
--sonradan ekle
Lower(pp.FirstName)+'.'+Lower(pp.LastName)+'@'+'abc.com' as Email,
getdate() as tarih
from AdventureWorks2019.Person.Person pp
inner join AdventureWorks2019.HumanResources.Employee hre
on pp.BusinessEntityID=hre.BusinessEntityID

select * from personeller


---�dev Personelekle
--Personeld�zenle
---Personelsilme
--PersonelListe(parametre almayacak)
--PersonelGetirId(�d alan sp e�er de�er giri�i olmazsa id nin default de�eri 0)
--personelAraEmail Adres(email adres de�eri alacak zorunlu)

create proc PersonelEkle
(@id int ,
@isim varchar(50) ,
@soyisim varchar(50) ,
@cinsiyet nchar(1) ,@email nvarchar(200),@olusturma datetime,
@durum bit
)
with encryption
as

begin
insert into personeller(id,isim,soyisim,cinsiyet,email,olusturma_tarihi,durum)
values (@id , @isim,@soyisim,@cinsiyet,@email,getdate(),@durum)
return @@rowcount --etkilenen kay�t say�s�n� return et bazen d�nm�yor
end
 exec PersonelEkle

 ------d�zenleme


 create proc PersonelDuzenle
(@id int ,
@isim varchar(50) ,
@soyisim varchar(50) ,
@email nvarchar(200)
)
with encryption
as

begin
update personeller set isim=@isim,soyisim=@soyisim,email=@email where id=@id
return @@rowcount --etkilenen kay�t say�s�n� return et bazen d�nm�yor
end


---------------Sil
create proc PersonelSil
(@id int 
)
with encryption
as

begin
delete personeller where id=@id
return @@rowcount --etkilenen kay�t say�s�n� return et bazen d�nm�yor
end
------T�m personelleri getir
create proc PersonelListele

with encryption
as

begin
select * from personeller
return @@rowcount --etkilenen kay�t say�s�n� return et bazen d�nm�yor
end

------id ile getir
create proc PersonelGetirId
(@id int =0
)
with encryption
as

begin
select *from personeller where id=@id
return @@rowcount --etkilenen kay�t say�s�n� return et bazen d�nm�yor
end

-----personel email adres ara
create proc PersonelEmailAra
(@email nvarchar(200) not null
)
with encryption
as

begin
select * from personeller where email=@email
return @@rowcount --etkilenen kay�t say�s�n� return et bazen d�nm�yor
end