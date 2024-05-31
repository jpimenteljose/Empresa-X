USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spClienteConsultarTodos] Data do Script: 30/05/2024 11:56:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE spClienteConsultarTodos
AS
BEGIN
	SELECT IDCLIENTE, NOME, CPF, ENDERECO, TELEFONE, EMAIL
	FROM TB_CLIENTE;
END
