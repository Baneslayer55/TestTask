CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Product name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'How to become a programmer in 2 weeks.'),
	(2, 'Martian'),
	(3, 'History textbook'),
	(4, 'Handbook of Educational Psychology'),
	(5, 'Book without category');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Category name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Sci-Fi'),
	(2, 'History'),
	(3, 'Education');

CREATE TABLE ProductsShops (
	ProductsId INT FOREIGN KEY REFERENCES Products(Id),
	CategoriesId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductsId, CategoriesId)
);

INSERT INTO ProductsShops
VALUES
	(1, 1),
    (2, 1),
	(3, 2),
	(3, 3),
	(4, 3);

	
SELECT P."Product name", C."Category Name"
FROM Products P
LEFT JOIN ProductsShops PS
	ON P.Id = PS.ProductsId
LEFT JOIN Categories C
	ON PS.CategoriesId = C.Id;