



















select Code, SUBSTRING(Code, 1,3) as ShorCode
from Products


-- Repalcce


select FirstName, LastName, REPLACE(Gender, 'M', 'Male' ) as GenderFullName
from Employees

select GETDATE()

select  UPPER(FirstName) as FirstNamesToUpperCase, LOWER(LastName) as LastNamesToLowerCase
from Employees