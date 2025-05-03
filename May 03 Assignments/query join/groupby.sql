SELECT
    p.ProductName,
    SUM(o.Quantity) AS TotalUnitsSold
FROM Orders o
INNER JOIN Products p ON o.ProductID = p.ProductID
GROUP BY p.ProductName
