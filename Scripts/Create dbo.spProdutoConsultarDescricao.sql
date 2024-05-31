USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spProdutoConsultarDescricao] Data do Script: 30/05/2024 11:57:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE spProdutoConsultarDescricao
(
	@IDPRODUTO INT = NULL
)
AS
BEGIN
	SELECT DESCRICAO
	FROM TB_PRODUTO 
	WHERE IDPRODUTO = @IDPRODUTO;
END
