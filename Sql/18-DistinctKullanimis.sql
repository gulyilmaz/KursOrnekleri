use AdventureWorks2017
Go 
----tekrar eden de�erleri teke indirir �nce distinctsiz bak
select distinct Color from Production.Product


select ProductID,ProductNumber,Name,Color from Production.Product
where 
ProductID in 
(---�nce bu
select distinct ProductID from Sales.SalesOrderDetail
)

select Color,Sum(ListPrice) from Production.Product
where 
ProductID in 
(
select distinct ProductID from Sales.SalesOrderDetail
)
group by Color