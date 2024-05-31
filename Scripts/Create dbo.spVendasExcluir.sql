USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spVendasExcluir] Data do Script: 30/05/2024 11:59:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE spVendasExcluir
(
@IDVENDA nvarchar(10) = NULL
)
AS
BEGIN
	DELETE TB_VENDAS
	WHERE  IDVENDA = @IDVENDA;
END
