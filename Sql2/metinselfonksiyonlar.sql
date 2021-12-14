---Metinsel Fonksiyonlar
--Upper &Lower
select * from HumanResources.Employee

select LoginID,
upper(LoginID) as BuyukHarf,
lower(JobTitle) as KucukHarf,
lower(upper(LoginID)) icice


from HumanResources.Employee

use AdventureWorks2019

---Concat -- Len--karakter uzunlu�u
select FirstName + ' '+ LastName  [isim Soyisim],
CONCAT(FirstName,' ',LastName) isimsoyisim,
concat(FirstName,space(1),LastName) isimSoyisim,
len(FirstName)
from Person.Person


---Substring
select name, SUBSTRING(name,1,3),
concat(upper(substring(name,1,3)),substring(name,4,len(name))) sifre
from Production.Product
use Northwind
---Kargo firmalar�n�n alan kodu ayr� telefon numaras� ayr� olarak listelenmesini nas�l sa�lar�z
select substring(Phone,1,5) [alan kodu] ,substring(Phone,6,len(Phone)) as telefon ,Phone from  Shippers

---Right --Left


select name, 
right(name,3),
left(name,3)
from Production.Product
 

 ---rtrim - ltrim sa��ndaki solundaki bo�luklar� kald�r�r



 ---replace 
 --de�i�trilmek istenen veri,eski veri, eski verirnin yerine ge�ecek olan veri

 ---�lke bilgisnde usa kelimesini amerika olarak de�i�tiren ve tekrarlanmayan veri sunmak (employee)

 select distinct(replace( Country,'usa','amerika')),Country from Employees
 select *from Employees

