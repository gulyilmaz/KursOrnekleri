--Triggers (Tetikleyiciler)
---Dml Trihgger
--Bir tabloda insert,update ve delete iþlemleri gerçekleþtiðinde devreye giren yapýlardýr.Bu iþlemler sonucunda veya sürecinde devreye girerler
---DDl Trigger
--Create,Alte ve Drop islemleri sonucunda veya sürecinde devreye girecek olan yapýlar


---Inserted Table: Eðer bir tabloda insert iþlemi yapýlýyorsa arka planda ilk önce ram de oluþturan inserted isimli bir tablo üzerinde iþlem yapýlýr.Eðer iþlemde bir problem yoksa inserted tablosundaki veriler fiziksel tabloya insert edilir.Ýþlem bittiðinde Ram de oluþturalan bu tablo silinir

---Deleted Table: Eðer bir tabloda delete iþlemi yapýlýyorsa arka planda ilk önce ram de oluþturan deleted isimli bir tablo üzerinde iþlem yapýlýr.Eðer iþlemde bir problem yoksa deleted tablosundaki veriler fiziksel tablodan silinir.Ýþlem bittiðinde Ram de oluþturalan bu tablo silinir



--Eðer bir tabloda update iþlemi yapýlýyorsa Ramde updated isimli bir tablo OLUÞTURMAZ!!
--Sql deki update mantýðýnda  önce silme sonra ekleme dir
--Eðer bir update iþlemi yapýlýyorsa hem deleted hem inserted tablolarý oluþturulur ve iþlemler bunlar üzerinde yapýlýr.



--NOT:Update yapýlýrken güncellenen kaydýn orjinali deleted tablosunda ,güncellendikten sonraki hali ise inserted tablosunda tutulur.Çünkü güncelleme demejk önce silmek sonra eklemek demektir.
--Deleted ve inserted tablolarý ilgili sorgu sonucuoluþtuklarý için o sorgunun kullandýðý kolonlara da sahip olur.Böylece deleted ve inserted tablolarýndan select sorgusu yapmak mümkündür


---Trigger Tanýmlama

--Create trigger triggerAdý
--on iþlem yapýlacak tablo adý
--after -- veya for delete,update,insert
--as
--kodlar

--tanýmlanan triggerlara ilgili tablonun triggers alanýndan ulaþýlýr
use sqlfull
create trigger ornektrigger
on personel
after insert
as
Select* from personel


insert into personel(isim,soyisim) values('büþra','duran')


--Örnek1
--ürünlerr tablosundan bir veri silindiðinde tüm ürünlerin fiyatý otomatik olarak 10 artsýn
use sqlfull
insert into urunler(urun_ismi,fiyat,kategori_id) 
select np.productname,np.UnitPrice,np.CategoryID from Northwind.dbo.Products np

insert into kategoriler(kategori_name) 
select c.CategoryName from Northwind.dbo.Categories c

create trigger triggerurunler
on 
urunler
after delete
as
update urunler set fiyat=fiyat+10
select* from urunler


delete from urunler where urun_id=1

---Örnek 2
--ürünler tablosunda bir veri güncellendiðinde ,kategoriler tablosunda 'meyve kokteyli adýnda bir alan oluþþsun
select * from kategoriler

create trigger triggerurunlerguncel
on 
urunler
for update
as
insert into kategoriler(kategori_name) values ('meyve kokteyli')
select* from urunler

update urunler set urun_ismi='deneme' where urun_id=30
select * from kategoriler


--Örnek 3
--personeller tablosunda bir kayýt silindiðinde silinen kaydýn adý ,soyadý , kim tarafýndan ve hangi tarihte silindiði baþka bir tabloya kayýt edilsin .Bir nevi log tablosu misali

create table logtablosu
(
id int primary key identity(1,1),
rapor nvarchar(max)

)


create trigger triggerpersonel
on 
personel
after  delete
as
declare @adi nvarchar(max),@soyadi nvarchar(max)
select @adi=isim,@soyadi=soyisim from deleted
insert into logtablosu values('adý ve Soyadý '+@adi+' '+@soyadi +'olan personel'+ SUSER_NAME()+'tarafýndan '+cast(getdate() as nvarchar)+'tarihinde silinmiþtir')
delete from personel where id=11


--Örnek 4 
--personeller tablosunda bir kayýt update gerçekleþtiðinde  devreye giren ve log tablosuna  "Adý....olan personel  .... yeni adýyla deðiþtirilerek ...kullanýcý tarafýndan ... tarihinde güncllendi.kalýbýnda yazan trigger

create trigger triggerpersonelrapor
on 
personel
after  update
as
declare @adi nvarchar(max),@eskiadi nvarchar(max)
select @eskiadi=isim from deleted
select @adi=isim from inserted
insert into logtablosu values('adý '+@eskiadi +'olan personel'+@adi+'yeni adýyla deðiþtirilerek'+ SUSER_NAME()+'tarafýndan '+cast(getdate() as nvarchar)+'tarihinde güncellenmiþtir')

update personel set isim='ramazan' where id=1



---Multiple Actions Trigger


create trigger multitrigger
on 
personel
after delete,insert
as
print 'merhaba'

insert into personel (isim,soyisim) values('semra','þen')
delete personel where id=2




create table testtrigger
(id int primary key identity(1,1),
mesaj nvarchar(50)

)
--trigger
create trigger insert_update_delete_triggeri
on testtrigger
for insert,update,delete
as
begin
declare @inserted int,@deleted int,@updatestatus int
if exists (select * from deleted)
set @deleted=1
else
set @deleted=0
if exists (select * from inserted)
set @inserted=1
else
set @inserted=0
if @deleted=1 and @inserted=1
set @updatestatus=0--güncelleme
else if @deleted=0 and @inserted=1
set @updatestatus=1--ekleme
else if @deleted=1	 and @inserted=0
set @updatestatus=2--silme
else set @updatestatus=-1 --bilinmiyor


if @updatestatus=0
begin 
print 'bu bir update iþlemi'
end

else if @updatestatus=1
begin 
print 'bu bir insert iþlemi'
end
else if @updatestatus=2
begin 
print 'bu bir delete iþlemi'
end
else 
begin 
print 'bu iþlem bilinmiyor'
end
end
insert into testtrigger(mesaj) values('merhaba')
