CREATE TABLE Agencia (
Numero_agencia int PRIMARY KEY,
Nome varchar(100) not null,
Endereco_id int not null
)

CREATE TABLE Funcionario (
Matricula int PRIMARY KEY identity,
Cpf varchar(11) unique not null,
Nome varchar(60) not null,
Cargo varchar(11) not null,
Senha varchar(20) not null,
Numero_agencia int not null,
Endereco_id int not null,
FOREIGN KEY(Numero_agencia) REFERENCES Agencia (Numero_agencia)
)

CREATE TABLE Movimentacao (
Movimentacao_id int PRIMARY KEY identity,
Data date not null,
Tipo varchar(20) not null,
Valor decimal(18,2) not null,
Numero_conta int not null
)

CREATE TABLE Conta (
Numero_conta int PRIMARY KEY,
Saldo decimal(18,2) not null,
Data_criacao date not null,
Numero_agencia int not null,
Cliente_id int not null,
FOREIGN KEY(Numero_agencia) REFERENCES Agencia (Numero_agencia)
)

CREATE TABLE Emprestimo (
Emprestimo_id int PRIMARY KEY identity,
Taxa_juros_mensal decimal(18,2) not null,
Data_criacao date not null,
Valor decimal(18,2) not null,
Numero_conta int not null,
Quantidade_parcela int not null,
FOREIGN KEY(Numero_conta) REFERENCES Conta (Numero_conta)
)

CREATE TABLE Parcela (
Parcela_id int PRIMARY KEY identity,
Data_vencimento date not null,
Valor decimal(18,2) not null,
Emprestimo_id int not null,
Status varchar(20) not null,
Numero_parcela int not null,
FOREIGN KEY(Emprestimo_id) REFERENCES Emprestimo (Emprestimo_id)
)

CREATE TABLE Endereco (
Endereco_id int PRIMARY KEY identity,
Rua varchar(60) not null,
Cep varchar(8) not null,
Complemento varchar(100) not null,
Numero varchar(20) not null,
Cidade varchar(100) not null,
Bairro varchar(100) not null,
Uf varchar(2) not null
)

CREATE TABLE Cliente (
Cliente_id int PRIMARY KEY identity,
Nome varchar(100) not null,
Telefone varchar(11) not null,
Cpf varchar(11) not null,
Email varchar(60) not null,
Endereco_id int not null,
FOREIGN KEY(Endereco_id) REFERENCES Endereco (Endereco_id)
)

ALTER TABLE Agencia ADD FOREIGN KEY(Endereco_id) REFERENCES Endereco (Endereco_id)
ALTER TABLE Funcionario ADD FOREIGN KEY(Endereco_id) REFERENCES Endereco (Endereco_id)
ALTER TABLE Movimentacao ADD FOREIGN KEY(Numero_conta) REFERENCES Conta (Numero_conta)
ALTER TABLE Conta ADD FOREIGN KEY(Cliente_id) REFERENCES Cliente (Cliente_id)
