--Sql de tip çevrim iþlemleri

--convert string bir veri ile sayýsal veya tarih tipinde bir veriyi birleþtirirken kullanýlýr.Tip çevrimi yapar ve deðerin stilini deðiþtirir
---ürün kategorilerini categori ýd deðeri ile brlikte listelemek

select CategoryName+CategoryID from categories
select convert(nvarchar(1),CategoryID)+space(1)+ CategoryName from categories

select
CONVERT(VARCHAR, GETDATE(),103) F103, --tarih tipiçevrimlerine göre sayýlar dd/mm/yy
CONVERT(VARCHAR, GETDATE(),104) F104,--dd.mm.yy
CONVERT(VARCHAR, GETDATE(),105) F105--dd-mm-yy

---employee tablosundaki tarih verisini convert etmek
Select E.FirstName + ' ' + E.LastName AdSoyad,
CONVERT(varchar(10),E.BirthDate,104) DogumTarihi
From Employees E---gün.ay.yýl

--cast fonksyonu
--Tür dönüþümü için kullanýlan fonksiyondur.Deðerin stilini deðiþtirmez
--cast(çevrilecek veri as tipi)

select cast('10' as int)*10 --sayýsal tipe dönüþtürdü

--employes tablosundaki tarih verisini cast etmek
Select E.FirstName+' '+E.LastName+' ' +
Cast(Year(E.BirthDate) as NvarChar(4))+' doðumludur'
AS CalisanDogumTarihleri
From Employees E 
Order By E.BirthDate
