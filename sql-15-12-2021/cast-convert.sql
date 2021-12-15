--Sql de tip �evrim i�lemleri

--convert string bir veri ile say�sal veya tarih tipinde bir veriyi birle�tirirken kullan�l�r.Tip �evrimi yapar ve de�erin stilini de�i�tirir
---�r�n kategorilerini categori �d de�eri ile brlikte listelemek

select CategoryName+CategoryID from categories
select convert(nvarchar(1),CategoryID)+space(1)+ CategoryName from categories

select
CONVERT(VARCHAR, GETDATE(),103) F103, --tarih tipi�evrimlerine g�re say�lar dd/mm/yy
CONVERT(VARCHAR, GETDATE(),104) F104,--dd.mm.yy
CONVERT(VARCHAR, GETDATE(),105) F105--dd-mm-yy

---employee tablosundaki tarih verisini convert etmek
Select E.FirstName + ' ' + E.LastName AdSoyad,
CONVERT(varchar(10),E.BirthDate,104) DogumTarihi
From Employees E---g�n.ay.y�l

--cast fonksyonu
--T�r d�n���m� i�in kullan�lan fonksiyondur.De�erin stilini de�i�tirmez
--cast(�evrilecek veri as tipi)

select cast('10' as int)*10 --say�sal tipe d�n��t�rd�

--employes tablosundaki tarih verisini cast etmek
Select E.FirstName+' '+E.LastName+' ' +
Cast(Year(E.BirthDate) as NvarChar(4))+' do�umludur'
AS CalisanDogumTarihleri
From Employees E 
Order By E.BirthDate
