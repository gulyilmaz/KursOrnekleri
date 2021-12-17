--Triggers (Tetikleyiciler)
---Dml Trihgger
--Bir tabloda insert,update ve delete i�lemleri ger�ekle�ti�inde devreye giren yap�lard�r.Bu i�lemler sonucunda veya s�recinde devreye girerler
---DDl Trigger
--Create,Alte ve Drop islemleri sonucunda veya s�recinde devreye girecek olan yap�lar


---Inserted Table: E�er bir tabloda insert i�lemi yap�l�yorsa arka planda ilk �nce ram de olu�turan inserted isimli bir tablo �zerinde i�lem yap�l�r.E�er i�lemde bir problem yoksa inserted tablosundaki veriler fiziksel tabloya insert edilir.��lem bitti�inde Ram de olu�turalan bu tablo silinir

---Deleted Table: E�er bir tabloda delete i�lemi yap�l�yorsa arka planda ilk �nce ram de olu�turan deleted isimli bir tablo �zerinde i�lem yap�l�r.E�er i�lemde bir problem yoksa deleted tablosundaki veriler fiziksel tablodan silinir.��lem bitti�inde Ram de olu�turalan bu tablo silinir



--E�er bir tabloda update i�lemi yap�l�yorsa Ramde updated isimli bir tablo OLU�TURMAZ!!
--Sql deki update mant���nda  �nce silme sonra ekleme dir
--E�er bir update i�lemi yap�l�yorsa hem deleted hem inserted tablolar� olu�turulur ve i�lemler bunlar �zerinde yap�l�r.



--NOT:Update yap�l�rken g�ncellenen kayd�n orjinali deleted tablosunda ,g�ncellendikten sonraki hali ise inserted tablosunda tutulur.��nk� g�ncelleme demejk �nce silmek sonra eklemek demektir.
--Deleted ve inserted tablolar� ilgili sorgu sonucuolu�tuklar� i�in o sorgunun kulland��� kolonlara da sahip olur.B�ylece deleted ve inserted tablolar�ndan select sorgusu yapmak m�mk�nd�r


---Trigger Tan�mlama

--Create trigger triggerAd�
--on i�lem yap�lacak tablo ad�
--after -- veya for delete,update,insert
--as
--kodlar

--tan�mlanan triggerlara ilgili tablonun triggers alan�ndan ula��l�r
use sqlfull
create trigger ornektrigger
on personel
after insert
as
Select* from personel


insert into personel(isim,soyisim) values('b��ra','duran')


--�rnek1
--�r�nlerr tablosundan bir veri silindi�inde t�m �r�nlerin fiyat� otomatik olarak 10 arts�n
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

---�rnek 2
--�r�nler tablosunda bir veri g�ncellendi�inde ,kategoriler tablosunda 'meyve kokteyli ad�nda bir alan olu��sun
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


--�rnek 3
--personeller tablosunda bir kay�t silindi�inde silinen kayd�n ad� ,soyad� , kim taraf�ndan ve hangi tarihte silindi�i ba�ka bir tabloya kay�t edilsin .Bir nevi log tablosu misali

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
insert into logtablosu values('ad� ve Soyad� '+@adi+' '+@soyadi +'olan personel'+ SUSER_NAME()+'taraf�ndan '+cast(getdate() as nvarchar)+'tarihinde silinmi�tir')
delete from personel where id=11


--�rnek 4 
--personeller tablosunda bir kay�t update ger�ekle�ti�inde  devreye giren ve log tablosuna  "Ad�....olan personel  .... yeni ad�yla de�i�tirilerek ...kullan�c� taraf�ndan ... tarihinde g�ncllendi.kal�b�nda yazan trigger

create trigger triggerpersonelrapor
on 
personel
after  update
as
declare @adi nvarchar(max),@eskiadi nvarchar(max)
select @eskiadi=isim from deleted
select @adi=isim from inserted
insert into logtablosu values('ad� '+@eskiadi +'olan personel'+@adi+'yeni ad�yla de�i�tirilerek'+ SUSER_NAME()+'taraf�ndan '+cast(getdate() as nvarchar)+'tarihinde g�ncellenmi�tir')

update personel set isim='ramazan' where id=1



---Multiple Actions Trigger


create trigger multitrigger
on 
personel
after delete,insert
as
print 'merhaba'

insert into personel (isim,soyisim) values('semra','�en')
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
set @updatestatus=0--g�ncelleme
else if @deleted=0 and @inserted=1
set @updatestatus=1--ekleme
else if @deleted=1	 and @inserted=0
set @updatestatus=2--silme
else set @updatestatus=-1 --bilinmiyor


if @updatestatus=0
begin 
print 'bu bir update i�lemi'
end

else if @updatestatus=1
begin 
print 'bu bir insert i�lemi'
end
else if @updatestatus=2
begin 
print 'bu bir delete i�lemi'
end
else 
begin 
print 'bu i�lem bilinmiyor'
end
end
insert into testtrigger(mesaj) values('merhaba')
