-- Where kriteri ile öğrenmiş olduğumuz konuları kapsayan ödevler 

select * from Production.Product

-- Renk değeri Black veya Yellow olan kayıtların ilk 10 tanesini gösteren sql sorgusunu yazın. 

select top 10 * from Production.Product
where 
Color = 'Black' or Color = 'Yellow'

select  * from Production.Product
where 
Color = 'Black' or Color = 'Yellow'

-- Renk değeri multi olan  kayıtların ve standartCost değeri 6 dan büyük olanlarının productID, Color, Name ve ProductNumber değerlerini birleştirerek getirin. 

select ProductID,Color,Name + ' - ' + ProductNumber as [Name ProductNumber] from Production.Product
where 
Color = 'Multi' and StandardCost > 6

-- List price değeri 0 dan buyuk olan kayıtların toplam adedinin %10 oranına denk gelen kayıtları getirin. 

select top 50 percent * from Production.Product
where 
ListPrice > 0
