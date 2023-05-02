

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
Personagem int PRIMARY KEY,
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
Moveset			varchar(30),
Drops			varchar(30),
Fraquezas		varchar(30),
Resistencias	varchar(30),
Imunidades		varchar(30),
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
Adversario int PRIMARY KEY,
Quest int
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

alter table ds3.Localizacao add constraint fk_localizacao_Item foreign key (Item) references  ds3.Item (ID);
alter table ds3.Localizacao add constraint fk_localizacao_Zona foreign key (Zona) references  ds3.Zona (Nome);

alter table ds3.Localizacao_Adversário add constraint fk_localizacao_adversario_localizacao foreign key (Localizacao) references  ds3.Localizacao (Coordenadas);
alter table ds3.Localizacao_Adversário add constraint fk_localizacao_adversario_adversario foreign key (Adversario) references  ds3.Adversario (Personagem);

alter table ds3.Saves add constraint fk_Saves_Ultima_localizacao foreign key (Ultima_localizacao) references  ds3.Localizacao (Coordenadas);
alter table ds3.Saves add constraint fk_Saves_Jogador foreign key (Jogador) references  ds3.Jogador (Personagem);

alter table ds3.Adversario add constraint fk_Adversario_Personagem foreign key (Personagem) references  ds3.Personagem (ID);

alter table ds3.Inimigo add constraint fk_Inimigo_Adversario foreign key (Adversario) references ds3.Adversario (Personagem);

alter table ds3.Boss add constraint fk_Boss_Adversario foreign key (Adversario) references ds3.Adversario (Personagem);

alter table ds3.NPC add constraint fk_NPC_Adversario foreign key (Adversario) references ds3.Adversario (Personagem);

alter table ds3.Quest add constraint fk_Quest_NPC foreign key (NPC) references ds3.NPC (Adversario);

alter table ds3.Item_Personagem add constraint fk_Item_Personagem_Item foreign key (Item) references ds3.Item (ID);
alter table ds3.Item_Personagem add constraint fk_Item_Personagem_Personagem foreign key (Personagem) references ds3.Personagem (ID);

alter table ds3.Item_Equipavel add constraint fk_Item_Equipavel_Item foreign key (Item) references ds3.Item (ID);

alter table ds3.Arma add constraint fk_Arma_Item_Equipavel foreign key (Item_Equipavel) references ds3.Item_Equipavel(Item);

alter table ds3.Armadura add constraint fk_Armadura_Item_Equipavel foreign key (Item_Equipavel) references ds3.Item_Equipavel(Item);

alter table ds3.Item_Nao_Equipavel add constraint fk_Item_Nao_Equipavel_Item foreign key (Item) references ds3.Item (ID);

alter table ds3.Jogador_Atributos add constraint fk_Jogador_Atributos_Jogador foreign key (Jogador) references ds3.Jogador (Personagem);
alter table ds3.Jogador_Atributos add constraint fk_Jogador_Atributos_Atributos foreign key (Atributos) references ds3.Atributos (ID);






