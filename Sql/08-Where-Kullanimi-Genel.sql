--where kullanımı 

select * from Person.Person

-- person tablosunda personType değeri EM olan kayıtları getir 

-- where 
-- select * from tablo_adi where sart veya sartlarımızı 

select * from Person.Person
where 
PersonType = 'EM'

-- Örnek 

select * from Person.Person
where 
FirstName = 'Ken'

-- 
select * from Production.Product

-- örnek --color kolonunda değeri black olan kayıtların name , productnumber ve color değerlerini bana getirin . 

select Name,ProductNumber,Color from Production.Product
where 
Color = 'Black'

-- Where Dersi - 2 

-- C# && -- SQL and ve operatörü 
-- C# || -- SQL  or veya operatoru 

-- and operatörü 

select * from Production.Product
where 
Color = 'Black' and SafetyStockLevel = 500 -- and operatörü ile birbirine bağlanan tüm şartlar sağlanmalı. 

 -- or operatörü 

select * from Production.Product
where 
Color = 'Black' or SafetyStockLevel = 500

-- Where Dersi - 3 

-- > büyüktür 

select * from Production.Product
where 
SafetyStockLevel > 500

-- >= büyük veya eşittir 

select * from Production.Product
where 
SafetyStockLevel >= 500


-- < küçüktür 

select * from Production.Product
where SafetyStockLevel < 500

-- <= küçük veya eşittir 

select * from Production.Product
where SafetyStockLevel <= 500


-- = eşittir 

select * from Production.Product
where 
color = 'Black' and SafetyStockLevel = 500


-- != eşit değildir. 

select * from Production.Product
where 
SafetyStockLevel != 500 or color = 'Black'


