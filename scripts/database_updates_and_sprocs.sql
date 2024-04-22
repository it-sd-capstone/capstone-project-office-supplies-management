-- Ensure Data Integrity with Constraints
ALTER TABLE Products
    ADD CONSTRAINT CHK_Price CHECK (price >= 0.01),
    ADD CONSTRAINT CHK_Quantity CHECK (quantity >= 0);

-- Optimize Database Schema with Indexes
CREATE INDEX idx_name ON Products(name);
CREATE INDEX idx_categoryId ON Products(categoryId);

-- Stored Procedure to Add New Product
DELIMITER //
CREATE PROCEDURE AddNewProduct(
    IN _name VARCHAR(50),
    IN _description VARCHAR(150),
    IN _price DECIMAL(4,2),
    IN _quantity SMALLINT,
    IN _categoryId SMALLINT
)
BEGIN
    INSERT INTO Products (name, description, price, quantity, categoryId) 
    VALUES (_name, _description, _price, _quantity, _categoryId);
END //
DELIMITER ;

-- Stored Procedure to Update Existing Product
DELIMITER //
CREATE PROCEDURE UpdateProduct(
    IN _productId INT,
    IN _name VARCHAR(50),
    IN _description VARCHAR(150),
    IN _price DECIMAL(4,2),
    IN _quantity SMALLINT,
    IN _categoryId SMALLINT
)
BEGIN
    UPDATE Products
    SET name = _name,
        description = _description,
        price = _price,
        quantity = _quantity,
        categoryId = _categoryId
    WHERE productId = _productId;
END //
DELIMITER ;

-- Stored Procedure to Display Product/Supplier Information
DELIMITER //
CREATE PROCEDURE DisplayProductSupplier(
    IN _productId INT
)
BEGIN
    SELECT p.productId, p.name, p.description, p.price, p.quantity, s.supplierName
    FROM Products p
    JOIN Suppliers s ON p.productId = s.supplierID
    WHERE p.productId = _productId;
END //
DELIMITER ;