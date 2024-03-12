Use master
go
IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'TopArtistasRegion')
Drop DATABASE TopArtistasRegion
GO

CREATE DATABASE TopArtistasRegion
GO
USE TopArtistasRegion
GO

/*
CREATE TABLE Artistas (
  Nombre NVARCHAR(255) ,
    Pais NVARCHAR(255),
) ;

--BULK Para insertar en la base de datos desde el archivo
BULK INSERT Artistas
FROM 'D:\Bases de datos avanzadas\TopartistasRegion\Top_Charts_Artists_Country.csv'
WITH (
    FIELDTERMINATOR = ';',
    ROWTERMINATOR = '\n',
	FIRSTROW = 2,
    CODEPAGE = '65001' -- 65001 es el código de página para UTF-8
)*/
GO
CREATE TABLE Usuario
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Nombre VARCHAR(50) NOT NULL,
 username VARCHAR(50) NOT NULL,
 Password VARCHAR(50) NOT NULL,
 Estatus BIT DEFAULT 1
)
GO

CREATE TABLE PAIS (
    Id INT  IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50),
	IdUsuarioCrea INT,
	FechaCrea DATETIME DEFAULT GETDATE(),
	IdUsuarioModifica INT NULL,
	FechaModifica DATETIME DEFAULT NULL,
	Estatus BIT DEFAULT 1

CONSTRAINT FK_PaisuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Usuario(Id),
CONSTRAINT FK_PaisUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Usuario(Id)
);
GO
CREATE TABLE ARTISTA (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50),
    IdPais INT,
	IdUsuarioCrea INT,
	FechaCrea DATETIME DEFAULT GETDATE(),
	IdUsuarioModifica INT NULL,
	FechaModifica DATETIME DEFAULT NULL,
	Estatus BIT DEFAULT 1
	CONSTRAINT FK_ArtistaPais FOREIGN KEY (IdPais) REFERENCES PAIS(Id),
	CONSTRAINT FK_ArtistauarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Usuario(Id),
	CONSTRAINT FK_ArtistaUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Usuario(Id)
);
GO
INSERT INTO Usuario(Nombre,username,Password)
VALUES('Admin','admin', CONVERT(NVARCHAR(50),HashBYTES('SHA1','Admin'),2))
GO

--Poblar las 2 tablas
INSERT INTO PAIS(Nombre,IdUsuarioCrea)
SELECT DISTINCT Pais,1 AS 'ID USUARIOCREA' FROM Artistas
GO
--delete from PAIS
--DBCC CHECKIDENT ('PAIS', RESEED, 1);  --- Esto hace el reinicio de los numero sde los identity

INSERT INTO ARTISTA (Nombre, IdPais,IdUsuarioCrea)
SELECT A.Nombre, P.Id,1 AS 'ID USUARIOCREA'
FROM Artistas A
INNER JOIN PAIS P ON A.Pais = P.Nombre
GO
--INDICES
CREATE INDEX IX_Usuario ON Usuario(id)
GO
CREATE INDEX IX_Pais ON PAIS(id)
GO
CREATE INDEX IX_Artista ON ARTISTA(id)
GO



