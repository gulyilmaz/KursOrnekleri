---Metinsel Fonksiyonlar
--Upper &Lower
select * from HumanResources.Employee

select LoginID,
upper(LoginID) as BuyukHarf,
lower(JobTitle) as KucukHarf,
lower(upper(LoginID)) icice


from HumanResources.Employee

use AdventureWorks2019

---Concat -- Len--karakter uzunluðu
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
---Kargo firmalarýnýn alan kodu ayrý telefon numarasý ayrý olarak listelenmesini nasýl saðlarýz
select substring(Phone,1,5) [alan kodu] ,substring(Phone,6,len(Phone)) as telefon ,Phone from  Shippers

---Right --Left


select name, 
right(name,3),
left(name,3)
from Production.Product
 

 ---rtrim - ltrim saðýndaki solundaki boþluklarý kaldýrýr



 ---replace 
 --deðiþtrilmek istenen veri,eski veri, eski verirnin yerine geçecek olan veri

 ---ülke bilgisnde usa kelimesini amerika olarak deðiþtiren ve tekrarlanmayan veri sunmak (employee)

 select distinct(replace( Country,'usa','amerika')),Country from Employees
 select *from Employees

