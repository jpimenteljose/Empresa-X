USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spClienteAlterar] Data do Script: 30/05/2024 11:55:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE spClienteAlterar
(
    @IDCLIENTE nvarchar(10) = NULL,
	@NOME nvarchar(100) = NULL,
	@CPF nvarchar(11) = NULL,
	@ENDERECO nvarchar(100) = NULL,
	@TELEFONE nvarchar(20) = NULL,
	@EMAIL nvarchar(50) = NULL
)
AS
BEGIN
	UPDATE TB_CLIENTE 
	SET NOME = @NOME,
		CPF = @CPF,
		ENDERECO = @ENDERECO, 
		TELEFONE = @TELEFONE, 
		EMAIL = @EMAIL
	WHERE IDCLIENTE = @IDCLIENTE;
END
