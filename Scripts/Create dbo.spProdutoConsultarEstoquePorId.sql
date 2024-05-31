USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spProdutoConsultarEstoquePorId] Data do Script: 30/05/2024 11:57:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE spProdutoConsultarEstoquePorId
(
    @IDPRODUTO INT = NULL
)
AS
BEGIN
	SELECT ESTOQUE
	FROM TB_PRODUTO
	WHERE IDPRODUTO = @IDPRODUTO;
END
