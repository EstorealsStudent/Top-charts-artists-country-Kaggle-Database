
-- Crea la base de datos
CREATE DATABASE TopArtistasRegion;

-- Crea la tabla Artistas
CREATE TABLE Artistas (
  Nombre VARCHAR(255),
  Pais VARCHAR(255)
);

-- Copia los datos desde el archivo CSV
COPY Artistas(Nombre, Pais) FROM 'F:\\Top_Charts_Artists_Country.csv' DELIMITER ';';


-- Crea la tabla Usuario
CREATE TABLE Usuario (
  Id SERIAL PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  username VARCHAR(50) NOT NULL,
  Password VARCHAR(255) NOT NULL,
  Estatus BOOLEAN DEFAULT true
);

-- Crea la tabla PAIS
CREATE TABLE PAIS (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(50),
    IdUsuarioCrea INT,
    FechaCrea TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    IdUsuarioModifica INT,
    FechaModifica TIMESTAMP,
    Estatus BOOLEAN DEFAULT true,
    CONSTRAINT FK_PaisuarioCrea FOREIGN KEY (IdUsuarioCrea) REFERENCES Usuario(Id),
    CONSTRAINT FK_PaisUsuarioModifica FOREIGN KEY (IdUsuarioModifica) REFERENCES Usuario(Id)
);

-- Crea la tabla ARTISTA
CREATE TABLE ARTISTA (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(50),
    IdPais INT,
    IdUsuarioCrea INT,
    FechaCrea TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    IdUsuarioModifica INT,
    FechaModifica TIMESTAMP,
    Estatus BOOLEAN DEFAULT true,
    CONSTRAINT FK_ArtistaPais FOREIGN KEY (IdPais) REFERENCES PAIS(Id),
    CONSTRAINT FK_ArtistauarioCrea FOREIGN KEY (IdUsuarioCrea) REFERENCES Usuario(Id),
    CONSTRAINT FK_ArtistaUsuarioModifica FOREIGN KEY (IdUsuarioModifica) REFERENCES Usuario(Id)
);

CREATE EXTENSION IF NOT EXISTS pgcrypto;
-- Inserta el usuario Admin
INSERT INTO Usuario(Nombre, username, Password)
VALUES('Admin', 'admin', PGP_SYM_ENCRYPT('admin','AES_KEY'));

-- Pobla las tablas PAIS y ARTISTA
INSERT INTO PAIS(Nombre, IdUsuarioCrea)
SELECT DISTINCT Pais, 1 AS "ID USUARIOCREA" FROM Artistas;

INSERT INTO ARTISTA (Nombre, IdPais, IdUsuarioCrea)
SELECT A.Nombre, P.Id, 1 AS "ID USUARIOCREA"
FROM Artistas A
INNER JOIN PAIS P ON A.Pais = P.Nombre;

-- Crea los índices
CREATE INDEX IX_Usuario ON Usuario(id);
CREATE INDEX IX_Pais ON PAIS(id);
CREATE INDEX IX_Artista ON ARTISTA(id);

-- Crea la vista VW_Top_Artistas
CREATE VIEW VW_Top_Artistas AS
SELECT ARTISTA.Id AS "Top Artist", ARTISTA.Nombre, PAIS.Nombre AS Pais
FROM ARTISTA
JOIN PAIS ON PAIS.Id = ARTISTA.IdPais;
