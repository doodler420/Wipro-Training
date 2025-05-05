CREATE PROCEDURE CheckProductExists
    @ProductID INT
AS
BEGIN
    IF (SELECT COUNT(*) FROM Products WHERE ProductID = @ProductID) > 0
        PRINT 'Product exists';
    ELSE
        PRINT 'Product not found';
END;
EXEC CheckProductExists @ProductID=8;