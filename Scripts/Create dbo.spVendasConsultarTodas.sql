﻿USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spVendasConsultarTodas] Data do Script: 30/05/2024 11:59:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE spVendasConsultarTodas
AS
BEGIN
	SELECT V.IDVENDA, C.IDCLIENTE, C.NOME, P.IDPRODUTO, P.DESCRICAO, V.QUANTIDADE 
	FROM TB_VENDAS V, TB_CLIENTE C, TB_PRODUTO P
	WHERE V.IDCLIENTE = C.IDCLIENTE
	AND   V.IDPRODUTO = P.IDPRODUTO
END
