use sqlfull


go
----database
create database ders

---silmek i�in 
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

 ---bir kolonun �zelli�ini de�i�tircem

 alter table tablo_adi
 alter column isim nvarchar(300);
 --- tablo silme 
 drop table tablo ad�

 --Ben bir Tabloya veri eklemek istedi�imde insert intoyu kullan�r�m.
-- 1.KULLANIM 
--insert into tabload�(kolon1,kolon2,kolon3)values(deger1,deger2,deger3)
--2.KULLANIM
--insert into tabload� values(deger1,deger2)
--eksik bilgi girmemem laz�m value de�erini doldurmal�y�m


insert into personel(Personel_id,Isim,Soyisim,EmailAdres) values(1,'g�l','y�lmaz','gulyilmaz93@gmail.com')


--Update genel kullan�m�

--update tabload�
--Set
--kolon1=yenideger
--kolon2=yenideger
--where

update personel
set Soyisim='Boz',
Isim='G�L'--B�yle yaparsam t�m tablo etkilenir

update personel
set Soyisim='y�lmaz',
Isim='g�L'
where Personel_id=1

select * from personel

--verileri silmek i�in delete komutundan faydalan�r�z

--delete tablo ad� where kriter
delete personel where id=2

