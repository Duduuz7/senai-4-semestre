--Criação do banco
create database dev_db_tarde

go

use dev_db_tarde

go

--Criação das tabelas
create table Professor(
	ProfessorId int primary key identity,
	Nome varchar(255),
	Email varchar(255) unique,
	Senha varchar(255)
)

go

create table Turma(
	TurmaId int primary key identity,
	Nome varchar(255),
	ProfessorId int foreign key references Professor(ProfessorId),
)

go

create table Atividade(
	AtividadeId int primary key identity,
	Descricao varchar(255),
	TurmaId int foreign key references Turma(TurmaId),
)

go

--Inserção de dados nas tabelas
insert into Professor(Nome,Email,Senha) values
('Heitor', 'Heitor@email.com', '1234'), 
('Matheus', 'Matheus@email.com', '1234'), 
('Lima', 'Lima@email.com', '1234')

go


insert into Turma(Nome, ProfessorId) values
('Dev 2025',9),
('Cyber 2025',10),
('Ciência de dados 2025',11)

go

insert into Atividade(Descricao, TurmaId) values
('Lógica de programação',5),
('Pentest',6),
('Estatística de dados',7)

go

select * from Atividade
select * from Turma
select * from Professor