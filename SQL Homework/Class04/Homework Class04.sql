	/*
	Homework
	Declare scalar variable FirstName = 'Antonio'
	Find all Students with that FirstName
	Create table variable with StudentId, StudentName, DateOfBirth
	Fill with Female students
	Create temp table with LastName and EnrolledDate
	Fill with Male students starting with 'A'
	Find students with LastName length = 7
	Find teachers with FirstName length < 5 and same first 3 letters in First/Last name
	*/


use [SEDCACADEMYDB]
go

-- Declare scalar variable FirstName = 'Antonio'
-- Find all Students with that FirstName

DECLARE @FirstName nvarchar(100) = 'Antonio'


SELECT *
FROM [Student]
WHERE [FirstName] = @FirstName

-- Create table variable with StudentId, StudentName, DateOfBirth
-- Fill with Female students

DECLARE @FemaleStudents TABLE (
	StudentId INT,
	StudentName nvarchar(100),
	DateOfBirth DATE
)


INSERT INTO @FemaleStudents (StudentId, StudentName, DateOfBirth)
SELECT 
	[ID],
	[FirstName] + ' ' + [LastName],
	[DateOfBirth]
FROM [Student]
WHERE [Gender] = 'F'


SELECT * FROM  @FemaleStudents

-- Create temp table with LastName and EnrolledDate
-- Fill with Male students starting with 'A'

CREATE TABLE #MaleStudents (
	LastName NVARCHAR (100),
	EnrolledDate DATE
)

INSERT INTO #MaleStudents (LastName, EnrolledDate)
SELECT
	[LastName],
	[EnrolledDate]
FROM [Student]
WHERE [Gender] = 'M'
AND [LastName] LIKE 'A%'


SELECT * FROM #MaleStudents


DROP TABLE #MaleStudents

-- Find students with LastName length = 7

SELECT [FirstName]
FROM [Student]
WHERE LEN([FirstName]) = 7

-- Find teachers with FirstName length < 5 and same first 3 letters in First/Last name

SELECT [FirstName], [LastName]
FROM [Teacher]
WHERE LEN([FirstName]) < 5
AND LEFT([FirstName],3) = LEFT([LastName], 3)





SELECT TOP 10 [ID], [FirstName], [LastName], [Gender] FROM [dbo].[Student]











