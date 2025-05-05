CREATE PROCEDURE GetOrdersByProduct
    @ProductID INT
AS
BEGIN
    SELECT
        o_OrderID,
        o_Quantity,
        o_OrderDate,
        p_ProductName,
        p_Price
    FROM Orders o
    INNER JOIN Products p ON o_ProductID = p_ProductID
    WHERE o_ProductID = @ProductID;
END;
EXEC GetOrdersByProduct @ProductID = 1;