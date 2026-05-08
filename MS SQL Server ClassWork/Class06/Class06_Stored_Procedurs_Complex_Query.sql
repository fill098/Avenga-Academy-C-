USE [SEDC]
Go


-- Get Employees by Gender and ther count 


SELECT * FROM dbo.Employees
Go


CREATE Or ALTER PROCEDURE usp_GetEMployeesByGender
(
	@Gender NCHAR = 'M',
	@GenderCount Int OUT

)
AS
BEGIN

	SELECT * FROM dbo.Employees
	where Gender = @Gender

	SELECT @GenderCount = Count(Id)
	FROM dbo.Employees
	WHERE Gender = @Gender

END
GO


DECLARE @GenderCountResult int
EXECUTE usp_GetEMployeesByGender  @Gender = 'F', @GenderCount = @GenderCountResult OUTPUT
SELECT @GenderCountResult as GenderCount

-- Find Product Details for specific Producct (by Product name)


SELECT * FROM dbo.Products
SELECT * FROM dbo.OrderDetails
Go


CREATE Or ALTER PROCEDURE usp_FindProductDetailsByName
(
	@ProductName NVARCHAR (100),
	@ProductPrice DECIMAL(18,2) OUTPUT,
	@TotalQuantity INT OUT
	

)
AS
BEGIN
	-- Select the product details
	SELECT 
		p.[Name] as ProductName,
		p.[Description] as ProductDisription,
		p.Price as ProductPrice

	FROM dbo.[Products] p
	WHERE p.[Name] = @ProductName

	-- Set ProductPrice output
	SELECT @ProductPrice = p.Price
	FROM dbo.Products p 
	WHERE p.[Name] = @ProductName

	-- Product Quantaty oputput

	SELECT TotalQuantity = SUM(od.Quantity) FROM dbo.Products p
	LEFT JOIN dbo.OrderDetails od on p.Id = od.ProductId
	WHERE p.[Name] = @ProductName

END
GO



DECLARE @ProductPrice DECIMAL (18,2), @TotalQuantityResult int

EXEC usp_FindProductDetailsByName 'Cereals', @ProductPrice OUTPUT, 
SELECT @ProductPrice as 'Product Price', 

GO


CREATE OR ALTER PROCEDURE usp_CreateOrder
(
    
    @BusinessEntityId INT,
    @CustomerId      INT,
    @EmployeeId      INT,
    @TotalPrice      DECIMAL(10,2)   
)
AS
BEGIN

    INSERT INTO dbo.[Orders] ( BusinessEntityId, CustomerId, EmployeeId, TotalPrice)
    VALUES ( @BusinessEntityId, @CustomerId, @EmployeeId, @TotalPrice)  

END
GO

EXECUTE usp_CreateOrder

    @BusinessEntityId = 2,
    @CustomerId       = 3,
    @EmployeeId       = 4,
    @TotalPrice       = 99.99

SELECT * FROM dbo.[Orders]