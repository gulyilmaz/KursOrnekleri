--Sql server cursor kulln�m�
--imle� demektir
--cursorlar bir veri grubu �zerinde sat�r sat�r i�lem yapabilmeye olanak sa�layan yap�lard�r
--kay�tlara sat�r sat�r eri�ebilmeye olanak sa�lar


declare @kategoriad nvarchar(100)
declare cursor_yap�s� cursor for select CategoryName from Categories
open cursor_yap�s�
fetch next from cursor_yap�s� into @kategoriad
while @@FETCH_STATUS=0
begin 
print @kategoriad
fetch next from cursor_yap�s� into @kategoriad
end
close cursor_yap�s�
deallocate cursor_yap�s�


---employee tablosunu ad soyad olarak yaz�dr�n



-----Sql SErverda cursor ile baraber prosed�r kullan�m�
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