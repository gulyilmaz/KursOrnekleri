select * from DimProduct


select ProductAlternateKey,EnglishProductName from DimProduct


---kolon isimlerini de�i�tirmek istersem listelerken de�i�tirmek i�in tabloda de�i�tirmez

select ProductAlternateKey as �r�nAnahtar,
EnglishProductName as [ingilizce �r�n ad�]
from DimProduct


--where kullan�m� verilerimi getirmek istedi�im kriterlere g�re listelemek istedi�imde kulland���m komut

select ProductAlternateKey as �r�nAnahtar,
EnglishProductName as [ingilizce �r�n ad�]
from DimProduct
where ProductKey=1




select * from DimProduct
--colorlardan white ile blue getirmek istersem
select * from DimProduct where Color='Yellow' and ProductSubcategoryKey=14

select * from DimProduct where Color='Yellow' or color='Blue'


----�n kullan�m�
--1 ile 5 olanlar� getir

select * from DimProduct
where ProductKey in (1,2,3,4,5)



----Like kullan�m� i�inde ge�enleri bul
---% birden fazla bilinmeyen karakter
-----_ise tek karakteri temsil eder

select EnglishProductName from DimProduct
where EnglishProductName like '%h%'

-- not like ise bulunmayanlar� getir demek
select EnglishProductName from DimProduct
where EnglishProductName not like '%h%'

--ba��nda belli bir karakter sonunda herhangi bi�ey olanlar� getir
select EnglishProductName from DimProduct
where EnglishProductName  like 'l%'

--- ba��nda herhangi bir sey sonunda belli bir karakter olan� getir

select EnglishProductName from DimProduct
where EnglishProductName  like '%l'


--ilk 4 karakteri herhangi bir �ey olan sonu e ile bitenleri getir

select EnglishProductName from DimProduct
where EnglishProductName like '____e'






