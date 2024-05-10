-- Eliminar la base de datos si existe
DROP DATABASE IF EXISTS TopArtistasRegion;

-- Crear la base de datos
CREATE DATABASE TopArtistasRegion;

-- Usar la base de datos creada
USE TopArtistasRegion;

-- Crear la tabla Artistas
CREATE TABLE Artistas (
    Nombre NVARCHAR(255),
    Pais NVARCHAR(255)
);

-- Cargar datos en la tabla Artistas desde un archivo
LOAD DATA INFILE 'F:\Top_Charts_Artists_Country.csv'
INTO TABLE Artistas
FIELDS TERMINATED BY ';'
LINES TERMINATED BY '\n'
IGNORE 1 LINES;

-- Crear la tabla Usuario
CREATE TABLE Usuario (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Estatus BIT DEFAULT 1
);

-- Crear la tabla Pais
CREATE TABLE PAIS (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre NVARCHAR(50),
    IdUsuarioCrea INT,
    FechaCrea DATETIME DEFAULT CURRENT_TIMESTAMP,
    IdUsuarioModifica INT NULL,
    FechaModifica DATETIME DEFAULT NULL,
    Estatus BIT DEFAULT 1,
    CONSTRAINT FK_PaisuarioCrea FOREIGN KEY (IdUsuarioCrea) REFERENCES Usuario(Id),
    CONSTRAINT FK_PaisUsuarioModifica FOREIGN KEY (IdUsuarioModifica) REFERENCES Usuario(Id)
);

-- Crear la tabla Artista
CREATE TABLE ARTISTA (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre NVARCHAR(50),
    IdPais INT,
    IdUsuarioCrea INT,
    FechaCrea DATETIME DEFAULT CURRENT_TIMESTAMP,
    IdUsuarioModifica INT NULL,
    FechaModifica DATETIME DEFAULT NULL,
    Estatus BIT DEFAULT 1,
    CONSTRAINT FK_ArtistaPais FOREIGN KEY (IdPais) REFERENCES PAIS(Id),
    CONSTRAINT FK_ArtistauarioCrea FOREIGN KEY (IdUsuarioCrea) REFERENCES Usuario(Id),
    CONSTRAINT FK_ArtistaUsuarioModifica FOREIGN KEY (IdUsuarioModifica) REFERENCES Usuario(Id)
);
-- Insertar datos en la tabla Usuario
INSERT INTO Usuario (Nombre, username, Password)
VALUES ('Admin', 'admin', SHA1('Admin'));

-- Poblar la tabla PAIS
INSERT INTO PAIS (Nombre, IdUsuarioCrea)
SELECT DISTINCT Pais, 1 AS 'ID USUARIOCREA' FROM Artistas;

-- Poblar la tabla ARTISTA
INSERT INTO ARTISTA (Nombre, IdPais, IdUsuarioCrea)
SELECT A.Nombre, P.Id, 1 AS 'ID USUARIOCREA'
FROM Artistas A
INNER JOIN PAIS P ON A.Pais = P.Nombre;

-- Crear índices
CREATE INDEX IX_Usuario ON Usuario(Id);
CREATE INDEX IX_Pais ON PAIS(Id);
CREATE INDEX IX_Artista ON ARTISTA(Id);

-- Crear vista VW_Top_Artistas
CREATE VIEW VW_Top_Artistas AS
SELECT ARTISTA.Id AS `Top Artist`, ARTISTA.Nombre, PAIS.Nombre AS Pais
FROM ARTISTA
JOIN PAIS ON PAIS.Id = ARTISTA.IdPais;
