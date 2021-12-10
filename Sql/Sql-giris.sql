use sqlfull


go
----database
create database ders

---silmek için 
drop database ders


 create table personel(
 Personel_id int,
 Isim nvarchar(40),
 Soyisim nvarchar(40),
 EmailAdres nvarchar(60)
 
 )

 alter table personel
 add TelefonNumarasi nvarchar(12)


 alter table personel
 drop column TelefonNumarasi

 ---bir kolonun özelliðini deðiþtircem

 alter table tablo_adi
 alter column isim nvarchar(300);
 --- tablo silme 
 drop table tablo adý

 --Ben bir Tabloya veri eklemek istediðimde insert intoyu kullanýrým.
-- 1.KULLANIM 
--insert into tabloadý(kolon1,kolon2,kolon3)values(deger1,deger2,deger3)
--2.KULLANIM
--insert into tabloadý values(deger1,deger2)
--eksik bilgi girmemem lazým value deðerini doldurmalýyým


insert into personel(Personel_id,Isim,Soyisim,EmailAdres) values(1,'gül','yýlmaz','gulyilmaz93@gmail.com')


--Update genel kullanýmý

--update tabloadý
--Set
--kolon1=yenideger
--kolon2=yenideger
--where

update personel
set Soyisim='Boz',
Isim='GÜL'--Böyle yaparsam tüm tablo etkilenir

update personel
set Soyisim='yýlmaz',
Isim='güL'
where Personel_id=1

select * from personel

--verileri silmek için delete komutundan faydalanýrýz

--delete tablo adý where kriter
delete personel where id=2

