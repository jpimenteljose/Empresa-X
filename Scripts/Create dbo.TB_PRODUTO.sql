USE [BDEmpresaX]
GO

/****** Objeto: Table [dbo].[TB_PRODUTO] Data do Script: 30/05/2024 12:00:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_PRODUTO] (
    [IDPRODUTO] INT             IDENTITY (1, 1) NOT NULL,
    [NOME]      VARCHAR (50)    NOT NULL,
    [DESCRICAO] VARCHAR (100)   NOT NULL,
    [PRECO]     DECIMAL (10, 2) NOT NULL,
    [ESTOQUE]   INT             NOT NULL
);


