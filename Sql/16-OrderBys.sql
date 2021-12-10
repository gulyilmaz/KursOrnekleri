-- Order by 

select * from Production.Product
where 
ProductNumber like '%20%'
order by ProductID 

-- A-Z : asc * opsiyonel default olarak zaten a-z ye dogru sıralar
-- Z-A : desc
