--CREATE DATABASE
select * from ds3.Saves
EXEC sp_MSforeachtable 'DROP TABLE ?';

--CREATE TABLES

CREATE TABLE ds3.Zona(
Nome varchar(50) NOT NULL PRIMARY KEY,
Trilha_Sonora varchar(30)
);
GO
CREATE TABLE ds3.Localizacao(
Item int,
Zona varchar(50),
Coordenadas varchar(20) NOT NULL PRIMARY KEY
);
GO
CREATE TABLE ds3.Localizacao_Adversario(
Adversario int,
Localizacao varchar(20),
PRIMARY KEY(Adversario,Localizacao)
);
GO
CREATE TABLE ds3.Saves(
ID int PRIMARY KEY NOT NULL,
Ultima_localizacao varchar(20),
Horas time ,
Jogador int
);
GO
CREATE TABLE ds3.Personagem(
Nome varchar(50),
Pontos_De_Vida int,
ID int PRIMARY KEY NOT NULL
);
GO
CREATE TABLE ds3.Jogador(
Personagem int PRIMARY KEY,
Item_Discovery int,
Stamina int,
Classe varchar(20),
Equip_Load float(24),
Focus_Points int,
Nivel smallint
);
GO
CREATE TABLE ds3.Atributos(
ID int PRIMARY KEY,
Designacao varchar(20),
Valor int
);
GO
CREATE TABLE ds3.Adversario(
Drops			varchar(30),
Fraqueza		varchar(30),
Resistencia		varchar(30),
Imunidade		varchar(30),
Personagem int PRIMARY KEY
);
GO
CREATE TABLE ds3.Inimigo(
Tipo varchar(20),
Adversario int PRIMARY KEY
);
GO
CREATE TABLE ds3.Boss(
Trilha_Sonora varchar(30),
Dialogo text,
Adversario int PRIMARY KEY
);
GO
CREATE TABLE ds3.NPC(
Dialogo text,
Adversario int PRIMARY KEY
);
GO
CREATE TABLE ds3.Quest(
Recompensa varchar (50),
Objetivo text,
NPC int PRIMARY KEY
);
GO
CREATE TABLE ds3.Item_Personagem(
Item int,
Personagem int,
PRIMARY KEY (Item,Personagem)
);
GO
CREATE TABLE ds3.Item(
Nome varchar(50),
Tipo varchar(20),
ID int PRIMARY KEY
);
GO
CREATE TABLE ds3.Item_Equipavel(
Peso float,
Durabilidade int,
Item int  PRIMARY KEY
);
GO
CREATE TABLE ds3.Arma(
Dano int,
Item_Equipavel int  PRIMARY KEY
);
GO
CREATE TABLE ds3.Armadura(
Defesa int,
Item_Equipavel int  PRIMARY KEY
);
GO
CREATE TABLE ds3.Item_Nao_Equipavel(
Quantidade tinyint,
Item int  PRIMARY KEY
);
GO
CREATE TABLE ds3.Jogador_Atributos(
Jogador int,
Atributos int
PRIMARY KEY(Jogador,Atributos)
);

--ADD CONSTRAINTS

alter table ds3.Localizacao add constraint fk_localizacao_Item foreign key (Item) references  ds3.Item (ID);
GO
alter table ds3.Localizacao add constraint fk_localizacao_Zona foreign key (Zona) references  ds3.Zona (Nome);
GO
alter table ds3.Localizacao_Adversario add constraint fk_localizacao_adversario_localizacao foreign key (Localizacao) references  ds3.Localizacao (Coordenadas);
GO
alter table ds3.Localizacao_Adversario add constraint fk_localizacao_adversario_adversario foreign key (Adversario) references  ds3.Adversario (Personagem);
GO
alter table ds3.Saves add constraint fk_Saves_Ultima_localizacao foreign key (Ultima_localizacao) references  ds3.Localizacao (Coordenadas);
GO
alter table ds3.Saves add constraint fk_Saves_Jogador foreign key (Jogador) references  ds3.Jogador (Personagem);
GO
alter table ds3.Adversario add constraint fk_Adversario_Personagem foreign key (Personagem) references  ds3.Personagem (ID);
GO
alter table ds3.Inimigo add constraint fk_Inimigo_Adversario foreign key (Adversario) references ds3.Adversario (Personagem);
GO
alter table ds3.Boss add constraint fk_Boss_Adversario foreign key (Adversario) references ds3.Adversario (Personagem);
GO
alter table ds3.NPC add constraint fk_NPC_Adversario foreign key (Adversario) references ds3.Adversario (Personagem);
GO
alter table ds3.Quest add constraint fk_Quest_NPC foreign key (NPC) references ds3.NPC (Adversario);
GO
alter table ds3.Item_Personagem add constraint fk_Item_Personagem_Item foreign key (Item) references ds3.Item (ID);
GO
alter table ds3.Item_Personagem add constraint fk_Item_Personagem_Personagem foreign key (Personagem) references ds3.Personagem (ID);
GO
alter table ds3.Item_Equipavel add constraint fk_Item_Equipavel_Item foreign key (Item) references ds3.Item (ID);
GO
alter table ds3.Arma add constraint fk_Arma_Item_Equipavel foreign key (Item_Equipavel) references ds3.Item_Equipavel(Item);
GO
alter table ds3.Armadura add constraint fk_Armadura_Item_Equipavel foreign key (Item_Equipavel) references ds3.Item_Equipavel(Item);
GO
alter table ds3.Item_Nao_Equipavel add constraint fk_Item_Nao_Equipavel_Item foreign key (Item) references ds3.Item (ID);
GO
alter table ds3.Jogador_Atributos add constraint fk_Jogador_Atributos_Jogador foreign key (Jogador) references ds3.Jogador (Personagem);
GO
alter table ds3.Jogador_Atributos add constraint fk_Jogador_Atributos_Atributos foreign key (Atributos) references ds3.Atributos (ID);


-- DROP DATABASE

--DROP CONSTRAINTS

alter table ds3.Localizacao drop constraint fk_localizacao_Item;
GO
alter table ds3.Localizacao drop constraint fk_localizacao_Zona;
GO
alter table ds3.Localizacao_Adversario drop constraint fk_localizacao_adversario_localizacao;
GO
alter table ds3.Localizacao_Adversario drop constraint fk_localizacao_adversario_adversario;
GO
alter table ds3.Saves drop constraint fk_Saves_Ultima_localizacao;
GO
alter table ds3.Saves drop constraint fk_Saves_Jogador;
GO
alter table ds3.Adversario drop constraint fk_Adversario_Personagem;
GO
alter table ds3.Inimigo drop constraint fk_Inimigo_Adversario;
GO
alter table ds3.Boss drop constraint fk_Boss_Adversario;
GO
alter table ds3.NPC drop constraint fk_NPC_Adversario;
GO
alter table ds3.Quest drop constraint fk_Quest_NPC;
GO
alter table ds3.Item_Personagem drop constraint fk_Item_Personagem_Item;
GO
alter table ds3.Item_Personagem drop constraint fk_Item_Personagem_Personagem;
GO
alter table ds3.Item_Equipavel drop constraint fk_Item_Equipavel_Item;
GO
alter table ds3.Arma drop constraint fk_Arma_Item_Equipavel;
GO
alter table ds3.Armadura drop constraint fk_Armadura_Item_Equipavel;
GO
alter table ds3.Item_Nao_Equipavel drop constraint fk_Item_Nao_Equipavel_Item;
GO
alter table ds3.Jogador_Atributos drop constraint fk_Jogador_Atributos_Jogador;
GO
alter table ds3.Jogador_Atributos drop constraint fk_Jogador_Atributos_Atributos;
GO

--DROP TABLES

DROP TABLE ds3.Zona;
GO
DROP TABLE ds3.Localizacao;
GO
DROP TABLE ds3.Localizacao_Adversario;
GO
DROP TABLE ds3.Saves;
GO
DROP TABLE ds3.Personagem;
GO
DROP TABLE ds3.Jogador;
GO
DROP TABLE ds3.Atributos;
GO
DROP TABLE ds3.Adversario;
GO
DROP TABLE ds3.Inimigo;
GO
DROP TABLE ds3.Boss;
GO
DROP TABLE ds3.NPC;
GO
DROP TABLE ds3.Quest;
GO
DROP TABLE ds3.Item_Personagem;
GO
DROP TABLE ds3.Item;
GO
DROP TABLE ds3.Item_Equipavel;
GO
DROP TABLE ds3.Arma;
GO
DROP TABLE ds3.Armadura;
GO
DROP TABLE ds3.Item_Nao_Equipavel;
GO
DROP TABLE ds3.Jogador_Atributos;