---Sql serverda exec kullan�m�
--Dinamik sorgular�m�zda ya da procedurelerimizde kullanabildi�imiz bir yap�
use Northwind
declare @sorgu nvarchar(200)
set @sorgu='Select * FROM PRODUCTS'
exec (@sorgu)


declare @sqlcumle nvarchar(200),
@tanim nvarchar(10)='1'
if @tanim='1'
begin 
set @sqlcumle='Select * from products where ProductID='+@tanim
exec (@sqlcumle,@tanim)
end
else
begin
set @sqlcumle='select * from products where ProductID=2'
exec (@sqlcumle)
end


--SQL Server'da sp_executesql Prosed�r� Kullan�m�

--dinamik sql sorgular�m� �al��t�rmak i�in kullan�r�m
execute sp_executesql N'select * from [dbo].[Categories]'

DECLARE @sqlcode AS NVARCHAR(256) = N'SELECT GETDATE() AS dt';
EXEC sp_executesql @statement = @sqlcode;

--SQL Server'da sp_executesql ve Exec Aras�ndaki Fark
--sp_executesql parametrik olabilirken exec paremetrik de�ildir
--sp_executesql daha performansl�d�r
--sp_executesql prosed�r� paremetre de�i��se de ayn� execition plan�n� kullanmaktad�r.Exec ise �a�r�lan her sorguda her defas�nda yeni bir execution plan� olu�turur.
DECLARE @sqlstring AS NVARCHAR(1000);
DECLARE @empid AS INT;
SET @sqlstring = N'SELECT [EmployeeID], LastName FROM [Employees]
WHERE [EmployeeID]= @empid;'
EXEC sp_executesql @statement = @sqlstring, @params=N'@empid AS INT', @empid = 5; 





select * from Categories