
-----Ödev------------------
select * from Production.Product
select * from Production.ProductSubcategory
select * from Production.ProductCategory

-- ProductId 
-- Name 
-- Color 
-- CategoryName
-- CategorySubName
-- ListPrice 

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
on PSC.ProductCategoryID = PC.ProductCategoryID



