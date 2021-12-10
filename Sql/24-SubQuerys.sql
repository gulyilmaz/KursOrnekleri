
select PP.BusinessEntityID,PP.FirstName,PP.LastName, HE.BirthDate,HE.MaritalStatus from 
Person.Person PP inner join 
HumanResources.Employee HE
on PP.BusinessEntityID = HE.BusinessEntityID


select 
BusinessEntityID,
FirstName,
LastName,
(select BirthDate from HumanResources.Employee where BusinessEntityID = Person.BusinessEntityID) as BirthDate,
(select MaritalStatus from HumanResources.Employee where BusinessEntityID = Person.BusinessEntityID) as MS
from person.Person

select * from 
(select * from Person.Person) as Personeller
