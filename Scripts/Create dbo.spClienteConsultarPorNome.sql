USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spClienteConsultarPorNome] Data do Script: 30/05/2024 11:56:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE spClienteConsultarPorNome
(
	@NOME nvarchar(100) = NULL
)
AS
BEGIN
	SELECT IDCLIENTE, NOME, CPF, ENDERECO, TELEFONE, EMAIL
	FROM TB_CLIENTE 
	WHERE NOME = @NOME;
END
