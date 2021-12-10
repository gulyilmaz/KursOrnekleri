select * from DimProduct


select ProductAlternateKey,EnglishProductName from DimProduct


---kolon isimlerini deðiþtirmek istersem listelerken deðiþtirmek için tabloda deðiþtirmez

select ProductAlternateKey as ÜrünAnahtar,
EnglishProductName as [ingilizce ürün adý]
from DimProduct


--where kullanýmý verilerimi getirmek istediðim kriterlere göre listelemek istediðimde kullandýðým komut

select ProductAlternateKey as ÜrünAnahtar,
EnglishProductName as [ingilizce ürün adý]
from DimProduct
where ProductKey=1




select * from DimProduct
--colorlardan white ile blue getirmek istersem
select * from DimProduct where Color='Yellow' and ProductSubcategoryKey=14

select * from DimProduct where Color='Yellow' or color='Blue'


----Ýn kullanýmý
--1 ile 5 olanlarý getir

select * from DimProduct
where ProductKey in (1,2,3,4,5)



----Like kullanýmý içinde geçenleri bul
---% birden fazla bilinmeyen karakter
-----_ise tek karakteri temsil eder

select EnglishProductName from DimProduct
where EnglishProductName like '%h%'

-- not like ise bulunmayanlarý getir demek
select EnglishProductName from DimProduct
where EnglishProductName not like '%h%'

--baþýnda belli bir karakter sonunda herhangi biþey olanlarý getir
select EnglishProductName from DimProduct
where EnglishProductName  like 'l%'

--- baþýnda herhangi bir sey sonunda belli bir karakter olaný getir

select EnglishProductName from DimProduct
where EnglishProductName  like '%l'


--ilk 4 karakteri herhangi bir þey olan sonu e ile bitenleri getir

select EnglishProductName from DimProduct
where EnglishProductName like '____e'






