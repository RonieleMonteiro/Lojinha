CREATE PROCEDURE [dbo].[altera_cliente]
	@codigo int output,
	@nome varchar(100),
	@email varchar(100),
	@telefone varchar(20)
AS
	UPDATE CLIENTES SET nome = @nome, email = @email, telefone = @telefone
	WHERE codigo = @codigo
	
