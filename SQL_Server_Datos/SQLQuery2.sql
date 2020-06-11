-- Procedimiento Listar
CREATE PROC Eventos_Listar
AS
SELECT Emp_Id as NumEmpleado, Emp_Name as Nombre, Emp_Workshift as Turno, Emp_Line as Línea,Emp_Event as Motivo, Emp_Comment as Comentario, Emp_StartDate as FechaInicio, Emp_EndDate as FechaTermino, Emp_Aproval as Aprovó
FROM Tb_Events
GO
drop database dbSistemaAptiv
-- Procedimiento Buscar
CREATE PROC Eventos_Buscar
@valor VARCHAR(30)
AS
SELECT Emp_Id as NumEmpleado, Emp_Name as Nombre, Emp_Workshift as Turno, Emp_Line as Línea,Emp_Event as Motivo, Emp_Comment as Comentario, Emp_StartDate as FechaInicio, Emp_EndDate as FechaTermino, Emp_Aproval as Aprovó 
FROM Tb_Events
	WHERE Emp_Id LIKE '%'+ @valor + '%'
		ORDER BY Emp_Serial desc
GO

select * from Tb_Users

drop proc Eventos_Insertar
-- Procedimiento Insertar
CREATE PROC Eventos_Insertar
@empid VARCHAR(30),
@empname varchar(255),
@empline varchar(50),
@empworkshift varchar(50),
@empevent varchar(255),
@empstartdate varchar(50),
@empenddate varchar(50),
@empcomment varchar(255),
@empaproval varchar(255)
AS
INSERT INTO Tb_Events VALUES (@empid,@empname,@empline,@empworkshift,@empevent,@empstartdate,@empenddate,@empcomment,@empaproval)
GO

DROP PROC Eventos_Insertar
-- Procedimiento Actualizar

-- Procedimiento Eliminiar

-- Procedimiento Desactivar

-- Procedimiento Activar

--existe evento