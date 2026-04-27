-- Workshop 1 & 2

select sum(TotalPrice) as TotalPrice
from Orders
go


select be.[Name], sum(o.TotalPrice)  as TotalPricePerEntity
from Orders o
join BusinessEntities be
on o.BusinessEntityId = be.Id
group by be.Name


select be.Name, sum(o.TotalPrice)
from Orders  o
join BusinessEntities be
on o.BusinessEntityId = be.Id
where 0.CoustomerId < 20
group by be.Name

select * from Customers


select be.[Name], max(o.TotalPrice)  as MAximumTotalPrice, avg(distinct o.TotalPrice0 as TotalPriceAverage
from Orders o
join BusinessEntities be
on o.BusinessEntityId = be.Id
group by be.Name



select be.[Name], sum(o.TotalPrice)  as TotalPricePerEntity
from Orders o
join BusinessEntities be
on o.BusinessEntityId = be.Id
group by be.Name
having sum(o.TotalPrice) > 635558


select be.Name, sum(o.TotalPrice)
from Orders  o
join BusinessEntities be
on o.BusinessEntityId = be.Id
where 0.CoustomerId < 20
group by be.Name
having sum(o.TotalPrice) < 100000


select be.[Name], 
max(o.TotalPrice)  as MAximumTotalPrice,
avg(distinct o.TotalPrice0) as TotalPriceAverage
from Orders o
join BusinessEntities be
on o.BusinessEntityId = be.Id
group by be.Name
having sum(o.TotalPrice) > 4 * avg(distinct o.TotalPrice0)








