----Say�sal Fonksiyonlar

---min(kolonAd�)

---max(kolonAd�)

select color,max(SafetyStockLevel) eny�ksek,
min(SafetyStockLevel) endusuk
from Production.Product
group by color
having color is not null

------Count

select count(*) from Production.Product

select count(0) from HumanResources.Employee
where
LoginID='adventure-works\ken0' and NationalIDNumber='295847284'

select color,count(*) from Production.Product where color is not null
group by color


----Sum &&AvG

select sum(SafetyStockLevel) from Production.Product

select * from Sales.SalesOrderHeader
select* from Person.Person

select * from Sales.SalesOrderDetail


-- bu tarihte sat�� yapanlar�n ismi

select concat (pp.FirstName,' ',LastName) from Sales.SalesOrderHeader SSOH 
--inner join Sales.SalesOrderDetail SSOD on 
--SSOH.SalesOrderID=SSOD.SalesOrderID
inner join Person.Person pp on pp.BusinessEntityID=SSOH.SalesPersonID
where SSOh.OrderDate='2011-05-31 00:00:00.000' --bu tarihte

---yapt�klar� sat��
select ssod.LineTotal as Toplam,concat (pp.FirstName,' ',LastName) from Sales.SalesOrderHeader SSOH 
inner join Person.Person pp on pp.BusinessEntityID=SSOH.SalesPersonID
inner join Sales.SalesOrderDetail SSOD on 
SSOH.SalesOrderID=SSOD.SalesOrderID
where SSOh.OrderDate='2011-05-31 00:00:00.000' 

--yapt�klar� toplam sat��

select sum( ssod.LineTotal) as Toplam,concat (pp.FirstName,' ',LastName) sat�syapankisi from Sales.SalesOrderHeader SSOH 
inner join Person.Person pp on pp.BusinessEntityID=SSOH.SalesPersonID
inner join Sales.SalesOrderDetail SSOD on 
SSOH.SalesOrderID=SSOD.SalesOrderID
where SSOh.OrderDate='2011-05-31 00:00:00.000' 
group by concat (pp.FirstName,' ',LastName)
---avg
select avg(SafetyStockLevel) from Production.Product


select sum( ssod.LineTotal) as Toplam,concat (pp.FirstName,' ',LastName) sat�syapankisi,
avg(SSOD.LineTotal) ortalama
from Sales.SalesOrderHeader SSOH 
inner join Person.Person pp on pp.BusinessEntityID=SSOH.SalesPersonID
inner join Sales.SalesOrderDetail SSOD on 
SSOH.SalesOrderID=SSOD.SalesOrderID
where SSOh.OrderDate='2011-05-31 00:00:00.000' 
group by concat (pp.FirstName,' ',LastName)