---self Join
-- join kullanmadan tablolarý birleþtirmek


select Orders.OrderID,CompanyName from Orders inner join Customers on orders.CustomerID=Customers.CustomerID

select  Orders.OrderID,CompanyName from Orders,Customers where Orders.CustomerID=Customers.CustomerID order by
OrderID


---union --union all

select City from Customers
select City from Suppliers


select City from Customers
union -- ayný þehir varsasadece birini gösterir
select City from Suppliers

select City from Customers
union all
select City from Suppliers order by city


---cross join

select * from Categories cross join Employees
