 -----opsiyonel olrak deðer alýrsa onla gelsin almazsa sabit olsun

 ---eðer gender ý belirtildiyse ona göre gelsin yoksa gender ý f  olanlar göstersin

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

 insert into personeller (ýd,isim,soyisim,email,olusturma_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),0)
 end

 ----personel tablosuna cinsiyet alaný eklemek istedim izin vermedi içinde veri var diye
 ----çözümü Tools-Option -DEsigner dan tiki kaldýr



 --- ilerleyen süreçte tabloda yeni alan eklendi store procedru ve o procedure parametre gönderen c#
   alter proc personelekle2
  ( @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50),
 @cinsiyet char(1)
 )
 as begin

 insert into personeller (ýd,isim,soyisim,email,olusturma_tarihi,cinsiyet,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),@cinsiyet,0)
 end
 ---bunu execute ettiðim an çalýþsan sistemde tüm ekle procedurleri hata verir.eksik parametre der
 ---bunun önüne geçke için 
   alter proc personelekle2
  ( @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50),
 @cinsiyet char(1) = 'M' -- gelmeze default bunu ata dicem
 )
 as begin

 insert into personeller (ýd,isim,soyisim,email,olusturma_tarihi,cinsiyet,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),@cinsiyet,0)
 end