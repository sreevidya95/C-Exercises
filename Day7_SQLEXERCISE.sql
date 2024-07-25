use demo;
select * from suppliers;
--1) How many tables are in the northwind database? ans:13 tables
--2) What is the name of the table that lists the categories of products sold?
 -- Ans:orders
 --3)What is the name of the table that lists the products sold?
--Ans:Order Details 
--4)What is the name of the table that lists the names of the suppliers of products?
--Ans:Suppliers
--5)List all category data

select * from Categories

--6)List category id and category name of all categories sorted by id

select CategoryID,categoryname from Categories order by CategoryID ASc;
--7)List the id, product name, and unit price of all products

select ProductID,ProductName,UnitPrice from Products
--8)List the id, product name, and unit price of all products that cost less that $10.00

select ProductID,ProductName,UnitPrice from Products where UnitPrice < 10.00 

--9)Do a join between categories and products so that you can list the id, product name, unit price, and category name of all products

select p.categoryId,p.productname,p.unitprice,c.categoryname from Products p
INNER JOIN Categories c on c.CategoryID = p.CategoryID

--10)List the product id, product name, unit price, category name, and  supplier name of all products that cost between %5.00 and $20.00
select p.categoryId,p.productname,p.unitprice,c.categoryname,p.SupplierID  from ((Products p
INNER JOIN Categories c on c.CategoryID = p.CategoryID)
INNER JOIN Suppliers s on s.SupplierID = p.SupplierID)
where p.UnitPrice between 5.00 AND 20.00



select * from products