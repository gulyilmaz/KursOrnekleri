create table ornek1(
kolon1 int,
kolon2 nvarchar(10)

)
insert into ornek1 values(5,'g�l y�lmaz')
use 
sqlfull
---NOT null kolon bo� olamaz
create table ornek2(
Id int not null,
isim nvarchar(10),
soyad nvarchar(20) not null

)
insert into ornek2(Id,isim) values(1,'can')
insert into ornek2 (isim)values('can')---id bo� ge�ez hatas�

---unique

create table ornek3(
Id int not null unique,
isim nvarchar(50),
soyisim nvarchar(50),
email nvarchar(50) unique
--burda 2 kere nul geelmez bunu da g�ster
)
insert into ornek3(Id,isim) values(1,'can')
insert into ornek3(Id,isim) values(1,'can')


--primary Key

create table ornek4(
Id int primary key,---not null ve unique
isim nvarchar(20),
soyisim nvarchar(30),
yas int
)-- columns g�r�nt�y� g�ster otomat�ikman bo� ge�ilemez yapt�
--ayn�s�ndann 2 kere giremez

insert into ornek4 (Id,isim,soyisim,yas) values(1,'g�l','y�lmaz',28)
insert into ornek4 (Id,isim,soyisim,yas) values(1,'g�l','y�lmaz',28)


---check constraint mant�ksal k�s�tlama
create table ornek5(
Id int primary key,
isim nvarchar(20),
soyisim nvarchar(30),
yas int check(yas>10)  --ya��m 10dan b�y�kse verileri girsin
)
insert into ornek5(Id,isim,soyisim,yas) values(1,'g�l','y�lmaz',28)
insert into ornek5(Id,isim,soyisim,yas) values(2,'ali','y�lmaz',10)--hata verir


--default  bi�ey girilmezse otomatik verilmesini istedi�im de�er
create table persons(
Id int primary key,
Lastname nvarchar(255),
Firstname nvarchar(255),
Age int ,
olusturmatarihi datetime default getdate(),
City nvarchar(255) default '�stanbul'
)
insert into persons(Id,Firstname,Lastname,Age,City) values (1,'john','Smith',50,'adana')
select * from persons
insert into persons(Id,Firstname,Lastname,Age) values (2,'Jule','Smith',50)



---primary-fore�gn key ile tablolar� ba�lama
create table musteri
(
id int primary key,
musteriNumara int,
tckn nvarchar(15),
vkn nvarchar(15),
isim nvarchar(50),
soyisim nvarchar(50),
olusturmaTarih datetime
)

create table musteriIletisimBilgileri
(
id int primary key ,
musteriId int,--olmayan m�steri id ile dene hata versin
iletisimTip int, -- 1 : Gsm / 2 : Ac�k adres / 3 : Sabit Telefon ... 
deger nvarchar(500),
olusturmaTarih datetime,
foreign key (musteriId) references musteri(id)
)



create table musteri(
Id int primary key,

isim nvarchar(20),
soyisim nvarchar(30),
yas int
)
create table musteri_iletisim(
Id int,
Telefon1 nvarchar(12),
Telefon2 nvarchar(12),
foreign key(Id) references musteri(ID)--referans alarak ba�lam�� oldum
)
insert into musteri (Id,isim,soyisim,yas) values(1,'g�l','y�lmaz',28)
insert into musteri (Id,isim,soyisim,yas) values(2,'can','mutlu',24)

insert into musteri_iletisim(Id,Telefon1,Telefon2) values (1,'2123333333','2125635405')

select *from musteri
select * from musteri_iletisim
--diyagramda ba�l� oldu�unu g�ster bir �d n�n birden �ok m�steri ileti�im tablosu olabilir
delete musteri where �d='2'-- bu �al���r ba�l� kayd� yok
delete musteri where �d='1' --ilk �nce fore�gn key ile ba�l� oldu�u yeri silmem laz�m


delete musteri_iletisim where �d='1'



