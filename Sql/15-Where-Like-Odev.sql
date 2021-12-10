-- Like ile ilgili ödevler ... 

select * from HumanResources.Employee
-- HumanResource.Employee tablosunda , 
-- NationalIDNumber kolonunun içerisinde 96 geçen 
-- JobTitle değeri Research ile başlayan 
-- Cinsiyeti ( Gender ) M olan 
-- Çalışanların listesini getirin. 


select * from HumanResources.Employee
where 
NationalIDNumber like '%96%' and
JobTitle like 'Research%' and 
Gender = 'M'



select * from Sales.SalesOrderDetail
-- ProductID değeri 100 den buyuk ve 1000 den kucuk olan 
-- CarrierTrackingNumber kolonunun son iki değeri AE olan 
-- Satış detaylarını listeleyiniz 

select * from Sales.SalesOrderDetail
where 
ProductID > 100 and ProductID <1000 and
CarrierTrackingNumber like '%AE' 

