-- Left Join 
----Sol tablonun hepsi gelir saðdaki deðerleri olmayan kayýtlar null olarak gelir
select PP.BusinessEntityID,PP.FirstName,PP.LastName,HE.*
from 
Person.Person PP left join 
HumanResources.Employee HE
on PP.BusinessEntityID = HE.BusinessEntityID
--yukardakinin saðlamasý
select * from HumanResources.Employee
where BusinessEntityID  = 293
---iste
select * from Production.Product
select * from Sales.SalesOrderDetail
---Tabloyu incele  productiondan bir kaç kolon salestan tüm kolonlarý getir


select 
PP.Name,
PP.ProductID,
PP.Color,
SOD.*
from Production.Product PP left join 
Sales.SalesOrderDetail SOD on 
PP.ProductID = SOD.ProductID


--satýlan ürünlerin renklerine göre toplamý
select 
PP.Color,
Sum(SOD.UnitPrice)
from Production.Product PP left join 
Sales.SalesOrderDetail SOD on 
PP.ProductID = SOD.ProductID
group by PP.Color