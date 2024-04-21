-- Inserting into Suppliers
INSERT INTO Suppliers (supplierID, supplierName, phoneNumber, email, address, city, region, country, postalCode, salesRepName) VALUES
(1, 'Paper Products Co.', '123-456-7890', 'info@paperproducts.com', '123 Paper St.', 'Milltown', 'Midwest', 'USA', '50001', 'John Doe'),
(2, 'Office Gadgets Ltd.', '321-654-0987', 'contact@officegadgets.com', '456 Tech Avenue', 'Gadget City', 'Southwest', 'USA', '50002', 'Jane Smith');

-- Inserting into Categories
INSERT INTO Categories (categoryId, categoryName, description) VALUES
(1, 'Stationery', 'All kinds of stationery products'),
(2, 'Office Electronics', 'Various electronic products for office use');

-- Inserting into Products
INSERT INTO Products (productId, name, description, price, quantity, categoryId) VALUES
(1, 'Premium Notebook', '200 pages notebook, lined', 4.50, 150, 1),
(2, 'Erasable Pens', 'Pack of 5 blue erasable pens', 3.75, 200, 1),
(3, 'Multifunction Printer', 'All-in-one printer with scanning, printing, and faxing', 99.99, 30, 2);
-- Inserting into Restocks
INSERT INTO Restocks (restockID, itemId, supplierId, quantity, expRestock) VALUES
(1, 1, 1, 100, '2023-12-15 00:00:00'),
(2, 3, 2, 50, '2023-12-20 00:00:00');