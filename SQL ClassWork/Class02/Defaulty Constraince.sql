CREATE TABLE Products_Test
(
    [Id]          INT            IDENTITY(1,1) NOT NULL,
    [Code]        NVARCHAR(20)   NULL,
    [Name]        NVARCHAR(100)  NULL,
    [Description] NVARCHAR(MAX)  NULL,
    [Weight]      DECIMAL(18,2)  NULL,
    [Price]       DECIMAL(18,2)  NULL CONSTRAINT [DFT_Products_Price] DEFAULT (0),
    [Cost]        DECIMAL(18,2)  NULL,

    CONSTRAINT [PK_Product_Test] PRIMARY KEY ([Id])
)

insert into Products_Test (Code, Name, Description, Weight, Cost)
values
('P001', 'Product', 'Discription for Product 1', 1.5, 5.00)



alter table Products_Test with check
add constraint Products_test_Code_Unique UNIQUE (Code)



insert into Products_Test (Code, Name, Description, Weight, Cost)
values
('P001', 'Product', 'Discription for Product 1', 1.5, 5.00)


alter table Products_Test 
add constraint DF_ProductTEST_Weight
Default 100 for [Weight]



insert into Products_Test (Code, Name, Description, Cost)
values
('P002', 'Product 2', 'Discription for Product 2', 5.00)


-- Check Constraint

alter table Products_Test with check 
add constraint CHK_ProductsTest_Price
CHECK (price >= 0)

insert into Products_Test (Code, Name, Description, Price, Cost)
values
('P004', 'Product 4', 'Discription for Product 4', 10, 5.00)





select * from Products_Test