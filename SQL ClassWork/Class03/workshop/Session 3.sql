Create or ALTER VIEW vv_CustomerOrder
As
select c.Id, c.Name, sum(o.TotalPrice) as TotalOrderCount
from Orders o
join Customers c on o.[CustomerId] = c.Id
group by c.Id, c.Name
go

select * from vv_CustomerOrder
order by TotalOrderCount desc


CREATE or ALTER VIEW vv_EmployeeOrders
as 
select e.FirstName + ' ' + e.LastName as Employee, p.Name as ProductName, sum(od.Quantity) as TotalQuantity
from Orders o
join Employees e on e.Id = o.EmployeeId
join OrderDetails od on od.OrderId = o.Id
join Products p on p.Id = od.ProductId
join BusinessEntities be on be.Id = o.BusinessEntityId
where be.Region = 'Skopski'
group by e.FirstName + ' ' + e.LastName , p.Name
go

select * from vv_EmployeeOrders