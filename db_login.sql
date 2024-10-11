CREATE TABLE Users(
	Users_Id INT IDENTITY(1,1),
	Users_Name NVARCHAR(150) UNIQUE,
	Users_Email VARCHAR(150),
	Users_Password VARCHAR(150),
	CONSTRAINT PK_Users PRIMARY KEY (Users_Id)
);

INSERT INTO Users VALUES ('HoangAnh', 'Hoanganh@gmail.com', '12345678');

CREATE TABLE Vehicle(
	Vehicle_Id INT IDENTITY(1,1),
	Vehicle_Brand VARCHAR(150),
	Vehicle_Color VARCHAR(150),
	Vehicle_Style VARCHAR(150),
	Vehicle_Model VARCHAR(150),
	Owner_Name NVARCHAR(150),
	CONSTRAINT PK_Vehicle PRIMARY KEY (Vehicle_Id)
);