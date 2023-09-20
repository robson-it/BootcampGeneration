CREATE TABLE [TB_TEMAS] (
	ID bigint NOT NULL IDENTITY (1,1),
	DESCRICAO varchar NOT NULL,
  CONSTRAINT [PK_TB_TEMAS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TB_POSTAGENS] (
	ID bigint NOT NULL IDENTITY (1,1),
	TITULO varchar NOT NULL,
	TEXTO varchar NOT NULL,
	DATA datetimeoffset NOT NULL,
	TEMA_ID bigint NOT NULL,
	USUARIO_ID bigint NOT NULL,
  CONSTRAINT [PK_TB_POSTAGENS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TB_USUARIOS] (
	ID bigint NOT NULL IDENTITY (1,1),
	NOME varchar(90) NOT NULL,
	USUARIO varchar(50) NOT NULL,
	SENHA varchar(30) NOT NULL,
	FOTO varchar(40) NOT NULL,
  CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [TB_POSTAGENS] WITH CHECK ADD CONSTRAINT [TB_POSTAGENS_fk0] FOREIGN KEY ([TEMA_ID]) REFERENCES [TB_TEMAS]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [TB_POSTAGENS] CHECK CONSTRAINT [TB_POSTAGENS_fk0]
GO
ALTER TABLE [TB_POSTAGENS] WITH CHECK ADD CONSTRAINT [TB_POSTAGENS_fk1] FOREIGN KEY ([USUARIO_ID]) REFERENCES [TB_USUARIOS]([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [TB_POSTAGENS] CHECK CONSTRAINT [TB_POSTAGENS_fk1]
GO

