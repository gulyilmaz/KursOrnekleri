 -----opsiyonel olrak de�er al�rsa onla gelsin almazsa sabit olsun

 ---e�er gender � belirtildiyse ona g�re gelsin yoksa gender � f  olanlar g�stersin

 create proc gethumanprocedure(
 @gender char(1) ='F')
 as 
 begin
 select * from HumanResources.Employee
 where Gender=@gender

 end

 exec gethumanprocedure @gender='M'

  exec gethumanprocedure 



  create proc personelekle2
  ( @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 as begin

 insert into personeller (�d,isim,soyisim,email,olusturma_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),0)
 end

 ----personel tablosuna cinsiyet alan� eklemek istedim izin vermedi i�inde veri var diye
 ----��z�m� Tools-Option -DEsigner dan tiki kald�r



 --- ilerleyen s�re�te tabloda yeni alan eklendi store procedru ve o procedure parametre g�nderen c#
   alter proc personelekle2
  ( @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50),
 @cinsiyet char(1)
 )
 as begin

 insert into personeller (�d,isim,soyisim,email,olusturma_tarihi,cinsiyet,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),@cinsiyet,0)
 end
 ---bunu execute etti�im an �al��san sistemde t�m ekle procedurleri hata verir.eksik parametre der
 ---bunun �n�ne ge�ke i�in 
   alter proc personelekle2
  ( @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50),
 @cinsiyet char(1) = 'M' -- gelmeze default bunu ata dicem
 )
 as begin

 insert into personeller (�d,isim,soyisim,email,olusturma_tarihi,cinsiyet,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),@cinsiyet,0)
 end