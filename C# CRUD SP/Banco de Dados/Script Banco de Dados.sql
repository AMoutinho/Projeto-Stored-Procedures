-- CHAMAR BANCO PARA MANIPULAÇÃO --
USE CRUDSP

-- CRIAÇÃO DA PROCEDURE DE INSERÇÃO --

CREATE PROC InserirFuncionarioSP
@ID_funcionario int,
@Nome_funcionario nvarchar(50),
@Cidade nvarchar(50),
@Idade float,
@Genero nvarchar(20),
@Contato nvarchar(50),
@Cargo nvarchar(50),
@PretensaoS nvarchar(50)
AS
Insert into tblFuncionario (ID_funcionario,Nome_funcionario,Cidade,Idade,Genero,Contato,Cargo,PretensaoS)
values (@ID_funcionario,@Nome_funcionario,@Cidade,@Idade,@Genero,@Contato,@Cargo,@PretensaoS)

-- EXECUTA STORED PROCEDURE DE INSERÇÃO --
exec InserirFuncionarioSP 2, 'Ana Marques', 'São Vicente', 50, 'Feminino', '13993252631','Design UX/UI', 3500

-- CRIAÇÃO DA PROCEDURE DE LISTAGEM --

CREATE PROC ListarFuncionarioSP
AS
BEGIN
SELECT * FROM tblFuncionario 
END

-- EXECUTA STORED PROCEDURE DE LISTAGEM --
exec ListarFuncionarioSP

-- CRIAÇÃO DA PROCEDURE DE EDIÇÃO --

CREATE PROC EditarFuncionarioSP
@ID_funcionario int,
@Nome_funcionario nvarchar(50),
@Cidade nvarchar(50),
@Idade float,
@Genero nvarchar(20),
@Contato nvarchar(50),
@Cargo nvarchar(50),
@PretensaoS nvarchar(50)
AS
Update tblFuncionario set Nome_funcionario=@Nome_funcionario,Cidade=@Cidade,Idade=@Idade,Genero=@Genero,Contato=@Contato,Cargo=@Cargo,PretensaoS=@PretensaoS WHERE ID_funcionario=@ID_funcionario

-- EXECUTA STORED PROCEDURE DE LISTAGEM --
exec ListarFuncionarioSP

-- CRIAÇÃO DA PROCEDURE EXCLUSÃO --

CREATE PROC DeletarFuncionarioSP
@ID_funcionario int
AS
DELETE tblFuncionario WHERE ID_funcionario = @ID_funcionario

-- EXECUTA STORED PROCEDURE DE LISTAGEM --
exec DeletarFuncionarioSP 

-- CARREGA ESPECIFICAÇÕES DO FUNCIONÁRIO --

CREATE PROC CarregarEspecificacoesFunc
@ID_funcionario int
AS
Select * from tblFuncionario WHERE ID_funcionario = @ID_funcionario

