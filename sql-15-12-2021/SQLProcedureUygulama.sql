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
 --ayný sql serverda darlý dblerden dönen resultlarý farklý tablolara ekleyebilirim

 ---burdan dönen resultu email kolonu için isim.soyisim@abc.com olarak ekleyin ve
 --dönen data içerisindeki tüm kayýtlarý personeller tablosuna ekle

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


---ödev Personelekle
--Personeldüzenle
---Personelsilme
--PersonelListe(parametre almayacak)
--PersonelGetirId(ýd alan sp eðer deðer giriþi olmazsa id nin default deðeri 0)
--personelAraEmail Adres(email adres deðeri alacak zorunlu)

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
return @@rowcount --etkilenen kayýt sayýsýný return et bazen dönmüyor
end
 exec PersonelEkle

 ------düzenleme


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
return @@rowcount --etkilenen kayýt sayýsýný return et bazen dönmüyor
end


---------------Sil
create proc PersonelSil
(@id int 
)
with encryption
as

begin
delete personeller where id=@id
return @@rowcount --etkilenen kayýt sayýsýný return et bazen dönmüyor
end
------Tüm personelleri getir
create proc PersonelListele

with encryption
as

begin
select * from personeller
return @@rowcount --etkilenen kayýt sayýsýný return et bazen dönmüyor
end

------id ile getir
create proc PersonelGetirId
(@id int =0
)
with encryption
as

begin
select *from personeller where id=@id
return @@rowcount --etkilenen kayýt sayýsýný return et bazen dönmüyor
end

-----personel email adres ara
create proc PersonelEmailAra
(@email nvarchar(200) not null
)
with encryption
as

begin
select * from personeller where email=@email
return @@rowcount --etkilenen kayýt sayýsýný return et bazen dönmüyor
end