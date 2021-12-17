---Sql serverda exec kullanýmý
--Dinamik sorgularýmýzda ya da procedurelerimizde kullanabildiðimiz bir yapý
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


--SQL Server'da sp_executesql Prosedürü Kullanýmý

--dinamik sql sorgularýmý çalýþtýrmak için kullanýrým
execute sp_executesql N'select * from [dbo].[Categories]'

DECLARE @sqlcode AS NVARCHAR(256) = N'SELECT GETDATE() AS dt';
EXEC sp_executesql @statement = @sqlcode;

--SQL Server'da sp_executesql ve Exec Arasýndaki Fark
--sp_executesql parametrik olabilirken exec paremetrik deðildir
--sp_executesql daha performanslýdýr
--sp_executesql prosedürü paremetre deðiþþse de ayný execition planýný kullanmaktadýr.Exec ise çaðrýlan her sorguda her defasýnda yeni bir execution planý oluþturur.
DECLARE @sqlstring AS NVARCHAR(1000);
DECLARE @empid AS INT;
SET @sqlstring = N'SELECT [EmployeeID], LastName FROM [Employees]
WHERE [EmployeeID]= @empid;'
EXEC sp_executesql @statement = @sqlstring, @params=N'@empid AS INT', @empid = 5; 





select * from Categories