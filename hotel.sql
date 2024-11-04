CREATE TABLE Manager (
    Username VARCHAR(20) PRIMARY KEY,
    Password VARCHAR(20) NOT NULL,
	Name VARCHAR(20) NOT NULL,
	ID_Manager VARCHAR(20) NOT NULL,
	);
	CREATE TABLE Customer (
    ID_Customer INT PRIMARY KEY,
    Name VARCHAR(50),
    IDcard VARCHAR(20),
    Gender VARCHAR(10),
    DOB DATE,
    PhoneNumber VARCHAR(15),
    Nationality VARCHAR(30)
);
CREATE TABLE Calendar (
    ID_Calendar INT PRIMARY KEY,
    ID_Shift INT,
    ID_Person INT,
    Day DATE
);
CREATE TABLE Employee (
    ID_Employee INT PRIMARY KEY,
    Name VARCHAR(50),
    Gender VARCHAR(10),
    DOB DATE,
    PhoneNumber VARCHAR(15),
    Address VARCHAR(100),
    Role VARCHAR(20),
    Username VARCHAR(20) UNIQUE,
    Password VARCHAR(20) NOT NULL
);
CREATE TABLE Checkinout (
    ID_Checkinout INT PRIMARY KEY,
    ID_Calendar INT,
    ID_Employee INT,
    TimeCheckin TIME,
    TimeCheckout TIME,
    Day DATE,
    FOREIGN KEY (ID_Calendar) REFERENCES Calendar(ID_Calendar),
    FOREIGN KEY (ID_Employee) REFERENCES Employee(ID_Employee)
);
CREATE TABLE Salary (
    ID_Salary INT PRIMARY KEY,
    ID_Employee INT,
    Day DATE,
    Amount DECIMAL(10, 2),
    FOREIGN KEY (ID_Employee) REFERENCES Employee(ID_Employee)
);
CREATE TABLE Inventory (
    ID_Inventory INT PRIMARY KEY,
    Name VARCHAR(50),
    Number INT,
    Price DECIMAL(10, 2)
);
CREATE TABLE Room (
    ID_Room INT PRIMARY KEY,
    Name VARCHAR(50),
    State VARCHAR(20),
    Kind VARCHAR(20),
    Price DECIMAL(10, 2)
);
CREATE TABLE BookRoomView (
    ID_Room INT,
    CustomerName VARCHAR(50),
    IDcard VARCHAR(20),
    RoomKind VARCHAR(20),
    Timecheckin TIME,
    Timecheckout TIME,
    ID_Customer INT,
    RoomName VARCHAR(50),
    RoomState VARCHAR(20),
    ID_BookRoom INT PRIMARY KEY
);
CREATE TABLE Receipt (
    ID_Receipt INT PRIMARY KEY,
    ID_Customer INT,
    ID_Room INT,
    ID_BookRoom INT,
    Timemake TIME,
    Service_fee DECIMAL(10, 2),
    Dayintotal INT,
    Totalpayment DECIMAL(10, 2),
    FOREIGN KEY (ID_Customer) REFERENCES Customer(ID_Customer),
    FOREIGN KEY (ID_Room) REFERENCES Room(ID_Room)
); 
INSERT INTO Manager ( Username, Password, Name, ID_Manager)
VALUES ('Thao Nhi', '24102005', 'Nhi', '01');
INSERT INTO Employee( ID_Employee,Name,Gender,DOB,PhoneNumber,Address,Role,Username,Password)
VALUES ('01','Nhi', 'Nữ', '2005-10-24', '0706003022', 'Chung cư 4s', 'Receiptor', 'Thao Nhi', '24102005');
