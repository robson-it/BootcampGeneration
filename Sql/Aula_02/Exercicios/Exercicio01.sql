CREATE DATABASE RECURSOS_HUMANOS;

USE RECURSOS_HUMANOS;

CREATE TABLE COLABORADOR(
	ID BIGINT IDENTITY (1,1),
	NOME VARCHAR(60) NOT NULL,
	DATA_ADMISS�O DATETIME,
	DEPARTAMENTO VARCHAR(50) NOT NULL,
	SALARIO DECIMAL(9,2),
	FUNCAO VARCHAR(80),
	PRIMARY KEY(ID)
);

INSERT INTO COLABORADOR (NOME, DATA_ADMISS�O, DEPARTAMENTO, SALARIO, FUNCAO) 
VALUES
('ROBSON ALVES ROCHA',11/10/2023,'TECNOLOGIA DA INFORMA��O',6.000,'DESENVOLVEDOR FULLSTACK'),
('ROBSON ALVES ROCHA',11/10/2024,'TECNOLOGIA DA INFORMA��O',16000.00,'GERENTE DE T.I'),
('SOPHIA ALCANTARA',11/12/2023,'MARKETING', 7000.00,'ANALISTA DE MARKETING SENIOR'),
('LORENA ALBUQUERQUE',07/07/2024,'TECNOLOGIA DA INFORMA��O',26000.00,'DIRETORA DE T.I'),
('ROBSON ALVES ROCHA',12/09/2025,'DIRETORIA',36000.00,'DIRETOR EXECUTIVO'),
('ZOEMIR ZAROVISK', 2023-10-11, 'MARKETING', 1400.00, 'ASSISTENTE DE MARKETING');

SELECT * FROM COLABORADOR WHERE SALARIO > 2000;
SELECT * FROM COLABORADOR WHERE SALARIO < 2000;

UPDATE COLABORADOR SET DATA_ADMISS�O = '2023-10-11 14:41:14', SALARIO = 6000.00 WHERE ID = 1;
UPDATE COLABORADOR SET DATA_ADMISS�O = '2024-10-11 13:39:39.000' WHERE ID = 2;
UPDATE COLABORADOR SET DATA_ADMISS�O = '2023-12-11 13:39:39.000' WHERE ID = 3;
UPDATE COLABORADOR SET DATA_ADMISS�O = '2024-07-07 13:39:39.000' WHERE ID = 4;
UPDATE COLABORADOR SET DATA_ADMISS�O = '2025-09-12 13:39:39.000' WHERE ID = 5;

SELECT * FROM COLABORADOR;



