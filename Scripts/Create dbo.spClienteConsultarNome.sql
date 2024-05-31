USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spClienteConsultarNome] Data do Script: 30/05/2024 11:55:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE spClienteConsultarNome
(
    @IDCLIENTE int = NULL
)
AS
BEGIN
	SELECT NOME
	FROM TB_CLIENTE 
	WHERE IDCLIENTE = IDCLIENTE;
END
