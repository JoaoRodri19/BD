CREATE SCHEMA ds3;

CREATE TABLE ds3.Zona(
Nome varchar(20) NOT NULL PRIMARY KEY,
Trilha_Sonora varchar(30)
);

CREATE TABLE ds3.Localizacao(
Item int,
Zona varchar(20),
Coordenadas varchar(20) NOT NULL PRIMARY KEY
);

CREATE TABLE ds3.Localizacao_Adversário(
Adversario int,
Localizacao varchar(20),
PRIMARY KEY(Adversario,Localizacao)
);

CREATE TABLE ds3.Saves(
ID int PRIMARY KEY NOT NULL,
Ultima_localizacao varchar(20),
Horas time ,
Jogador int
);

CREATE TABLE ds3.Personagem(
Nome varchar(30),
Pontos_De_Vida int,
ID int PRIMARY KEY NOT NULL
);

CREATE TABLE ds3.Jogador(
Persongem int PRIMARY KEY,
Item_Discovery int,
Stamina int,
Classe varchar(20),
Equip_Load float(24),
Focus_Points int,
Nivel smallint

);

CREATE TABLE ds3.Atributos(
ID int PRIMARY KEY,
Designacao varchar(20),
Valor int
);

CREATE TABLE ds3.Adversario(
Moveset
Drops
Fraquezas
Resistencias
Imunidades
Personagem int PRIMARY KEY
);

CREATE TABLE ds3.Inimigo(
Tipo varchar(20),
Adversario int PRIMARY KEY
);

CREATE TABLE ds3.Boss(
Trilha_Sonora varchar(30),
Dialogo text,
Adversario int PRIMARY KEY
);

CREATE TABLE ds3.NPC(
Dialogo text,
Adversario int PRIMARY KEY
Quest text
);

CREATE TABLE ds3.Quest(
Recompensa varchar (50),
Objetivo text,
NPC int PRIMARY KEY
);

CREATE TABLE ds3.Item_Personagem(
Item int,
Personagem int,
PRIMARY KEY (Item,Personagem)
);

CREATE TABLE ds3.Item(
Nome varchar(20),
Tipo varchar(20),
ID int PRIMARY KEY
);

CREATE TABLE ds3.Item_Equipavel(
Peso float,
Durabilidade int,
Requisitos varchar(50),
Item int  PRIMARY KEY
);

CREATE TABLE ds3.Arma(
Dano int,
Item_Equipavel int  PRIMARY KEY
);

CREATE TABLE ds3.Armadura(
Defesa int,
Item_Equipavel int  PRIMARY KEY
);

CREATE TABLE ds3.Item_Nao_Equipavel(
Quantidade tinyint,
Item int  PRIMARY KEY
);

CREATE TABLE ds3.Jogador_Atributos(
Jogador int,
Atributos int
PRIMARY KEY(Jogador,Atributos)
);




