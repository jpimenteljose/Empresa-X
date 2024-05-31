USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spProdutoExcluir] Data do Script: 30/05/2024 11:58:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE spProdutoExcluir
(
    @IDPRODUTO nvarchar(10) = NULL
)
AS
BEGIN
	DELETE FROM TB_PRODUTO
	WHERE IDPRODUTO = @IDPRODUTO;
END
