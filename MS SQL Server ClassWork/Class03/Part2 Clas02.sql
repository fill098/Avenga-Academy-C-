insert into [Orders] (OrderDate, Status, BusinessEntityId, CustomerId, EmployeeId, TotalPrice, Comment)
values ((select '2019-04-05' as OrderDate), 0, 100, 1, 1, 1000, 'test comment' )


delete from Orders where BusinessEntityId = 100

-- crate FK constraints 

alter table OrderDetails add constraint [FK_OrderDetails_Orders] FOREIGN Key (OrderId) REFERENCES Orders(Id)



alter table Orders add constraint [FK_Orders_BusinessEntity] FOREIGN KEY ([BusinessEntityId]) REFERENCES [BusinessEntities](Id)

alter table Orders add constraint [FK_Orders_Custuomer] FOREIGN KEY ([CustomerId]) REFERENCES  [Customers](Id)
alter table Orders add constraint [FK_Orders_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES  Employees(Id)
alter table OrderDetails add constraint [FK_OrderDetails_Product] FOREIGN Key (ProductId) REFERENCES Products(Id)








select * from Orders

select * from OrderDetails

select



