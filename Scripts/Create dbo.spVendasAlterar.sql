﻿USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spVendasAlterar] Data do Script: 30/05/2024 11:58:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE spVendasAlterar
(
    @IDVENDA nvarchar(10) = NULL,
	@IDCLIENTE nvarchar(10) = NULL,
	@CLIENTE nvarchar(100) = NULL,
	@IDPRODUTO nvarchar(10) = NULL,
	@PRODUTO nvarchar(50) = NULL,
	@QUANTIDADE INT = NULL
)
AS
BEGIN
	UPDATE TB_VENDAS
	SET IDCLIENTE = @IDCLIENTE,
		IDPRODUTO = @IDPRODUTO,
		QUANTIDADE = @QUANTIDADE 
	WHERE IDVENDA = @IDVENDA;
END