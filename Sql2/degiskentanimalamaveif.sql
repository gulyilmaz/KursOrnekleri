---declare : Yeni bir de�i�ken olu�turma isimlendirme declare komutu kullan�l�r
--Genel yaz�m

--declare @degiskenad� nvarchar(10)
-- set @degiskenad�='g�l'

declare @tamisim nvarchar(30)
set @tamisim='g�l y�lmaz'
print @tamisim

declare @tamisim2 nvarchar(30)
set @tamisim2='selin mu�tu'
print @tamisim2

declare @toplamkayitsayisi int 
use AdventureWorks2019
select @toplamkayitsayisi=count(*) from Production.Product
print @toplamkayitsayisi



----if �art ve �artlar�m�z
--begin tsql kodlar�
--end
--else
--begin
--tsql kodlar�
--end

declare @kullaniciadi nvarchar(20),@sifre nvarchar(20)
set @kullaniciadi='demo'
set @sifre='demo'
if @kullaniciadi='demo' and @sifre='demo'
begin
print 'kullan�c� giri�i ba�ar�l�'
end
else 
begin 
print 'kullan�c� giri� ba�ar�s�z'
end


declare @toplamkayitsayisi1 int
select @toplamkayitsayisi1=count(*) from Production.Product
if @toplamkayitsayisi1<=100
begin 
print 'toplam say� 100 den k���k'
end
else if @toplamkayitsayisi1<=100 and @toplamkayitsayisi1<=200
begin 
print 'toplam say�s� 100 ile 200 aras�ndad�r'
end
else
begin
print 'toplam say� 200 den b�y�k'
end


