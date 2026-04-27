DECLARE 
	@FirstName nvarchar (100),
	@LAstName nvarchar (100)

SET @FirstName = 'Filip'
set @LAstName = 'Mihajlovski'


select @FirstName as FirstName , @LAstName as LastName

declare @FullName nvarchar (100)

set @FullName = @FirstName + ' ' + @LAstName

select @FullName as FullName

select @FirstName = 'Viktor', @LAstName='Stojanovski'

select *
from Employees 
where FirstName = @FirstName and LastName = @LAstName

select @FirstName = 'Filip'

IF(LEN(@FirstName) > 3)
	select 'Correct name'
else
	select 'Name to short'


