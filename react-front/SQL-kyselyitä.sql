-----------------------------
-- SQL-harjoitukset 7.8.2020:
-----------------------------

-- Tehtävä 1, kohta 1:
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Tehtävä 1, kohta 2:
SELECT *
FROM Customers
WHERE CompanyName = 'Que Delícia'

SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'

-- tai:
SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerID
				    FROM Customers
                    WHERE CompanyName = 'Que Delícia')

-- Tehtävä 1, kohta 3:
SELECT *
FROM Employees
WHERE City = 'London'


-- Tehtävä 2, kohta 1:
SELECT COUNT(CustomerID)
FROM Customers

-- Tehtävä 2, kohta 2:
SELECT SUM(UnitPrice*UnitsInStock) AS 'Varastoarvo'
FROM Products

-- Tehtävä 2, kohta 3:
SELECT SUM((UnitPrice*(1-Discount))*Quantity)
FROM [Order Details]
WHERE ProductID = (SELECT ProductID
                   FROM Products
				   WHERE ProductName = 'Tofu')

--tai:
SELECT SUM((UnitPrice*(1-Discount))*Quantity)
FROM [Order Details]
WHERE ProductID IN (SELECT ProductID
                    FROM Products
				    WHERE ProductName LIKE '%tofu%')
