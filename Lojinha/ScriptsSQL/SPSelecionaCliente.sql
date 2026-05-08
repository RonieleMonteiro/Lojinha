USE dblojinha
GO

CREATE PROCEDURE [dbo].[seleciona_cliente]
	@filtro varchar(100) = NULL
AS
BEGIN
	IF @filtro IS NULL
		SELECT * FROM CLIENTES
	ELSE
		SELECT * FROM CLIENTES
		WHERE nome like '%' + @filtro + '%'
		OR email like '%' + @filtro +'%'
		OR telefone like '%' + @filtro + '%'
END