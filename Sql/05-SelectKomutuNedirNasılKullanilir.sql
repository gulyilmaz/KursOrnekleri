use AdventureWorks2017 -- DB kullanımı için TSQL kısmında Use komutunu kullanabiliriz. 

-- Select : Tablolarımızın içerisindeki datalara ulaşmamızı sağlayan komut 
-- select kolonlarımızın isimleri / * from tablo_adı 

select * from Person.Person -- tablonun içerisinde bulunan tüm kolonları bize getirir. 

select 
BusinessEntityID,
PersonType,
FirstName,
LastName
from Person.Person

-- Ödev : Production.Product 

-- Name
-- ProduuctNumber
-- Color 
-- ProductID 

select Name,ProductNumber,Color,ProductID from Production.Product



------------------------------------------------
--Kolonları yeniden isimlendirmek
select Title,FirstName,LastName from Person.Person
---birleştirp getirmek istersem
select Title,FirstName+' ' +LastName as fullname from Person.Person
----as kullanmadan da yapabilirim
select Title başlık from Person.Person

---Kolon isimi verirken de boşluktan yararlanmak istiyorum
select Title,FirstName+' ' +LastName as [Ad Soyad] from Person.Person



---------Top Kullanımı
select top 10  * from Person.Person----ilk 10 kaydı getirir

--Örnek ilk 10 kaydın ad soyadını birleştir getir kolon adı ad soyad olsun



-------
select top 10 percent  * from Person.Person----toplam kaydın %10 u



