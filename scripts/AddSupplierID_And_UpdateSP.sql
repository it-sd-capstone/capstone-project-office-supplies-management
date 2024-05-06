-- Add supplierID column to the Products table
ALTER TABLE Products
ADD COLUMN supplierID INT;

-- Add foreign key constraint for supplierID
ALTER TABLE Products
ADD CONSTRAINT FK_Supplier
FOREIGN KEY (supplierID) REFERENCES Suppliers(supplierID);

DELIMITER $$
-- Drop the existing stored procedure
DROP PROCEDURE IF EXISTS DisplayProductDetails;

-- Create new one
CREATE PROCEDURE DisplayProductDetails(IN _productId INT)
BEGIN
    SELECT 
        p.productId, 
        p.name, 
        p.description, 
        p.price, 
        p.quantity, 
        c.categoryName, 
        s.supplierName
    FROM Products p
    JOIN Categories c ON p.categoryId = c.categoryId
    LEFT JOIN Suppliers s ON p.supplierId = s.supplierId
    WHERE p.productId = _productId;
END$$

DELIMITER ;
