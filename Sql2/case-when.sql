----Case when
--genel kullan�m�
---select case kolonadi
--when 'red' then 'k�rm�z�'
--when  'blue' then 'mavi'
--else 'renksiz'
--end

select distinct color from Production.Product


select  name ,(case color 
when 'black' then 'siyah'
when 'blue'then 'mavi'
when 'multi' then '�ok renkli'
when 'grey' then 'gri'
when 'silver' then 'g�m��'
when 'silver/Black' then 'g�m�� siyah'
when 'white' then 'beyaz'
when 'yellow' then 'sar�'
else 'renk tan�m� yap�lmam��'
end )as renkler
from Production.Product

select* from Employees
--employee tablosunda titleofcoursty alan�nda ms yazanlara bayan mr yazanlara bay dr yazan doktor
select FirstName,
(case TitleOfCourtesy when 'ms.' then 'bayan'
when 'Mrs.' then 'bayan'
when 'Mr.' then 'bay'
when 'dr.' then 'doktor' else 'tan�m yok' end)


from Employees

-- �r�n kategorisinin t�rk�e kar��l�klar�
--beverages--i�ecekler
--condiments--bal
--confections �ekerlemeler
--dairy products s�t �r�nleri
--grains/cereals tah�llar
--meat/poultry et tavuk
--produce imalat�m�z
--seafood deniz �r�nleri

