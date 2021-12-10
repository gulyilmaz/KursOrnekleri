-- Group by 

select * from Production.Product
where 
Color is not null


select Color,Sum(SafetyStockLevel) as SafetyStockLevelSum ,Avg(ListPrice) ListPriceAvg from Production.Product
where color is not null
group by Color
having Color != 'Black'

--renklere göre gruplar
---grupladýðým kümelerden having ile kriter veriyorum

-- Group by Having 

select Color,Sum(SafetyStockLevel) as SafetyStockLevelSum ,Avg(ListPrice) ListPriceAvg from Production.Product
--where color is not null
group by Color
having Color is not null