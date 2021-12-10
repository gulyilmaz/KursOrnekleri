-- Inner Join : İki veya daha fazla tabloyu birlestirir. 

-- select * from tablo_1 inner join tablo_2 on tablo1.kolonadi = tablo2.kolonadi

select * from Person.Person
select * from HumanResources.Employee

-- inner join kullanımı 

select 
PP.BusinessEntityID,
PP.FirstName,
PP.LastName,
PP.PersonType,
HRE.BirthDate,
HRE.JobTitle,
HRE.MaritalStatus
from Person.Person as PP
inner join HumanResources.Employee HRE
on PP.BusinessEntityID = HRE.BusinessEntityID