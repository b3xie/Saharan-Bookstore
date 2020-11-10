USE master
GO
DROP DATABASE Livraria
GO
CREATE DATABASE Livraria
GO 
USE Livraria
GO

CREATE TABLE tblSexo(
	idSexo INT NOT NULL PRIMARY KEY,
	Sexo CHAR(10)
)

CREATE TABLE tblExpediente (
	idExpediente INT NOT NULL PRIMARY KEY,
	Descricao CHAR(20),
	HorarioInicio DATETIME,
	HorarioFim DATETIME
)

CREATE TABLE tblFuncionario(
	idFuncionario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome CHAR(100),
	Sexo INT FOREIGN KEY REFERENCES tblSexo,
	Expediente INT FOREIGN KEY REFERENCES tblExpediente,
	Telefone CHAR(11),
	email CHAR(70),
	RG CHAR(11),
	CPF CHAR(11),
	UF CHAR(2),
	Cidade CHAR(50),
	Bairro CHAR(50),
	CEP CHAR(8),
	Endereco CHAR(50),
	Complemento CHAR(50),
	Salario MONEY,
	senhaLogin CHAR(20)
)

CREATE TABLE tblCliente(
	idCliente INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome CHAR(100),
	Sexo INT FOREIGN KEY REFERENCES tblSexo,
	Telefone CHAR(11),
	email CHAR(70),
	CPF CHAR(11),
	UF CHAR(2),
	Cidade CHAR(50),
	Bairro CHAR(50),
	CEP CHAR(8),
	Endereco CHAR(50),
	Complemento CHAR(50)
)

CREATE TABLE tblEstoque(
	idEstoque  INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	DataLote DATE,
	qtdeEstoque INT,
	Preco MONEY
)

CREATE TABLE tblGeneroMusic(
	idGeneroMusic INT NOT NULL PRIMARY KEY,
	Genero CHAR(20)
)

CREATE TABLE tblAutor(
	idAutor INT NOT NULL PRIMARY KEY,
	Nome CHAR(20),
	Nacionalidade CHAR(30)
)

CREATE TABLE tblAlbum(
	idAlbum INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome CHAR(100),
	Autor INT FOREIGN KEY REFERENCES tblAutor,
	Genero INT FOREIGN KEY REFERENCES tblGeneroMusic
)

CREATE TABLE tblMusicas(
	idMusica INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NumEstoque INT FOREIGN KEY REFERENCES tblEstoque,
	Titulo CHAR(100),
	Album INT FOREIGN KEY REFERENCES tblAlbum
)

CREATE TABLE tblGenero(
	idGenero INT NOT NULL PRIMARY KEY,
	Genero CHAR(20)
)

CREATE TABLE tblFilmes(
	ISAN INT NOT NULL PRIMARY KEY,
	NumEstoque INT FOREIGN KEY REFERENCES tblEstoque,
	Titulo CHAR(100),
	Estudio CHAR(50),
	Genero INT FOREIGN KEY REFERENCES tblGenero
)

CREATE TABLE tblLivros(
	ISBN INT NOT NULL PRIMARY KEY,
	NumEstoque INT FOREIGN KEY REFERENCES tblEstoque,
	Titulo CHAR(100),
	Autor CHAR(50),
	Genero INT FOREIGN KEY REFERENCES tblGenero
)

CREATE TABLE tblJogos(
	ISAN INT NOT NULL PRIMARY KEY,
	NumEstoque INT FOREIGN KEY REFERENCES tblEstoque,
	Titulo CHAR(100),
	Estudio CHAR(50),
	Publicadora CHAR(50),
	Genero INT FOREIGN KEY REFERENCES tblGenero
)