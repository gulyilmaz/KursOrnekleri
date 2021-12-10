---full Join
select * from Person.Person
select * from Sales.SalesPerson

select * from Person.Person full join sales.SalesPerson on Person.BusinessEntityID =SalesPerson.BusinessEntityID


select * from Production.Product
select * from Production.ProductSubcategory
select * from Production.ProductCategory
--- category ve subcategory isimlerine göre bir groupby ürünlerin ilgili kategorilerde kaç adet oldðunu
--bul ve bu toplam adetlerin toplam fiyat
-- ProductId 
-- Name 
-- Color 
-- CategoryName
-- CategorySubName
-- ListPrice 
use AdventureWorks2019
select 
ProductCategoryName,
ProductSubCategoryName,
count(ProductId) ProductCount,
Sum(ListPrice) as ProductListPriceSum
from 
(
select
PP.ProductID,
PP.Name ProductName,
PP.Color ProductColor,
PC.Name ProductCategoryName,
PSC.Name ProductSubCategoryName,
PP.ListPrice
from 
Production.Product PP
left join Production.ProductSubcategory PSC
on PP.ProductSubcategoryID = PSC.ProductSubcategoryID
left join Production.ProductCategory PC 
on PSC.ProductCategoryID = PC.ProductCategoryID) ResultTable
group by 
ProductCategoryName,
ProductSubCategoryName
having 
ProductCategoryName is not null