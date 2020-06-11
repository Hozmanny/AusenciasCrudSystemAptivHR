USE dbSistemaAptiv

-- Creacion de tablas
--			Tabla de usuarios de aplicacion
CREATE TABLE Tb_Users(
	User_Email VARCHAR(255) PRIMARY KEY,
	User_Names VARCHAR(255) NOT NULL,
	User_Password VARCHAR(255) NOT NULL,
	User_SuperUser BIT
);

--			Tabla de empleados
CREATE TABLE Tb_Employees(
	Emp_Id INTEGER PRIMARY KEY,
	Emp_Name VARCHAR(255) NOT NULL
);

--			Tabla de eventos 
CREATE TABLE Tb_Events(
	Emp_Serial INTEGER PRIMARY KEY IDENTITY,
	Emp_Id VARCHAR(30) NOT NULL,
	Emp_Name VARCHAR(255) NOT NULL,
	Emp_Line VARCHAR(10) NOT NULL,
	Emp_Workshift VARCHAR(10) NOT NULL,
	Emp_Event VARCHAR(100) NOT NULL,
	Emp_StartDate VARCHAR(100) NOT NULL,
	Emp_EndDate VARCHAR(100) NOT NULL,
	Emp_Comment VARCHAR(255),
	Emp_Aproval VARCHAR(255) NOT NULL
	
	--CONSTRAINT Fk_Emp_Id FOREIGN KEY(Emp_Id)
	--	REFERENCES Tb_Employees(Emp_Id)
);

drop table Tb_Events
drop table Tb_Users
INSERT INTO Tb_Events (Emp_Id,Emp_Name,Emp_Event,Emp_StartDate,Emp_EndDate,Emp_Aproval,Emp_Comment,Emp_Line,Emp_Workshift)
	VALUES ('123','Juan Gomez Garcia','Incapacidad por fractura', '2019-11-20', '2019-12-05','Un gerente cool', 'Se cayo y casi se muere GG', '5667', 'A')
INSERT INTO Tb_Events (Emp_Id,Emp_Name,Emp_Event,Emp_StartDate,Emp_EndDate,Emp_Aproval,Emp_Comment,Emp_Line,Emp_Workshift)
	VALUES ('321','Juan Gomez Garcia','Incapacidad por fractura x2', '2019-11-20', '2019-12-05','Un gerente cool', 'Se cayo y casi se muere GG', '5667', 'A')


INSERT INTO Tb_Users VALUES ('correo@aptiv.com','Hozmanny Garcia','123',1);
INSERT INTO Tb_Users VALUES ('correo1@aptiv.com','Hozmmanny','123',1);
INSERT INTO Tb_Users VALUES ('correo2@aptiv.com','Vato sin permiso','123',0);


CREATE PROC Users_Login
@email varchar(100),
@clave varchar(100)
AS
SELECT User_Names, User_SuperUser
FROM Tb_Users WHERE User_Email = @email AND User_Password = HASHBYTES('SHA2_256',@clave)
GO

CREATE PROC Users_Login
@email varchar(100),
@clave varchar(100)
AS
SELECT *
FROM Tb_Users WHERE User_Email = @email AND User_Password = @clave
GO


Drop proc Users_Login