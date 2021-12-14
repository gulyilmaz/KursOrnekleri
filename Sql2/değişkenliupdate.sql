select * from Employees 
where TitleOfCourtesy='Dr.'
declare @titleOfCour nvarchar(25)
set @titleOfCour='Bay'
update  Employees
set TitleOfCourtesy='Mr.'
where TitleOfCourtesy=@titleOfCour

