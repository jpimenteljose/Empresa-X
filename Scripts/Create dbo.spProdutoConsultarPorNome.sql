USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spProdutoConsultarPorNome] Data do Script: 30/05/2024 11:58:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE spProdutoConsultarPorNome
(
    @NOME nvarchar(50) = NULL
)
AS
BEGIN
	SELECT IDPRODUTO,NOME,DESCRICAO,PRECO,ESTOQUE
	FROM TB_PRODUTO
	WHERE NOME = @NOME;
END
