-- Table variable

declare @FemaleEmployList TABLE (
	EmployeeID int not null,
	FirstName nvarchar (100) null,
	LastName nvarchar (100) null

)



--insert into @FemaleEmployList (EmployeeId, FirstName, LastName)
--values (101, 'Ana', 'Nikolovska'),
--		(102, 'Aleksandra', 'Petrovska'),
--		(103, 'Bojana', 'Bojanovska')


--select * from Employees where Gender = 'F'


insert into @FemaleEmployList (EmployeeID, FirstName, LastName)
select Id, FirstName, LastName
from Employees
where Gender = 'F'


select * from @FemaleEmployList


-- Temprary Table

CREATE TABLE #MaleEmployeeTempTable(
	EmployeeID int not null,
	FirstName nvarchar(100) null,
	LastName nvarchar(100) null
)


insert into #MaleEmployeeTempTable (EmployeeID, FirstName, LastName)
select Id, FirstName, LastName
from Employees
where Gender = 'M'

select * from #MaleEmployeeTempTable




