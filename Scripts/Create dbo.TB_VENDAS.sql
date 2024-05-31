USE [BDEmpresaX]
GO

/****** Objeto: Table [dbo].[TB_VENDAS] Data do Script: 30/05/2024 12:00:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_VENDAS] (
    [IDVENDA]    INT            IDENTITY (1, 1) NOT NULL,
    [IDCLIENTE]  INT            NOT NULL,
    [CLIENTE]    NVARCHAR (100) NOT NULL,
    [IDPRODUTO]  INT            NOT NULL,
    [PRODUTO]    NVARCHAR (100) NOT NULL,
    [QUANTIDADE] INT            NOT NULL
);


