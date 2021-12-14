--tarih fonksiyonlarý

--datediff baþlangýç ve bitiþ deðeri bildirilen tarihler arasýndaki farký sunar
--kullanýmý datediff(tarihi ifade eden kýsaltma,baþlangýç,bitiþ)


use Northwind
--çalýþanlarýmýzýn kaç yaþýnda olduklarýný bulmak istiyoruz yýl ay ve gün bilgisini edinmemiz gerekiyor(employee)

select concat( e.FirstName,space(1),Lastname), datediff(yy, e.BirthDate,GETDATE()) yil,
 datediff(mm, e.BirthDate,GETDATE()) ay,
  datediff(dd, e.BirthDate,GETDATE()) gün

from Employees e

----datepart kendisine sunulan deðerin bir kýsmýný döndürür gün ay yýl
select datepart(yy,getdate())
--sipariþ(orders) tarihlerini gün ay yýl olrak görüntüle


--dateadd 

--dateadd(eklencek tarihi ifade eden kýsaltma,eklencek sayý,tarih)

select dateadd(dd,5,getdate())

---sipariþ tarihine 17 yýl ekle


--datename sunulan tarihin ad bilgisini verir
select datename(yy,getdate())
select datename(mm,getdate())
select datename(dd,getdate())
select datename(w,getdate())


--datefromparts
--parametre olarak gün ay yýlý alarak tarih oluþturur
select datefromparts(2021,10,26)


--eomonth (ay sonu)
--sunulan tarihin ay cinsinden son gününü verir
select eomonth('2021.12.13')


--tarih formatýný geçici olarak deðiþtirme
set dateformat dmy --gün ay  yýl
select DATEDIFF(day,'27.05.2021','27.12.2021')