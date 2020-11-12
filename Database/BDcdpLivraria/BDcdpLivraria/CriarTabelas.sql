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
	Sexo CHAR(20)
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
	Telefone CHAR(20),
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



INSERT INTO tblSexo VALUES (1,'Masculino'),(2,'Feminino'),(3,'Não binario')
INSERT INTO tblExpediente VALUES (1,'Manha','3:00','11:00'),(2,'Tarde','11:00','19:00'),(3,'Noite','19:00','3:00')
INSERT INTO tblFuncionario (Nome,Sexo,Expediente,Telefone,email,RG,CPF,UF,Cidade,Bairro,CEP,Endereco,Complemento,Salario,senhaLogin)
VALUES 
('Edson Shu',1,1,'(21)942069696','edsondelicinha@totoso.kp',694204207,17490234816,'SP','Diadema','Santana','16292262','Rua Vale do Cariri','Beco que tem o cara morto',30000,1234)

INSERT INTO tblCliente (Nome,Sexo,Telefone,email,CPF,UF,Cidade,Bairro,CEP,Endereço,Complemento) VALUES 
('João FranSHUsco',3,'(11)989460300','jofrinha1000@gmail.com','00000000000','SP','São Paulo','Freguesia do Ó','28528185','Rua Doutor Telasko Avara,666','Apartamento 666')

INSERT INTO tblEstoque(DataLote,qtdeEstoque,Preco) VALUES
(11-12-2020,15,)