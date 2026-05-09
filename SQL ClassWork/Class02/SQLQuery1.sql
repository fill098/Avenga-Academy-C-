select * 
from Employees
where FirstName = 'Goran'

select * 
from Employees 
where LastName like 'S%'

select *
from Employees
where DateOfBirth > '1988-01-01'

select *
from Employees
where Gender = 'M'


select *
from Employees
where HireDate between '1998-01-01' and '1998-02-01'

select *
from Employees
where LastName like 'A%' and 
HireDate between '2019-01-01' and '2019-02-01'

