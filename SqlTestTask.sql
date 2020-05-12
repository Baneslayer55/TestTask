CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Product name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'How to become a programmer in 2 weeks.'),
	(2, 'Sabaton - Discography'),
	(3, 'Club dance unltra mega mix music. Edition 132'),
	(4, 'A Midsummer Nights Dream'),
	(5, 'Tide');

CREATE TABLE Shops (
	Id INT PRIMARY KEY,
	"Shop name" TEXT
);

INSERT INTO Shops
VALUES
	(1, 'All books inside!'),
	(2, 'Cool music'),
	(3, 'Fix Price');

CREATE TABLE ProductsShops (
	ProductsId INT FOREIGN KEY REFERENCES Products(Id),
	ShopsId INT FOREIGN KEY REFERENCES Shops(Id),
	PRIMARY KEY (ProductsId, ShopsId)
);

INSERT INTO ProductsShops
VALUES
	(2, 2),
    (3, 2),
	(3, 3),
	(4, 1),
	(5, 3);
	
SELECT P."Product name", S."Shop name"
FROM Products P
LEFT JOIN ProductsShops PS
	ON P.Id = PS.ProductsId
LEFT JOIN Shops S
	ON PS.ShopsId = S.Id;