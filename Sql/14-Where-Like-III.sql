-- Like 

-- Geniş arama yapmamızı sağlar , ProductCode değeri AB ile başlayan kayıtları getir , içerisinde 1290 olan kayıtları getir , son değeri 9 olan kayıtları getir diyebiliriz. 

-- kolon like '%a' başında ne olursa olsun sonunda a olan kayıtları bana getir. 
-- kolon like 'a%' başında a ile başlayan ve devamında ne olursa olsun bana kayıtları getir. 
-- kolon like '%a%' başında ve sonunda ne olursa olsun içerisinde a harfi geçen tum kayıtları bana getir. 

-- kolon like '_a' ilk karakteri ne olursa olsun ikinci karakteri a olan kayıtları getir. 

-- like '%a' 
select ProductNumber,Name,ProductID from Production.Product
where 
ProductNumber like '%1'

-- like 'a%'

select ProductNumber,Name,ProductID from Production.Product
where 
ProductNumber like 'b%'

-- like '%R%'

select  ProductNumber,Name,ProductID from Production.Product
where 
ProductNumber like '%R%'


-- like '_a' 

select * from Production.Product
where 
ProductNumber like '_K-_64Y-40'

-- Ödev : 
