-- Foreign Key 

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
musteriId int,
iletisimTip int, -- 1 : Gsm / 2 : Acık adres / 3 : Sabit Telefon ... 
deger nvarchar(500),
olusturmaTarih datetime,
foreign key (musteriId) references musteri(id)
)