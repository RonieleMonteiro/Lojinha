USE dblojinha;
GO

--IF EXISTS(SELECT name FROM sysobjects
-- WHERE name = 'insere_cliente' AND type='P')
--DROP PROCEDURE insere_cliente

CREATE PROCEDURE [dbo].[insere_cliente]
	@codigo int output,
	@nome varchar(100),
	@email varchar(100),
	@telefone varchar(20)
AS
	INSERT INTO CLIENTES(nome, email, telefone)
	VALUES(@nome, @email, @telefone)
SET @codigo = (SELECT @@IDENTITY)