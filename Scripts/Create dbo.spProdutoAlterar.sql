USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spProdutoAlterar] Data do Script: 28/05/2024 15:47:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE spProdutoAlterar
(
    @IDPRODUTO nvarchar(10) = NULL,
	@NOME nvarchar(50) = NULL,
	@DESCRICAO nvarchar(100) = NULL,
	@PRECO decimal(10,2) = NULL,
	@ESTOQUE int = NULL
)
AS
BEGIN
	UPDATE TB_PRODUTO
	SET NOME = @NOME,
		DESCRICAO = @DESCRICAO,
		PRECO = @PRECO, 
		ESTOQUE = @ESTOQUE 
	WHERE IDPRODUTO = @IDPRODUTO;
END
