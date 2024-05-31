USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spClienteExcluir] Data do Script: 30/05/2024 11:56:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE spClienteExcluir
(
    @IDCLIENTE nvarchar(10) = NULL
)
AS
BEGIN
	DELETE TB_CLIENTE 
	WHERE IDCLIENTE = @IDCLIENTE;
END
