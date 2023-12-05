use master

go

if exists(select * from sys.databases where name = 'GalaxysRefugeDB')
	drop database GalaxysRefugeDB

go

create database GalaxysRefugeDB

go

use GalaxysRefugeDB

go

create table Imagem(
	ID int identity primary key,
	Foto varbinary(MAX) not null
);

go

create table Usuario(
	ID int identity primary key,
	Nome varchar(80) not null,
	Cpf varchar(20) not null,
	Email varchar(20) not null,
	DataNasc date not null,
	Numero varchar(20) not null,
	Senha varchar(MAX) not null,
	Salt varchar(200) not null,
	Adm bit not null,
);

go


create table Cupons(
	ID int identity primary key,
	codigo varchar(10) not null,
	desconto float not null,
	Descricao varchar(200) not null
);

go

create table Pedido(
	ID int identity primary key,
	UsuarioID int references Usuario(ID) not null,
	CuponsID int references Cupons(ID) not null,
	cupom varchar(50) not null,
	valor float not null,
	Finalizado bit not null,
	Entrege bit not null,
	horaPedido datetime not null,
	valCupom bit not null
);

go

create table Produtos(
	ID int identity primary key,
	Nome varchar(80) not null,
	Preco float not null,
	Descricao varchar(255),
	ImagemID int references Imagem(ID)
);

go

create table PedidoProduto(
	ID int identity primary key,
	UsuarioID int references Usuario(ID) not null,
	PedidoID int references Pedido(ID) not null,
	qtdProduto int not null
);

go

create table Post(
	ID int identity primary key,
	ProdutosID int references Produtos(ID) not null,
	ImagemID int references Imagem(ID) not null
);
go