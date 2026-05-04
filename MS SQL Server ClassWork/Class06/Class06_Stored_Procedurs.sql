USE [SEDC]
go


-- Stored Procedures


SELECT * FROM dbo.Employees
GO

CREATE OR ALTER PROCEDURE usp_GetAllEmployees
AS 
BEGIN
	SELECT * FROM dbo.Employees

END
GO


-- Caling the procedure
EXECUTE [dbo].[usp_GetAllEmployees]
GO


-- Example : Get Employee by Id

CREATE OR ALTER PROCEDURE usp_GetEmployeeById 

	(@EmployeeId INT)
AS
BEGIN
	SELECT * FROM dbo.Employees e
	WHERE @EmployeeId = e.Id
END
GO


-- Calinig usp_GetEmployeeById
EXECUTE usp_GetEmployeeById 10

EXEC usp_GetEmployeeById @EmployeeId = 20
go
-- EXEC usp_GetEmployeeById 10,20,30 to many arguments



CREATE OR ALTER PROCEDURE usp_InsertEmployee(
	@FirstName  NVARCHAR(100),
    @LastName   NVARCHAR(100),
    @DateOfBirth DATE,
	@Gender NCHAR,
    @HireDate   DATE,
    @NationalIdNumber   DECIMAL(20)

)
AS
BEGIN
	INSERT INTO dbo.Employees (FirstName, LastName, DateOfBirth, Gender, HireDate, NationalIdNumber)
    VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @HireDate, @NationalIdNumber);
	SELECT * FROM dbo.Employees
END
GO


EXEC dbo.usp_InsertEmployee
	@FirstName = 'John',
	@LastName = 'Doe',
	@NationalIdNumber = '111111',
	@Gender = 'F',
	@HireDate = '2020-12-5',
	@DateOfBirth = '1998-05-13'
GO


CREATE OR ALTER PROCEDURE usp_InsertEmployee(
	@FirstName  NVARCHAR(100),
    @LastName   NVARCHAR(100),
    @DateOfBirth DATE,
	@Gender NCHAR,
    @HireDate   DATE,
    @NationalIdNumber   DECIMAL(20),
	@LastEmployeeId INT OUTPUT

)
AS
BEGIN
	INSERT INTO dbo.Employees (FirstName, LastName, DateOfBirth, Gender, HireDate, NationalIdNumber)
    VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @HireDate, @NationalIdNumber);
	SELECT * FROM dbo.Employees

	SET @LastEmployeeId = SCOPE_IDENTITY()

	SELECT * FROM 

END
GO


DECLARE @EmployeeIdResulat INT


EXEC dbo.usp_InsertEmployee
	@FirstName = 'Filip',
	@LastName = 'Jess',
	@NationalIdNumber = '22222',
	@Gender = 'M',
	@HireDate = '2020-12-5',
	@DateOfBirth = '1998-05-13',
	@LastEmployeeId = @EmployeeIdResulat OUTPUT



SELECT @EmployeeIdResulat AS [Last Employee Id]
Go
