---between
select * from Products
where UnitPrice Between 10 and 20

---max ve min kullanýmý
select * from Products
-- as ile column name
select max(UnitPrice) as MaxFiyat from Products 
select min(UnitPrice) as MinFiyat from Products 

--distinct tekrar edenleri getirme
select Color from DimProduct
select distinct Color from DimProduct





----Ýn kullanýmý
--1 ile 5 olanlarý getir

select * from DimProduct
where ProductKey in (1,2,3,4,5)
-- IN veya Not In 

select * from Production.Product
where 
ProductNumber 
In  -- içeren kayýtlar 
(
'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908',
'BL-2036',
'CA-596225',
'CA-6738',
'CA-7457',
'CB-2903',
'CN-6137'
)

select * from Production.Product
where 
ProductNumber 
Not In  -- içermeyen kayýtlar 
(
'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908',
'BL-2036',
'CA-6738',
'CA-7457',
'CB-2903',
'CN-6137'
)
