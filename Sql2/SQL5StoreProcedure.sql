/****  Store Procedure***************/
--c# taki method gibi düsünebiliriz
 create table personeller
 (
 ýd int primary key,
 isim nvarchar (50),
  soyisim nvarchar (50),
    email nvarchar (50),
  olusturma_tarihi datetime ,
degistirme_tarihi datetime ,
silindimi bit
 )
 select * from personeller


 ---Store procedure öncesi

 insert into personeller values(1,'gül','yýlmaz','info@deneme',GETDATE(),null,0)


 --create proc procedure_adi
 --(
 
 ----parametreler veya parametrelerimiz
 --@id int,
 --@isim varchar(50)

 --)
 --as 
 --begin
 -----procedure body
 --end

 create proc PersonelKayitEkle
 (--bütün tablonun elemanlarýný yazmak zorunda deðilim karþýdan ne almak istiyorsam sadece onlarý

 @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 as begin

 insert into personeller (ýd,isim,soyisim,email,olusturma_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),0)
 end

 ---programmability altýnda store procedur

 ----proceduru çalýþtýrmak için sql e özel
 exec PersonelKayitEkle @id=1,@isim='gül2',@soyisim='yýlmazz',@email='deneme@'
 ---store procedurler 1 int deðer döner c# tarafýnda biz burdan yakalýcaz
 select * from personeller
 --yada procedure sað týk exec diyebilirim


 ----oluþmuþ proceduru nasýl güncellerim


 alter proc PersonelKayitEkle
 (

 @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 as begin

 insert into personeller (ýd,isim,soyisim,email,olusturma_tarihi,degistirme_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),GETDATE(),0)
 end
 exec PersonelKayitEkle @id=2,@isim='gül2',@soyisim='yýlmazz',@email='deneme@'
 select * from personeller
 ----ya da sað tuþ Modify den yaparýz
 --procedure kitli olursa modify dan yapamam sorgu ile düzeltmem lazým

 ----silmek istenen procedure için
 drop proc PersonelKayitEkle



 ----procedurelerin içeriðini saklamak

 ---içeriði açýk býrakýrsam procedure müdahale debilirler.Karþý taraf burdaki verilere ulaþamadýðý için iþin ehli olan kiþilerden yardým alýr

 create proc PersonelKayitEkle
 (--bütün tablonun elemanlarýný yazmak zorunda deðilim karþýdan ne almak istiyorsam sadece onlarý

 @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 with encryption
 as begin

 insert into personeller (ýd,isim,soyisim,email,olusturma_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),0)
 end
 --yanýnda kilit çýkar yana bak modify edemem



 
 ------Paramertre almayan deðer döndüren procedure
 --select procedürü

 create proc PersonelGetir
 as
 begin 

 select * from personeller

 end

 exec PersonelGetir
 select  * from personeller





