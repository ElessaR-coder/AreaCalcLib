CREATE TABLE Products(
	[Id]    INT     PRIMARY KEY NOT NULL,
	[Name]  NVARCHAR(50)  NOT NULL,
)

INSERT INTO Products VALUES
(1, N'Хлеб'),(2, N'Чай'),(3, N'Кофе'),(4, N'Молоко'),(5, N'Мясо'),(6, N'Пельмени');

CREATE TABLE Categories(
	[Id]    INT     PRIMARY KEY NOT NULL,
	[Name]  NVARCHAR(50)  NOT NULL,
)

INSERT INTO Categories VALUES
(1, N'Напитки'),(2, N'Мясное изделие'),(3, N'Рыбопродукты'),(4, N'Хлебобулочные изделия'),(5, N'Тесто');

CREATE TABLE ProductCategories(
    [ProductId]     INT           FOREIGN KEY REFERENCES Products(Id) NOT NULL,
    [CategoriesId]  INT           FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoriesId)
);

INSERT INTO ProductCategories VALUES
(1,4),(2,1),(3,1),(4,1),(5,2),(6,2),(6,5);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoriesId = C.Id;