---declare : Yeni bir deðiþken oluþturma isimlendirme declare komutu kullanýlýr
--Genel yazým

--declare @degiskenadý nvarchar(10)
-- set @degiskenadý='gül'

declare @tamisim nvarchar(30)
set @tamisim='gül yýlmaz'
print @tamisim

declare @tamisim2 nvarchar(30)
set @tamisim2='selin muþtu'
print @tamisim2

declare @toplamkayitsayisi int 
use AdventureWorks2019
select @toplamkayitsayisi=count(*) from Production.Product
print @toplamkayitsayisi



----if þart ve þartlarýmýz
--begin tsql kodlarý
--end
--else
--begin
--tsql kodlarý
--end

declare @kullaniciadi nvarchar(20),@sifre nvarchar(20)
set @kullaniciadi='demo'
set @sifre='demo'
if @kullaniciadi='demo' and @sifre='demo'
begin
print 'kullanýcý giriþi baþarýlý'
end
else 
begin 
print 'kullanýcý giriþ baþarýsýz'
end


declare @toplamkayitsayisi1 int
select @toplamkayitsayisi1=count(*) from Production.Product
if @toplamkayitsayisi1<=100
begin 
print 'toplam sayý 100 den küçük'
end
else if @toplamkayitsayisi1<=100 and @toplamkayitsayisi1<=200
begin 
print 'toplam sayýsý 100 ile 200 arasýndadýr'
end
else
begin
print 'toplam sayý 200 den büyük'
end


