----Case when
--genel kullanýmý
---select case kolonadi
--when 'red' then 'kýrmýzý'
--when  'blue' then 'mavi'
--else 'renksiz'
--end

select distinct color from Production.Product


select  name ,(case color 
when 'black' then 'siyah'
when 'blue'then 'mavi'
when 'multi' then 'çok renkli'
when 'grey' then 'gri'
when 'silver' then 'gümüþ'
when 'silver/Black' then 'gümüþ siyah'
when 'white' then 'beyaz'
when 'yellow' then 'sarý'
else 'renk tanýmý yapýlmamýþ'
end )as renkler
from Production.Product

select* from Employees
--employee tablosunda titleofcoursty alanýnda ms yazanlara bayan mr yazanlara bay dr yazan doktor
select FirstName,
(case TitleOfCourtesy when 'ms.' then 'bayan'
when 'Mrs.' then 'bayan'
when 'Mr.' then 'bay'
when 'dr.' then 'doktor' else 'taným yok' end)


from Employees

-- ürün kategorisinin türkçe karþýlýklarý
--beverages--içecekler
--condiments--bal
--confections þekerlemeler
--dairy products süt ürünleri
--grains/cereals tahýllar
--meat/poultry et tavuk
--produce imalatýmýz
--seafood deniz ürünleri

