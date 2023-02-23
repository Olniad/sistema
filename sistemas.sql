create database sistemas;
use sistemas;

create table funcionarios(
id int unsigned primary key auto_increment not null,
cpf char(14) not null,
nome varchar(50) not null,
email varchar(50) not null,
senha char(13) not null,
cetor varchar(10) not null
)engine=innodb;

create table clientes(
id int unsigned primary key auto_increment not null,
cpf char(14) not null,
nome varchar(50) not null,
email varchar(50) not null,
senha char(13) not null,
endereco varchar(80) not null
)engine=innodb;

select * from clientes;
select * from funcionarios;


