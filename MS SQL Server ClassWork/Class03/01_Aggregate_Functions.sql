	-- Count


	select Count(*) from Customers


	select Count (Id) as TotalNumberOfOrders
	from Orders

	select Count (Comment) as TotalNumberOfComments
	from Orders


	--Sum

	select sum([TotalPrice]) as TotalPrice from Orders


	-- MIN and MAX



	select min(TotalPrice) as MinOrer
	from Orders

	select max(TotalPrice) as MAxOrer
	from Orders


	select be.Name, max(o.TotalPrice)
	from BusinessEntities be
	inner jon Orders o
	on be.Id = o.BusinessEntityId


	--AVG

	select AVG(Distinct Quantity) As AverageQuantity
	from OrderDetails

	-- string agg
	select STRING_AGG(Name, ', ') as AllCoustomers
	from [dbo].[Customers]

