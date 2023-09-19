USE MASTER
GO

DROP DATABASE IF EXISTS DB_CONSTRUINDO_VIDAS
GO

CREATE DATABASE DB_CONSTRUINDO_VIDAS
GO

USE DB_CONSTRUINDO_VIDAS
GO

CREATE TABLE TB_CATEGORIAS (
    ID BIGINT IDENTITY(1,1),
    CATEGORIA VARCHAR(30) NOT NULL,
    UNIDADE_MEDIDA VARCHAR(15) NOT NULL,
    CONSTRAINT PK_TB_CATEGORIAS_ID PRIMARY KEY(ID) 
)
GO

CREATE TABLE TB_PRODUTOS (
    ID BIGINT IDENTITY (1,1),
    PRODUTO VARCHAR (50) NOT NULL,
    DESCRICAO VARCHAR (90),
    QUANTIDADE INT,
    PRECO DECIMAL (10,2) NOT NULL,
    CONSTRAINT PK_TB_PRODUTOS_ID PRIMARY KEY (ID),
    ID_CATEGORIA BIGINT CONSTRAINT FK_TB_CATEGORIAS FOREIGN KEY (ID_CATEGORIA) REFERENCES TB_CATEGORIAS (ID)
)
GO

INSERT INTO TB_CATEGORIAS (CATEGORIA, UNIDADE_MEDIDA) 
VALUES
('ACABAMENTO E DECORAÇÃO','UNIDADE'),
('PREGOS E PARAFUSOS','KILO'),
('FERRAMENTAS','UNIDADE'),
('ALVENARIA','UNIDADE')
GO

INSERT INTO TB_PRODUTOS (PRODUTO, DESCRICAO, QUANTIDADE, PRECO, ID_CATEGORIA)
VALUES
('LATA DE TINTA AZUL', 'CONTÉM 18L', 5, 600.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'ACABAMENTO E DECORAÇÃO')),
('PARAFUSO SEXTAVADO', 'COM PORCA', 50, 100.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'PREGOS E PARAFUSOS')),
('ALICATE', 'CABO EMBORRACHADO', 25, 1500.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'FERRAMENTAS')),
('LAJOTA', 'UTILIZAÇÃO EM LAJES', 2000, 3000.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'ALVENARIA')),
('CARRINHO DE MÃO', 'FEITO EM AÇO REFORÇADO', 10, 800.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'FERRAMENTAS')),
('CIMENTO', 'SACO DE 50KG', 200, 5000.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'ALVENARIA')),
('MASSA CORRIDA', 'CONTÉM 18L', 10, 900.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'ACABAMENTO E DECORAÇÃO')),
('PREGO', 'VARIAS MEDIDAS', 8, 40.00, (SELECT ID FROM TB_CATEGORIAS WHERE CATEGORIA = 'PREGOS E PARAFUSOS'))
GO


SELECT P.PRODUTO, P.DESCRICAO, P.QUANTIDADE, CONCAT('R$ ', P.PRECO) AS VALOR_TOTAL, CONCAT('R$ ',CONVERT(DECIMAL(5,2),(P.PRECO/P.QUANTIDADE)), ' POR ', (C.UNIDADE_MEDIDA)) AS 'VALOR UNITÁRIO'
FROM TB_PRODUTOS AS P
INNER JOIN TB_CATEGORIAS AS C
ON C.ID = P.ID_CATEGORIA 
WHERE P.PRECO > 100.00

SELECT P.PRODUTO, P.DESCRICAO, P.QUANTIDADE, CONCAT('R$ ', P.PRECO) AS VALOR_TOTAL, CONCAT('R$ ',CONVERT(DECIMAL(5,2),(P.PRECO/P.QUANTIDADE)), ' POR ', (C.UNIDADE_MEDIDA)) AS 'VALOR UNITÁRIO'
FROM TB_PRODUTOS AS P
INNER JOIN TB_CATEGORIAS AS C
ON C.ID = P.ID_CATEGORIA 
WHERE P.PRECO BETWEEN 70.00 AND 150.00

SELECT P.PRODUTO, P.DESCRICAO, P.QUANTIDADE, CONCAT('R$ ', P.PRECO) AS VALOR_TOTAL, CONCAT('R$ ',CONVERT(DECIMAL(5,2),(P.PRECO/P.QUANTIDADE)), ' POR ', (C.UNIDADE_MEDIDA)) AS 'VALOR UNITÁRIO'
FROM TB_PRODUTOS AS P
INNER JOIN TB_CATEGORIAS AS C
ON C.ID = P.ID_CATEGORIA 
WHERE P.PRODUTO LIKE '%C%'

SELECT P.PRODUTO, P.DESCRICAO, P.QUANTIDADE, CONCAT('R$ ', P.PRECO) AS VALOR_TOTAL, CONCAT('R$ ',CONVERT(DECIMAL(5,2),(P.PRECO/P.QUANTIDADE)), ' POR ', (C.UNIDADE_MEDIDA)) AS 'VALOR UNITÁRIO'
FROM TB_PRODUTOS AS P
INNER JOIN TB_CATEGORIAS AS C
ON C.ID = P.ID_CATEGORIA 

SELECT P.PRODUTO, P.DESCRICAO, P.QUANTIDADE, CONCAT('R$ ', P.PRECO) AS VALOR_TOTAL, CONCAT('R$ ',CONVERT(DECIMAL(5,2),(P.PRECO/P.QUANTIDADE)), ' POR ', (C.UNIDADE_MEDIDA)) AS 'VALOR UNITÁRIO'
FROM TB_PRODUTOS AS P
INNER JOIN TB_CATEGORIAS AS C
ON C.ID = P.ID_CATEGORIA 
WHERE C.CATEGORIA = 'FERRAMENTAS'

