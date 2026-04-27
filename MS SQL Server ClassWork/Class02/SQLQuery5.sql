--Set default price in Products table
--Prevent inserting price > 2x cost
--Ensure unique product names

alter table Products
add constraint DF_Produst_Price default 0 For Price



alter table Products with check
add constraint UC_Product_Name UNIQUE (Name)