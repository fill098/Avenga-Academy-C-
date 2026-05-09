-- Scalar Function 
use [SEDC]
go

select * from [dbo].[Employees]
go

select [dbo].[fn_EmployeeFullName](3) as 'FullName'





/****** Object:  UserDefinedFunction [dbo].[fn_EMployeeFullName]    Script Date: 29.04.2026 19:14:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE or ALTER FUNCTION [dbo].[fn_EmployeeFullName](@EmployeeId int)
RETURNS nvarchar(100)
AS
BEGIN
	DECLARE @Result NVARCHAR(100)

	SELECT @Result =UPPER(CONCAT( FirstName, ' ', Lastname))
	FROM Employees
	WHERE Id = @EmployeeId

	RETURN @Result
END
GO


-- Assing the retun value toa varible

DECLARE @EmployeeFullName nvarchar(100) = dbo.fn_EmployeeFullName(1)
set @EmployeeFullName = dbo.fn_EmployeeFullName(2)
select @EmployeeFullName as 'Second Employee'
go


-- Write function to insert a new employe

CREATE or ALTER FUNCTION [dbo].[fn_EmployeeFullName]
(
	@FirstName  NVARCHAR(100),
    @LastName   NVARCHAR(100),
    @Email      NVARCHAR(150),
    @HireDate   DATE,
    @Salary     DECIMAL(10, 2)

)
RETURNS INT
BEGIN
	INSERT INTO Employees (FirstName, LastName, Email, HireDate, Salary)
    VALUES (@FirstName, @LastName, @Email, @HireDate, @Salary);

	Return SCOPE_IDENTITY()
END
GO

INSERT INTO Employees (FirstName, LastName, DateOfBirth, HireDate, NationalIdNumber)
	VALUES('Bob', 'Bobsky', GETDATE(), GETDATE(), 402)
	select SCOPE_IDENTITY()





