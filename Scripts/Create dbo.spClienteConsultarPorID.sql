﻿USE [BDEmpresaX]
GO

/****** Objeto: SqlProcedure [dbo].[spClienteConsultarPorID] Data do Script: 30/05/2024 11:56:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE spClienteConsultarPorID
(
    @IDCLIENTE nvarchar(10) = NULL
)
AS
BEGIN
	SELECT IDCLIENTE, NOME, CPF, ENDERECO, TELEFONE, EMAIL
	FROM TB_CLIENTE 
	WHERE IDCLIENTE = @IDCLIENTE;
END