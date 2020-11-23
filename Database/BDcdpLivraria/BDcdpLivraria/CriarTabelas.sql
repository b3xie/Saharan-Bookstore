USE master
GO
DROP DATABASE Livraria
GO
CREATE DATABASE Livraria
GO 
USE Livraria
GO


CREATE TABLE tblExpediente (
	idExpediente INT NOT NULL PRIMARY KEY,
	Descricao CHAR(20),
	HorarioInicio CHAR(20),
	HorarioFim CHAR(20)
)

CREATE TABLE tblFuncionario(
	idFuncionario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome CHAR(100),
	Sexo CHAR(20) CHECK(Sexo = 'Masculino' OR Sexo = 'Feminino' OR Sexo = 'Não binário'),
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
	Telefone CHAR(20),
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
	idEstoque INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CodigoBarras CHAR(12) NOT NULL,
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
	ISMN CHAR(13) NOT NULL PRIMARY KEY,
	idEstoque INT FOREIGN KEY REFERENCES tblEstoque(idEstoque),
	Titulo CHAR(100),
	Album INT FOREIGN KEY REFERENCES tblAlbum
)

CREATE TABLE tblGenero(
	idGenero INT NOT NULL PRIMARY KEY,
	Genero CHAR(20)
)

CREATE TABLE tblFilmes(
	ISAN CHAR(12) NOT NULL PRIMARY KEY,
	idEstoque INT FOREIGN KEY REFERENCES tblEstoque(idEstoque),
	Titulo CHAR(100),
	Estudio CHAR(50),
	Genero INT FOREIGN KEY REFERENCES tblGenero
)

CREATE TABLE tblLivros(
	ISBN CHAR(13) NOT NULL PRIMARY KEY,
	idEstoque INT FOREIGN KEY REFERENCES tblEstoque(idEstoque),
	Titulo CHAR(100),
	Autor CHAR(50),
	Genero INT FOREIGN KEY REFERENCES tblGenero
)

CREATE TABLE tblJogos(
	ISAN CHAR(12) NOT NULL PRIMARY KEY,
	idEstoque INT FOREIGN KEY REFERENCES tblEstoque(idEstoque),
	Titulo CHAR(100),
	Estudio CHAR(50),
	Publicadora CHAR(50),
	Genero INT FOREIGN KEY REFERENCES tblGenero
)



INSERT INTO tblExpediente VALUES (1,'Manha','3:00','11:00'),(2,'Tarde','11:00','19:00'),(3,'Noite','19:00','3:00')
INSERT INTO tblFuncionario (Nome,Sexo,Expediente,Telefone,email,RG,CPF,UF,Cidade,Bairro,CEP,Endereco,Complemento,Salario,senhaLogin)
VALUES 
('Edson Shu','Masculino',1,'(21)942069696','edsondelicinha@totoso.kp','694204207','17490234816','SP','Diadema','Santana','16292262','Rua Vale do Cariri','Beco que tem o cara morto',30000,1234),
('Gabriel Braço','Masculino',2,'(11)928627501','gabzxth@contato.kp','849235091','00000000000','RJ','Diadema','Santana','16292262','Rua Vale do Cariri','Beco que tem o cara morto',30000,1234)

INSERT INTO tblCliente (Nome,Telefone,email,CPF,UF,Cidade,Bairro,CEP,Endereco,Complemento) VALUES 
('João FranSHUsco','(11)989460300','jofrinha1000@gmail.com','00000000000','SP','São Paulo','Freguesia do Ó','28528185','Rua Doutor Telasko Avara,666','Apartamento 666')

INSERT INTO tblEstoque VALUES ('000000000000',GETDATE(),20,1000),
('000000000001',GETDATE(),30,15),
('000000000002',GETDATE(),20,40),
('000000000003',GETDATE(),100,10),
('000000000004',GETDATE(),230,40)

INSERT INTO tblGenero VALUES (1,'Erótica'),(2,'Ação'),(3,'Comédia Românica'),(4,'Simulação')

INSERT INTO tblLivros VALUES ('1111111111111',1,'As Aventuras de JofraLoL','Edson Shu',1)

INSERT INTO tblAutor VALUES (1,'John Cock','Norte-coreano')

INSERT INTO tblGeneroMusic VALUES (1,'Kpop')

INSERT INTO tblAlbum VALUES ('O melhor do fluxo: as novinha do meu grau',1,1)

INSERT INTO tblMusicas VALUES ('0000000000000',2,'Baile de Favela 4',1)

INSERT INTO tblFilmes VALUES ('000000000000',3,'Edson 4: Sem tempo irmão','varMel',3)

INSERT INTO tblJogos VALUES ('000000000000',4,'Persona 69','Atlus','SEGA',3),
('000000000001',5,'O Simulador de Vida Real','NãoTem','Nãoe Ziste',4)

SELECT * FROM tblFuncionario

SELECT * FROM tblMusicas

SELECT * FROM tblEstoque

SELECT tblMusicas.*,tblAutor.Nome,tblEstoque.Preco FROM tblMusicas INNER JOIN tblAlbum ON tblAlbum.idAlbum = tblMusicas.Album INNER JOIN tblAutor ON tblAutor.idAutor = tblAlbum.Autor INNER JOIN tblEstoque ON tblEstoque.idEstoque = tblMusicas.idEstoque WHERE tblEstoque.CodigoBarras = '000000000001'

SELECT * FROM tblFilmes WHERE  Titulo LIKE '%Edson% 4: %Sem% %tempo% %irmão%' OR ISAN = '00000000000'

SELECT * FROM tblJogos WHERE Titulo LIKE '%P%' OR ISAN = '111'