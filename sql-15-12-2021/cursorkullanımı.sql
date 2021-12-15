--Sql server cursor kullnýmý
--imleç demektir
--cursorlar bir veri grubu üzerinde satýr satýr iþlem yapabilmeye olanak saðlayan yapýlardýr
--kayýtlara satýr satýr eriþebilmeye olanak saðlar


declare @kategoriad nvarchar(100)
declare cursor_yapýsý cursor for select CategoryName from Categories
open cursor_yapýsý
fetch next from cursor_yapýsý into @kategoriad
while @@FETCH_STATUS=0
begin 
print @kategoriad
fetch next from cursor_yapýsý into @kategoriad
end
close cursor_yapýsý
deallocate cursor_yapýsý


---employee tablosunu ad soyad olarak yazýdrýn



-----Sql SErverda cursor ile baraber prosedür kullanýmý
create proc urunadgetrime
(@categoryid int)
as
begin
declare @urunad nvarchar(100)
declare crs cursor for select ProductName from Products where CategoryID=@categoryid
open crs
fetch next from crs into @urunad
while @@FETCH_STATUS=0
begin
print @urunad
fetch next from crs
into @urunad
end
close crs
deallocate crs

end
 exec urunadgetrime 1