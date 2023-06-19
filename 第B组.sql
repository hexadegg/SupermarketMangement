--drop database SupermarketInfo
CREATE DATABASE SupermarketInfo
GO 
USE SupermarketInfo
GO

-- 创建商品类别表
CREATE TABLE Category (
    Category_ID VARCHAR(10) NOT NULL CONSTRAINT pkCategory PRIMARY KEY
				CONSTRAINT chkCategory_ID CHECK(Category_ID LIKE'[C][G][0-9][0-9][0-9][0-9][0-9]'),
    Classification_Standard VARCHAR(50) NOT NULL CONSTRAINT uqCategory UNIQUE,
    Category_Name VARCHAR(50) NOT NULL
)

-- 创建库存表~
CREATE TABLE Inventory (
    stock_ID VARCHAR(10) NOT NULL CONSTRAINT pkInventory PRIMARY KEY
				CONSTRAINT chkstock_ID CHECK(stock_ID LIKE'[S][K][0-9][0-9][0-9][0-9][0-9]'),
    Product_Name VARCHAR(50) NOT NULL,
    Quantity INT CONSTRAINT dfQuanity DEFAULT 0
				CONSTRAINT chkQuanity CHECK(Quantity between 0 and 10000),
    Inventory_Date DATE NOT NULL,
    Threshold INT CONSTRAINT dfThreshold DEFAULT 100,
)

-- 创建员工表~
CREATE TABLE Employee (
    Employee_ID VARCHAR(10) NOT NULL PRIMARY KEY
				CONSTRAINT chkEmployee_ID CHECK(Employee_ID LIKE'[E][E][0-9][0-9][0-9][0-9][0-9]'),
    Employee_Name VARCHAR(50) NoT NULL,
	
    Keyword VARCHAR(50) CONSTRAINT chkKeyword CHECK(LEN(Keyword)>=8 AND LEN(Keyword)<=20 AND Keyword LIKE '%[0-9]%' AND Keyword LIKE '%[A-Za-z]%'),
    Employee_Email VARCHAR(20) NOT NULL CONSTRAINT EmailFormat CHECK (Employee_Email LIKE '%_@__%.__%') UNIQUE,
    Sex VARCHAR(2) CONSTRAINT chkSex CHECK (Sex IN('男','女')) ,
)

-- 创建供应商表~
CREATE TABLE Supplier (
    Supplier_ID VARCHAR(10) NOT NULL PRIMARY KEY
				CONSTRAINT chkSupplier_ID CHECK(Supplier_ID LIKE'[S][P][0-9][0-9][0-9][0-9][0-9]'),
    Supplier_Phone VARCHAR(20) NOT NULL,
    Supplier_Name VARCHAR(50) NOT NULL,
)

-- 创建进货单表~
CREATE TABLE PurchaseOrder (
    PurchaseOrder_ID VARCHAR(10) NOT NULL PRIMARY KEY
					CONSTRAINT PurchaseOrder_ID CHECK(PurchaseOrder_ID LIKE'[P][O][0-9][0-9][0-9][0-9][0-9]'),
    TotalPurchase_Price DECIMAL(10,2) CONSTRAINT chkTotalPurchase_Price CHECK(TotalPurchase_Price BETWEEN 0 AND 10000000),
    Purchase_Date DATE NOT NULL,
    Supplier_ID VARCHAR(10) constraint fkPurchaseOrderSupplier_ID foreign key references Supplier(Supplier_ID),
	Employee_ID VARCHAR(10) constraint fkPurchaseOrderEmployee_ID foreign key references  Employee(Employee_ID),
)

-- 创建商品表~
CREATE TABLE Product(
    Product_ID VARCHAR(10) NOT NULL PRIMARY KEY
				CONSTRAINT chkProduct_ID CHECK(Product_ID LIKE'[P][T][0-9][0-9][0-9][0-9][0-9]'),
    Discount_Info bit not null,
    Product_Name VARCHAR(50) NOT NULL,
    Selling_Price DECIMAL(10,2) CONSTRAINT chkSelling_Price CHECK(Selling_Price BETWEEN 1 AND 1000000),
    Depict VARCHAR(200),
    Discount DECIMAL(4,2) CONSTRAINT chkDiscount CHECK(Discount BETWEEN 0 AND 1),
    stock_ID VARCHAR(10) constraint fkstock_ID foreign key references Inventory(stock_ID),
	Supplier_ID VARCHAR(10) constraint fkProductSupplier_ID foreign key references Supplier(Supplier_ID),
)

-- 创建进货明细表~
CREATE TABLE Purchasing (
    Detail_ID VARCHAR(10) NOT NULL PRIMARY KEY
				CONSTRAINT chkDetail_ID CHECK(Detail_ID LIKE'[D][T][0-9][0-9][0-9][0-9][0-9]'),
    Purchasing_Quantity INT CONSTRAINT chkPurchasing_Quantity CHECK(Purchasing_Quantity BETWEEN 0 AND 1000000),
    Purchasing_Price DECIMAL(10,2) CONSTRAINT chkPurchasing_Price CHECK(Purchasing_Price BETWEEN 0 AND 10000000),
    Product_Name VARCHAR(50) NOT NULL,
    PurchaseOrder_ID VARCHAR(10) constraint fkPurchasingPurchaseOrder_ID foreign key references PurchaseOrder(PurchaseOrder_ID),
    Product_ID VARCHAR(10) constraint fkPurchasingProduct_ID foreign key references Product(Product_ID)
)

-- 创建商品分类表~
CREATE TABLE ProductCategory (
	Product_ID VARCHAR(10) constraint fkProduct_ID foreign key references Product(Product_ID),
	Category_ID VARCHAR(10) constraint fkCategory_ID foreign key references Category(Category_ID)
					Constraint pkProductCategory PRIMARY KEY (Product_ID, Category_ID)
)



-- 创建客户表
CREATE TABLE Customer (
    Customer_ID VARCHAR(10) NOT NULL PRIMARY KEY
			CONSTRAINT chkCustomer_ID CHECK(Customer_ID LIKE'[C][I][0-9][0-9][0-9][0-9][0-9]'),
    Customer_Name VARCHAR(50) NOT NULL,
    Sex VARCHAR(10) NOT NULL CONSTRAINT chkCustomerSex CHECK (Sex IN('男','女'))
)

-- 创建支付表
CREATE TABLE Payment (
    Payment_ID VARCHAR(10) NOT NULL PRIMARY KEY
				CONSTRAINT chkPayment_ID CHECK(Payment_ID LIKE'[P][A][0-9][0-9][0-9][0-9][0-9]'),
    Payment_Method VARCHAR(20) NOT NULL CONSTRAINT chkPayment_Method CHECK (Payment_Method IN('现金','支付宝','微信')),
    Payment_Money DECIMAL(10,2) CONSTRAINT chkPayment_Money CHECK(Payment_Money BETWEEN 0 AND 10000000),
    Payment_Time DATETIME NOT NULL,
    Customer_ID VARCHAR(10) constraint fkPaymentCustomer_ID foreign key references Customer(Customer_ID),
)

-- 创建订单表
CREATE TABLE Indent (
    Order_ID VARCHAR(10) NOT NULL PRIMARY KEY
				CONSTRAINT chkOrder_ID CHECK(Order_ID LIKE'[O][D][0-9][0-9][0-9][0-9][0-9]'),
    TotalOrder_Money DECIMAL(10,2)CONSTRAINT chkTotalOrder_Money CHECK(TotalOrder_Money BETWEEN 0 AND 100000000),
    Order_Date DATE NOT NULL,
    Payment_ID VARCHAR(10) constraint fkIndentPayment_ID foreign key references Payment(Payment_ID),
	Employee_ID VARCHAR(10) constraint fkIndentEmployee_ID foreign key references Employee(Employee_ID)
)

-- 创建订单明细表
CREATE TABLE OrderDetail (
    Detail_ID VARCHAR(10) NOT NULL PRIMARY KEY
			CONSTRAINT chkOrderDetailDetail_ID CHECK(Detail_ID LIKE'[D][T][0-9][0-9][0-9][0-9][0-9]'),
    Unit_Price DECIMAL(10,2)  CONSTRAINT chkUnit_Price CHECK(Unit_Price BETWEEN 0 AND 10000000),
    Amount INT CONSTRAINT chkAmount CHECK(Amount BETWEEN 0 AND 10000000),
    Product_ID VARCHAR(10) constraint fkOrderDetailProduct_ID foreign key references Product(Product_ID),
	Order_ID VARCHAR(10) constraint fkOrderDetailOrder_ID foreign key references Indent(Order_ID)
)



GO
--计算出订单总金额
CREATE TRIGGER trg_TotalPurchase_Price
ON Purchasing
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	
    UPDATE PurchaseOrder
    SET TotalPurchase_Price = 
	(
            SELECT SUM(Purchasing_Quantity * Purchasing_Price) 
            FROM Purchasing 
            WHERE Purchasing.PurchaseOrder_ID = PurchaseOrder.PurchaseOrder_ID
     )
    FROM PurchaseOrder 
    INNER JOIN inserted 
    ON PurchaseOrder.PurchaseOrder_ID = inserted.PurchaseOrder_ID
END

GO
--计算出订单总金额
	CREATE TRIGGER trg_TotalOrder_Money
	ON OrderDetail
	AFTER INSERT, UPDATE, DELETE
	AS
	BEGIN

	UPDATE Indent
    SET TotalOrder_Money = 
        (
            SELECT SUM(Unit_Price * Amount * Discount) 
            FROM OrderDetail join Product
			on OrderDetail.Product_ID=Product.Product_ID
            WHERE OrderDetail.Order_ID = Indent.Order_ID
        )
    FROM Indent 
    
	UPDATE Payment
    SET Payment_Money = 
        (
            SELECT TotalOrder_Money
            FROM Indent 
            WHERE Indent.Payment_ID=Payment.Payment_ID
        )
    FROM Payment 
END

GO
--返回用户登录状态。
Create proc prcValidateUser
@UserEmail varchar(20),     --输入参数
@Password  char(10)
AS
begin try
if exists(select * from Employee where Employee_Email = @UserEmail and Keyword= @Password)
	return 1
else
	return 0
end try
begin catch
	return -1            --返回值
end catch

GO

Create proc prcQuantity
@produtcID varchar(20),     --输入参数
@productCount  char(10)
AS
begin try
if exists(select * from Product where Product_ID = @produtcID)
begin
	UPDATE Inventory SET Quantity=Quantity+@productCount
	from Inventory INNER JOIN Product ON Inventory.stock_ID = Product.stock_ID
	WHERE  Product.Product_ID=@produtcID
end
else
	return 0
end try
begin catch
	return -1            --返回值
end catch

GO

CREATE PROCEDURE prcProductCategory
@categoryID varchar(20)
as
begin try
	declare @num int
	select @num=count(Product_ID) from ProductCategory where Category_ID = @categoryID
	if(@num>0)
		return 1
	else return 0
end try
begin catch
	return -1            --返回值
end catch

--CREATE PROCEDURE usp_InsertNewProduct
--    @Product_ID varchar(10),
--    @Discount_Info varchar(50),
--    @Product_Name varchar(50),
--    @Selling_Price money,
--    @Depict nvarchar(max),
--    @Discount decimal(10,2),
--    @Inventory_Quantity int,
--    @Threshold int,
--    @Category_ID int,
--    @Supplier_ID varchar(10)

--AS
--BEGIN
--    SET NOCOUNT ON;
    
--    DECLARE @Current_Date date = GETDATE();
--    DECLARE @Inventory_ID varchar(10) = '';
--    DECLARE @Purchasing_ID varchar(10) = '';
--    DECLARE @OrderDetail_ID varchar(10) = '';
    
--    -- INSERT INTO Product table
--    INSERT INTO Product (Product_ID, Discount_Info, Product_Name, Selling_Price, Depict, Discount, Supplier_ID)
--    VALUES (@Product_ID, @Discount_Info, @Product_Name, @Selling_Price, @Depict, @Discount, @Supplier_ID);
    
--    -- INSERT INTO ProductCategory table
--    SELECT @Category_ID = Category_ID
--    FROM Category
--    WHERE @Product_Name LIKE '%' + Category.Classification_Standard + '%'
    
--    IF(@Category_ID IS NOT NULL)
--    BEGIN
--        INSERT INTO ProductCategory (Product_ID, Category_ID)
--        VALUES (@Product_ID, @Category_ID)
--    END
    
--    -- INSERT INTO Inventory table
--    SET @Inventory_ID = 'I' + RIGHT('0000' + CAST((SELECT COUNT(*)+1 FROM Inventory) AS varchar(4)),4);
--    INSERT INTO Inventory (Inventory_ID, Product_ID, Product_Name, Quantity, Inventory_Date, Threshold)
--    VALUES (@Inventory_ID, @Product_ID, @Product_Name, @Inventory_Quantity, @Current_Date, @Threshold);
    
--    -- INSERT INTO Purchasing table
--    SET @Purchasing_ID = 'P' + RIGHT('0000' + CAST((SELECT COUNT(*)+1 FROM Purchasing) AS varchar(4)),4);
--    INSERT INTO Purchasing (Purchasing_ID, Detail_ID, Purchasing_Quantity, Purchasing_Price, Product_Name, PurchaseOrder_ID, Product_ID)
--    VALUES (@Purchasing_ID, 'D'+RIGHT('0000' + CAST((SELECT COUNT(*)+1 FROM Purchasing) AS varchar(4)),4), 0, 0, @Product_Name, 'PO00000', @Product_ID);
        
--    -- INSERT INTO OrderDetail table
--    SET @OrderDetail_ID = 'O' + RIGHT('0000' + CAST((SELECT COUNT(*)+1 FROM OrderDetail) AS varchar(4)),4);
--    INSERT INTO OrderDetail (OrderDetail_ID, Detail_ID, Unit_Price, Amount, Product_ID, Order_ID)
--    VALUES (@OrderDetail_ID, 'D'+RIGHT('0000' + CAST((SELECT COUNT(*)+1 FROM OrderDetail) AS varchar(4)),4), @Selling_Price, 0, @Product_ID, 'OD00000');

--END;


GO
-- 插入分类信息
INSERT INTO Category (Category_ID, Classification_Standard, Category_Name)
VALUES 
('CG00001', '用于进行语音、短信、视频等通信', '电子类'),
('CG00002', '属于碳酸饮料', '饮料类'),
('CG00003', '属于水果类植物', '植物类'),
('CG00004', '是否用于进行语音、短信、视频等通信', '电子类'),
('CG00005', '属于各种写字楼的办公用品', '办公用品类'),
('CG00006', '属于家庭使用的办公用品', '办公用品类'),
('CG00007', '属于各种日常生活用品', '日用品类'),
('CG00008', '属于各种厨房工具', '厨房用品类'),
('CG00009', '属于护肤品等日用品', '日用品类'),
('CG00010', '属于鞋子等服饰', '服饰类')

-- 插入库存信息
INSERT INTO Inventory (stock_ID, Product_Name, Quantity, Inventory_Date, Threshold)
VALUES 
('SK00001', 'iPhone 12', 10, '2022-01-01', 100),
('SK00002', 'MacBook Pro', 120, '2022-02-01', 100),
('SK00003', 'Samsung S21', 30, '2022-03-01', 200),
('SK00004', 'Lenovo ThinkPad', 140, '2022-04-01', 150),
('SK00005', 'Coca Cola', 350, '2022-05-01', 300),
('SK00006', 'Pepsi', 160, '2022-06-01', 200),
('SK00007', 'Apple', 170, '2022-07-01', 100),
('SK00008', 'Revlon Lipstick', 80, '2022-08-01', 50),
('SK00009', 'Nivea Body Lotion', 90, '2022-09-01', 300),
('SK00010', 'Adidas Running Shoes', 100, '2022-10-01', 50)

-- 插入员工信息
INSERT INTO Employee (Employee_ID, Employee_Name, Keyword, Employee_Email, Sex)
VALUES 
('EE00001', 'Lucas', 'Aaaaa11111', '12@163.com', '男'),
('EE00002', 'Emma', 'Bbbbb22222', '12@qq.com', '女'),
('EE00003', 'Owen', 'Ccccc33333', '1221@outlook.com', '男'),
('EE00004', 'Isabella', 'Ddddd44444', '1212121@163.com', '女'),
('EE00005', 'Ryan', 'Eeeee55555', '12dsadad@outlook.com', '男'),
('EE00006', 'Sophie', 'Fffff66666', 'asda@qq.com', '女'),
('EE00007', 'Jack', 'Ggggg77777', '11212dsadads@qq.com', '男'),
('EE00008', 'Chloe', 'Hhhhh88888', '1qwwfghj2@163.com', '女'),
('EE00009', 'LK', 'Lkkkk66666', 'lklk@qq.com', '男'),
('EE00010', 'Jiao', 'Jiaos12345', 'hexadegg@outlook.com', '女')

-- 插入供应商信息
INSERT INTO Supplier (Supplier_ID, Supplier_Phone, Supplier_Name)
VALUES 
('SP00001', '13303242301', 'Apple'),
('SP00002', '13306440432', 'Samsung'),
('SP00003', '13300432432', 'Coca Cola'),
('SP00004', '13314340004', 'Pepsi'),
('SP00005', '13300423422', 'Pearson Education'),
('SP00006', '13332422116', 'Revlon'),
('SP00007', '13332131311', 'Nivea'),
('SP00008', '13113223008', 'Adidas'),
('SP00009', '11231312319', 'Nike'),
('SP00010', '11313113133', 'Puma')

-- 插入进货单信息
INSERT INTO PurchaseOrder (PurchaseOrder_ID, Purchase_Date, Supplier_ID, Employee_ID)
VALUES 
('PO00001',  '2022-01-01', 'SP00001', 'EE00001'),
('PO00002',  '2022-02-01', 'SP00002', 'EE00002'),
('PO00003',  '2022-03-01', 'SP00003', 'EE00003'),
('PO00004',  '2022-04-01', 'SP00004', 'EE00004'),
('PO00005',  '2022-05-01', 'SP00005', 'EE00005')

-- 插入商品信息
INSERT INTO Product (Product_ID, Discount_Info, Product_Name, Selling_Price, Depict, Discount, stock_ID, Supplier_ID)
VALUES 
('PT00001', 1, 'iPhone 12', 8999.00, 'Apple latest mobile phone', 0.90, 'SK00001', 'SP00001'),
('PT00002', 0, 'MacBook Pro', 12999.00, 'Apple latest computer', 0.80, 'SK00002', 'SP00001'),
('PT00003', 1, 'Samsung S21', 5999.00, 'Samsung new mobile phone', 0.85, 'SK00003', 'SP00002'),
('PT00004', 1, 'Lenovo ThinkPad', 7999.00, 'Lenovo latest computer', 0.88, 'SK00004', 'SP00002'),
('PT00005', 1, 'Coca Cola', 3.00, 'World-famous soft drink', 0.95, 'SK00005', 'SP00003'),
('PT00006',1, 'Pepsi', 2.50, 'World-famous soft drink', 0.93, 'SK00006', 'SP00004'),
('PT00007', 0, 'Apple', 99.00, 'The new version of TOEFL reading materials', 1, 'SK00007', 'SP00005'),
('PT00008',1, 'Revlon Lipstick', 49.00, 'The latest color lipstick by Revlon', 0.75, 'SK00008', 'SP00006'),
('PT00009', 1, 'Nivea Body Lotion', 29.00, 'Nivea latest body lotion', 0.80, 'SK00009', 'SP00007'),
('PT00010', 1, 'Adidas Running Shoes', 499.00, 'Adidas new running shoes', 0.90, 'SK00010', 'SP00008')

-- 插入进货明细信息
INSERT INTO Purchasing (Detail_ID, Purchasing_Quantity, Purchasing_Price, Product_Name, PurchaseOrder_ID, Product_ID)
VALUES 
('DT00001', 100, 8000.00, 'iPhone 12', 'PO00001', 'PT00001'),
('DT00002', 200, 7000.00, 'MacBook Pro', 'PO00001', 'PT00002'),
('DT00003', 300, 5000.00, 'Samsung S21', 'PO00002', 'PT00003'),
('DT00004', 400, 6000.00, 'Lenovo ThinkPad', 'PO00002', 'PT00004'),
('DT00005', 500, 2.00, 'Coca Cola', 'PO00002', 'PT00005'),
('DT00006', 600, 1.50, 'Pepsi', 'PO00003', 'PT00006'),
('DT00007', 700, 88.00, 'TOEFL Reading', 'PO00003', 'PT00007'),
('DT00008', 800, 40.00, 'Revlon Lipstick', 'PO00004', 'PT00008'),
('DT00009', 900, 25.00, 'Nivea Body Lotion', 'PO00005', 'PT00009'),
('DT00010', 1000, 299.00, 'Adidas Running Shoes', 'PO00005', 'PT00010')

-- 插入商品分类信息
INSERT INTO ProductCategory (Product_ID, Category_ID)
VALUES 
('PT00001', 'CG00001'),
('PT00002', 'CG00001'),
('PT00003', 'CG00001'),
('PT00004', 'CG00001'),
('PT00005', 'CG00002'),
('PT00006', 'CG00002'),
('PT00007', 'CG00003'),
('PT00008', 'CG00008'),
('PT00009', 'CG00009'),
('PT00010', 'CG00010')

-- 插入客户信息
INSERT INTO Customer (Customer_ID, Customer_Name, Sex)
VALUES 
('CI00001', 'Alex', '男'),
('CI00002', 'Olivia', '女'),
('CI00003', 'William', '男'),
('CI00004', 'Ava', '女'),
('CI00005', 'Edward', '男'),
('CI00006', 'Ella', '女'),
('CI00007', 'Benjamin', '男'),
('CI00008', 'Grace', '女'),
('CI00009', 'George', '男'),
('CI00010', 'Sophia', '女')

-- 插入支付表信息
INSERT INTO Payment (Payment_ID, Payment_Method, Payment_Time,Customer_ID)
VALUES
('PA00001', '微信',  '2022-01-01', 'CI00001'),
('PA00002', '现金',  '2022-02-01', 'CI00002'),
('PA00003', '支付宝',  '2022-03-01', 'CI00003'),
('PA00004', '支付宝',  '2022-04-01', 'CI00004'),
('PA00005', '微信',  '2022-05-01', 'CI00005')


-- 插入订单表信息
INSERT INTO Indent (Order_ID,Order_Date,Payment_ID,Employee_ID)
VALUES
('OD00001','2022-01-01', 'PA00001','EE00001'),
('OD00002','2022-02-01', 'PA00002','EE00002'),
('OD00003','2022-03-01', 'PA00003','EE00003'),
('OD00004','2022-04-01', 'PA00004','EE00004'),
('OD00005','2022-05-01', 'PA00005','EE00005')


-- 插入订单明细信息
INSERT INTO OrderDetail (Detail_ID, Unit_Price, Amount, Product_ID,Order_ID)
VALUES 
('DT00001', 8999.00, 1, 'PT00001','OD00001'),
('DT00002', 12999.00, 2, 'PT00002','OD00001'),
('DT00003', 5999.00, 3, 'PT00003','OD00002'),
('DT00004', 7999.00, 4, 'PT00004','OD00003'),
('DT00005', 3.00, 5, 'PT00005','OD00003'),
('DT00006', 2.50, 6, 'PT00006','OD00004'),
('DT00007', 99.00, 7, 'PT00007','OD00004'),
('DT00008', 49.00, 8, 'PT00008','OD00005'),
('DT00009', 29.00, 9, 'PT00009','OD00005'),
('DT00010', 499.00, 10, 'PT00010','OD00005')



SELECT P.Product_ID,p.Product_Name, I.Quantity,p.Selling_Price,p.Discount
FROM Product P
INNER JOIN Inventory I ON P.stock_ID = I.stock_ID;

SELECT Order_ID, Payment.Customer_ID, Employee_ID, Order_Date, TotalOrder_Money
FROM Indent join Payment on Payment.Payment_ID=Indent.Payment_ID
join Customer on Customer.Customer_ID=Payment.Customer_ID

