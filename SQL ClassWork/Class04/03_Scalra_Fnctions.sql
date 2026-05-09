

CREATE FUNCTION fn_EMployeeFullName(@EmployeeId int)
RETURNS nvarchar(100)
AS
BEGIN
	DECLARE @Result NVARCHAR(100)

	SELECT @Result =  FirstName + ' ' + Lastname
	FROM Employees
	WHERE Id = @EmployeeId

	RETURN @Result
END
GO

SELECT dbo.fn_EMployeeFullName(100) as FullName