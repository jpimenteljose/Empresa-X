USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spProdutoConsultarTodos] Data do Script: 30/05/2024 11:58:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE spProdutoConsultarTodos
AS
BEGIN
	SELECT IDPRODUTO,NOME,DESCRICAO,PRECO,ESTOQUE
	FROM TB_PRODUTO;
END
