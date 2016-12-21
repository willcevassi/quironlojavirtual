CREATE TABLE [dbo].[produtos]
(
	[produtoId] INT NOT NULL PRIMARY KEY, 
    [nome] NCHAR(150) NULL, 
    [descricao] NCHAR(500) NULL, 
    [categoria] NCHAR(50) NULL, 
    [preco] NUMERIC(16,2) NULL
)

