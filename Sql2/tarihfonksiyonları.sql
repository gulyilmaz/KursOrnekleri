--tarih fonksiyonlar�

--datediff ba�lang�� ve biti� de�eri bildirilen tarihler aras�ndaki fark� sunar
--kullan�m� datediff(tarihi ifade eden k�saltma,ba�lang��,biti�)


use Northwind
--�al��anlar�m�z�n ka� ya��nda olduklar�n� bulmak istiyoruz y�l ay ve g�n bilgisini edinmemiz gerekiyor(employee)

select concat( e.FirstName,space(1),Lastname), datediff(yy, e.BirthDate,GETDATE()) yil,
 datediff(mm, e.BirthDate,GETDATE()) ay,
  datediff(dd, e.BirthDate,GETDATE()) g�n

from Employees e

----datepart kendisine sunulan de�erin bir k�sm�n� d�nd�r�r g�n ay y�l
select datepart(yy,getdate())
--sipari�(orders) tarihlerini g�n ay y�l olrak g�r�nt�le


--dateadd 

--dateadd(eklencek tarihi ifade eden k�saltma,eklencek say�,tarih)

select dateadd(dd,5,getdate())

---sipari� tarihine 17 y�l ekle


--datename sunulan tarihin ad bilgisini verir
select datename(yy,getdate())
select datename(mm,getdate())
select datename(dd,getdate())
select datename(w,getdate())


--datefromparts
--parametre olarak g�n ay y�l� alarak tarih olu�turur
select datefromparts(2021,10,26)


--eomonth (ay sonu)
--sunulan tarihin ay cinsinden son g�n�n� verir
select eomonth('2021.12.13')


--tarih format�n� ge�ici olarak de�i�tirme
set dateformat dmy --g�n ay  y�l
select DATEDIFF(day,'27.05.2021','27.12.2021')