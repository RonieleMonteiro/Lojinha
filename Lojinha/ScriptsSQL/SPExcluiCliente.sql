USE dblojinha
GO

CREATE PROCEDURE [dbo].[exlui_cliente]
	@codigo int
AS
	DELETE FROM CLIENTES WHERE codigo = @codigo
