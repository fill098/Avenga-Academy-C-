
USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SEDCACADEMYDB')
BEGIN
    CREATE DATABASE [SEDCACADEMYDB];
END
GO
 
USE [SEDCACADEMYDB];
GO
 

IF OBJECT_ID('dbo.GradeDetails',    'U') IS NOT NULL DROP TABLE [dbo].[GradeDetails];
IF OBJECT_ID('dbo.Grade',           'U') IS NOT NULL DROP TABLE [dbo].[Grade];
IF OBJECT_ID('dbo.AchievementType', 'U') IS NOT NULL DROP TABLE [dbo].[AchievementType];
IF OBJECT_ID('dbo.Course',          'U') IS NOT NULL DROP TABLE [dbo].[Course];
IF OBJECT_ID('dbo.Student',         'U') IS NOT NULL DROP TABLE [dbo].[Student];
IF OBJECT_ID('dbo.Teacher',         'U') IS NOT NULL DROP TABLE [dbo].[Teacher];
GO
 

CREATE TABLE [dbo].[Teacher] (
    [ID]          INT            NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [FirstName]   NVARCHAR(100)  NOT NULL,
    [LastName]    NVARCHAR(100)  NOT NULL,
    [Email]       NVARCHAR(255)      NULL,
    [PhoneNumber] NVARCHAR(50)       NULL,
    [CreatedDate] DATETIME       NOT NULL DEFAULT GETDATE()
);
GO
 

CREATE TABLE [dbo].[Student] (
    [ID]          INT            NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [FirstName]   NVARCHAR(100)  NOT NULL,
    [LastName]    NVARCHAR(100)  NOT NULL,
    [Email]       NVARCHAR(255)      NULL,
    [PhoneNumber] NVARCHAR(50)       NULL,
    [DateOfBirth] DATE               NULL,
    [Gender]            NVARCHAR(20)       NULL,
    [NationalIDNumber]  NVARCHAR(50)       NULL,
    [StudentCardNumber] NVARCHAR(50)       NULL,
    [EnrolledDate]      DATE               NULL,
    [CreatedDate] DATETIME       NOT NULL DEFAULT GETDATE()
);
GO
 

CREATE TABLE [dbo].[Course] (
    [ID]           INT            NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name]         NVARCHAR(255)  NOT NULL,
    [Credit]       INT            NOT NULL DEFAULT 0,
    [AcademicYear] INT            NOT NULL,
    [Semester]     INT            NOT NULL
);
GO
 

CREATE TABLE [dbo].[AchievementType] (
    [ID]                INT            NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name]              NVARCHAR(255)  NOT NULL,
    [Description]       NVARCHAR(500)      NULL,
    [ParticipationRate] INT            NOT NULL DEFAULT 0
);
GO
 

CREATE TABLE [dbo].[Grade] (
    [ID]          INT            NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [StudentID]   INT            NOT NULL,
    [CourseID]    INT            NOT NULL,
    [TeacherID]   INT            NOT NULL,
    [Grade]       INT                NULL,
    [Comment]     NVARCHAR(1000)     NULL,
    [CreatedDate] DATETIME       NOT NULL DEFAULT GETDATE(),
 
    CONSTRAINT [FK_Grade_Course]  FOREIGN KEY ([CourseID])  REFERENCES [dbo].[Course]([ID]),
);
GO
 

CREATE TABLE [dbo].[GradeDetails] (
    [ID]                   INT   NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [GradeID]              INT   NOT NULL,
    [AchievementTypeID]    INT   NOT NULL,
    [AchievementPoints]    INT   NOT NULL DEFAULT 0,
    [AchievementMaxPoints] INT   NOT NULL DEFAULT 0,
    [AchievementDate]      DATETIME  NULL,
 
    CONSTRAINT [FK_GradeDetails_Grade]           FOREIGN KEY ([GradeID])           REFERENCES [dbo].[Grade]([ID]),
    CONSTRAINT [FK_GradeDetails_AchievementType] FOREIGN KEY ([AchievementTypeID]) REFERENCES [dbo].[AchievementType]([ID])
);
GO
 
-- ============================================================
-- CLEANUP / RESET DATA (delete in FK-safe order)
-- ============================================================
DELETE FROM [dbo].[GradeDetails]    WHERE 1=1;
DELETE FROM [dbo].[Grade]           WHERE 1=1;
DELETE FROM [dbo].[AchievementType] WHERE 1=1;
DELETE FROM [dbo].[Course]          WHERE 1=1;
DELETE FROM [dbo].[Student]         WHERE 1=1;
DELETE FROM [dbo].[Teacher]         WHERE 1=1;
GO
 
PRINT 'SEDCACADEMYDB setup complete.';
GO