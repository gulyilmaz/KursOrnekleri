/****  Store Procedure***************/
--c# taki method gibi d�s�nebiliriz
 create table personeller
 (
 �d int primary key,
 isim nvarchar (50),
  soyisim nvarchar (50),
    email nvarchar (50),
  olusturma_tarihi datetime ,
degistirme_tarihi datetime ,
silindimi bit
 )
 select * from personeller


 ---Store procedure �ncesi

 insert into personeller values(1,'g�l','y�lmaz','info@deneme',GETDATE(),null,0)


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
 (--b�t�n tablonun elemanlar�n� yazmak zorunda de�ilim kar��dan ne almak istiyorsam sadece onlar�

 @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 as begin

 insert into personeller (�d,isim,soyisim,email,olusturma_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),0)
 end

 ---programmability alt�nda store procedur

 ----proceduru �al��t�rmak i�in sql e �zel
 exec PersonelKayitEkle @id=1,@isim='g�l2',@soyisim='y�lmazz',@email='deneme@'
 ---store procedurler 1 int de�er d�ner c# taraf�nda biz burdan yakal�caz
 select * from personeller
 --yada procedure sa� t�k exec diyebilirim


 ----olu�mu� proceduru nas�l g�ncellerim


 alter proc PersonelKayitEkle
 (

 @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 as begin

 insert into personeller (�d,isim,soyisim,email,olusturma_tarihi,degistirme_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),GETDATE(),0)
 end
 exec PersonelKayitEkle @id=2,@isim='g�l2',@soyisim='y�lmazz',@email='deneme@'
 select * from personeller
 ----ya da sa� tu� Modify den yapar�z
 --procedure kitli olursa modify dan yapamam sorgu ile d�zeltmem laz�m

 ----silmek istenen procedure i�in
 drop proc PersonelKayitEkle



 ----procedurelerin i�eri�ini saklamak

 ---i�eri�i a��k b�rak�rsam procedure m�dahale debilirler.Kar�� taraf burdaki verilere ula�amad��� i�in i�in ehli olan ki�ilerden yard�m al�r

 create proc PersonelKayitEkle
 (--b�t�n tablonun elemanlar�n� yazmak zorunda de�ilim kar��dan ne almak istiyorsam sadece onlar�

 @id int,
 @isim varchar(50),
 @soyisim varchar(50),
 @email varchar(50)
 )
 with encryption
 as begin

 insert into personeller (�d,isim,soyisim,email,olusturma_tarihi,silindimi)
 values(@id,@isim,@soyisim,@email,GETDATE(),0)
 end
 --yan�nda kilit ��kar yana bak modify edemem



 
 ------Paramertre almayan de�er d�nd�ren procedure
 --select proced�r�

 create proc PersonelGetir
 as
 begin 

 select * from personeller

 end

 exec PersonelGetir
 select  * from personeller





