--Zonas

INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Anor Londo',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Catacombs of Carthus',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Cathedral of the Deep',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Cemetery of Ash',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Firelink Shrine','firelink_shrine.mp3')
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Irithyll of the Boreal Valley',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('High Wall of Lothric',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Undead Settlement',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Road of Sacrifices',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Archdragon Peak',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Church of Yorshka',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Consumed Kings Garden',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Farron Keep',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Irithyll Dungeon',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Kiln of the First Flame',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Profaned Capital',null)
GO
INSERT INTO ds3.Zona(Nome,Trilha_Sonora)
VALUES ('Untended Graves',null)




--Personagem_save

INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Aim_A_Cat',1704,41)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('jm2$',1340,42)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('xDemonation',934,43)
GO

--Jogador

INSERT INTO ds3.Jogador(Personagem,Item_Discovery,Stamina,Classe,Equip_Load,Focus_Points,Nivel)
VALUES (41,100,128,'Knight',70,60,85)
GO
INSERT INTO ds3.Jogador(Personagem,Item_Discovery,Stamina,Classe,Equip_Load,Focus_Points,Nivel)
VALUES (42,97,118,'Warrior',58,58,43)
GO
INSERT INTO ds3.Jogador(Personagem,Item_Discovery,Stamina,Classe,Equip_Load,Focus_Points,Nivel)
VALUES (43,93,102,'Thief',46,51,23)
GO

--Saves
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'High Wall of Lothric','1,1,1')
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'High Wall of Lothric','2,2,2')
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'High Wall of Lothric','3,3,3')

INSERT INTO ds3.Saves(Horas,ID,Ultima_localizacao,Jogador)
VALUES (DATEADD(HOUR, 83, CAST('00:00:00' AS TIME)),1,'1,1,1',41)
GO
INSERT INTO ds3.Saves(Horas,ID)
VALUES (DATEADD(HOUR, 43, CAST('00:00:00' AS TIME)),2,'2,2,2',42)
GO
INSERT INTO ds3.Saves(Horas,ID)
VALUES (DATEADD(HOUR, 17, CAST('00:00:00' AS TIME)),3,'3,3,3',43)
GO
--Atributos

INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (1,'Strength',40)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (2,'Dexterity',42)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (3,'Vitality',20)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (4,'Vigor',30)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (5,'Strength',32)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (6,'Dexterity',23)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (7,'Vitality',17)
GO
INSERT INTO ds3.Atributos(ID,Designacao,Valor)
VALUES (8,'Vigor',25)
GO


--Jogador_Atributos

INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (41,1)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (41,2)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (41,3)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (41,4)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (42,1)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (42,6)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (42,3)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (42,8)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (43,5)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (43,2)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (43,3)
GO
INSERT INTO ds3.Jogador_Atributos(Jogador,Atributos)
VALUES (43,8)
GO

--Personagens_Boss

INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Iudex Gundyr',1037,1)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Vordt of the Boreal Valley',1328,2)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Curse.Rotted Greatwood',5405,3)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Crystal Sage',2723,4)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Abyss Watchers',1548,5)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Deacons of the Deep',4099,6)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('High Lord Wolnir',15041,7)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Old Demon King',5301,8)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Pontiff Sulyvahn',5106,9)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Yhorm the Giant',27822,10)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Aldrich,Devourer of Gods',4727,11)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Dancer of the Boreal Valley',5111,12)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Dragonslayer Armour',4581,13)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Oceiros, the Consumed King',8087,14)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Champion Gundyr',4956,15)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Lothric, Younger Prince',13529,16)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Ancient Wyvern',7873,17)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Nameless King',11677,18)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Soul of Cinder',10766,19)
--Personagens_inimigo

INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Grave Warden',59,20)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Crystal Lizard',63,21)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Starved Hound',110,22)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Mimic',458,23)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Knight Slayer Tsorig',1000,24)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Winged Knight',508,25)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Sage''s Prentice',59,26)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Silver Knight',300,27)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Man-Serpent Summoner',278,28)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Ravenous Crystal Lizard',1200,29)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Caged Hollow',229,30)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Millwood Knight',830,31)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Monstrosity of Sin',521,32)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Desert Pyromancer Zoey',1100,33)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Pus of Man',841,34)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Locust Preacher',500,35)
--Personagem_NPC

INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Greirat of the Undead Settlement',1000,36)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Hawkwood',2300,37)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Siegward of Catarina',1700,38)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Yoel of Londor',1900,39)
GO
INSERT INTO ds3.Personagem(Nome,Pontos_De_Vida,ID)
VALUES ('Eygon of Carim',2100,40)


--Advers�rios_Boss

GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Coiled Sword','Fire','Dark','Poison',1)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Boreal Valley Vordt','Dark','Magic','Poison',2)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Transposing Kiln','Fire',null,'Bleed',3)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Crystal Sage','Toxic','Magic','None',4)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of the Blood of the Wolf','Lightning','Dark','Poison',5)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Small Doll Archdeacon Set','Hollowslayer Greatsword','Dark',null,6)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of High Lord Wolnir','Bracelets','Dark','Frost',7)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of the Old Demon King','Knight Slayer Tsorig','Fire','Bleed',8)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Pontiff Sulyvahn','Thrust','Bleed',null,9)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Yhorm the Giant','Storm Ruler','Physical','Bleed',10)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Aldrich','Lightning','Magic','Poison',11)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of the Dancer','Dark','Bleed','Frost',12)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Dragonslayer Armour','Frost','Dark','Bleed',13)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Consumed Oceiros','Lightning','Magic','Poison',14)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of Champion Gundyr','Lightning','Bleed',null,15)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of the Twin Princes','Frost','Dark','Toxic',16)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Dragon Head Stone','Plunging Attack','Toxic',null,17)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of the Nameless King','Fire','Lightning','Poison',18)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Soul of the Lords','Lightning','Fire','Poison',19)

--Adversario_inimigo
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Fading Soul','Hollowslayer Greatsword',null,null,20)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Various Ores','Fire','Magic','All Status Effects',21)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES (null,'Fire',null,null,22)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Various','Dark','Slash',null,23)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Black Iron Great shield',null,null,null,24)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Winged Knight Twinaxes','Frostbite','Poison',null,25)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('fading soul','Hollowslayer Greatsword','Magic',null,26)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES (null,'Thrust','Bleed','Rapport',27)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES (null,'Lightning','Magic','Rapport',28)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Titanite Scale','Fire','Slash','All Status Effects',29)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES (null,'Fire','Slash damage',null,30)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Dark Set','Farron Greatsword','Dark','Poison',31)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES (null,'Bleed',null,'Poison',32)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES (null,'Strike','Frost','Poison',33)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Ember','Fire','Dark','Poison',34)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Pale Resin','Fire','Dark',null,35)
GO

--Adversario_NPC
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Greirat''s Ashes Bandit''s Knife',null,null,null,36)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Farron Ring',null,null,null,37)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Catarina Set',null,null,null,38)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Hollow''s Ashes',null,null,null,39)
GO
INSERT INTO ds3.Adversario(Drops,Fraqueza,Resistencia,Imunidade,Personagem)
VALUES ('Morne''s Great Hammer',null,null,null,40)
GO


--Bosses

GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Iudex Gundyr',null,1)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Vordt of the Boreal Valley',null,2)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Curse-Rotted Greatwood',null,3)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Crystal Sage',null,4)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Abyss Watchers',null,5)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Deacons of the Deep',null,6)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('High Lord Wolnir',null,7)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Old Demon King',null,8)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Pontiff Sulyvahn',null,9)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Yhorm the Giant',null,10)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Aldrich, Devourer of Gods',null,11)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Dancer of the Boreal Valley',null,12)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Dragonslayer Armour',null,13)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Oceiros, the Consumed King','Ahh, you ignorant slaves. Finally taken notice have you? Of the power of my beloved Ocelotte, child of dragons.Well, I will not give him up.For he is all that I have.',14)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Champion Gundyr',null,15)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Lothric, Younger Prince','Oh, dear, another dogged contender. Welcome, Unkindled One, purloiner of Cinders. Mind you, the mantle of Lord interests me none. The fire linking curse, the legacy of lords, let it all fade into nothing. You have done quite enough, now have your rest.',16)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Ancient Wyvern',null,17)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Nameless King',null,18)
GO
INSERT INTO ds3.Boss(Trilha_Sonora,Dialogo,Adversario)
VALUES ('Soul of Cinder',null,19)

--Inimigo
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Hollow',20)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES (null,21)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Hollow',22)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES (null,23)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Phanthom',24)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Hollow',25)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Hollow',26)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Knight',27)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Reptilian',28)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES (null,29)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Undead',30)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Humanoid Undead',31)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Abyssal',32)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Abyss Creature',33)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Pyromancer',34)
GO
INSERT INTO ds3.Inimigo(Tipo,Adversario)
VALUES ('Abyssal',35)
GO

--NPC
INSERT INTO ds3.NPC(Dialogo,Adversario)
VALUES ('Oh, hello, you''re back.  And in one piece. Well, now it''s time I do my part.  Whatever trinket you need, speak up.  Just don''t ask me where I got them',36)
GO
INSERT INTO ds3.NPC(Dialogo,Adversario)
VALUES ('At the foot of Lothric Castle, an old path still runs below the tower in the Undead Settlement. It was used to transport sacrifices to the Cathedral of the Deep.  You should see where it leads. If you''ve the stones for it.',37)
GO
INSERT INTO ds3.NPC(Dialogo,Adversario)
VALUES ('This lift only goes down, but you know...With a little warming up, eventually... No, no...I''ve got to use my head. And think. Hmm... Mmm...',38)
GO
INSERT INTO ds3.NPC(Dialogo,Adversario)
VALUES ('Ohh… Ohh, then it''s true… A Champion of Ash, as I live and breathe. To be in your presence is a great honour. I am Yoel of Londor, a pilgrim as you can see, only…Somehow, I''ve failed to die as was ordained. Well, perhaps my calling lies elsewhere. Say, Champion of Ash, how does the idea of taking me into your service strike you? I was once a sorcerer. Surely I can be of use.',39)
GO
INSERT INTO ds3.NPC(Dialogo,Adversario)
VALUES ('Ah-hah, taken an interest in her, have you? Well she''s a lost cause. Couldn''t even become a Fire Keeper. After I brought her all this way, and got her all ready. She''s beyond repair, I tell you.',40)
GO

--Itens

--(Armas)

INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Brigand Twindaggers','Dagger',1)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Mail Breaker','Dagger',2)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Sunlight Straight Sword','Straight Sword',3)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Broken Straight Sword','Straight Sword',4)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Astora Straight Sword','Straight Sword',5)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Executioner''s Greatsword','Greatsword',6)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Black Knight Sword','Greatsword',7)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Drakeblood Greatsword','Greatsword',8)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Uchigatana','Katana',9)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Black Blade','Katana',10)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Eleonora','Axe',11)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Great Machete','Greataxe',12)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Drang Hammers','Hammer',13)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Dragon Tooth','Great Hammer',14)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Immolation Tinder','Halberd',15)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Great Scythe','Reaper',16)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Longbow','Bow',17)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Dragonslayer Greatbow','Greatbow',18)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Arbalest','Crossbow',19)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Avelyn','Crossbow',20)
GO

--(Armadura)

INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Mirrah Chain Helm','Helm',21)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Mirrah Chain Chest','Chest',22)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Mirrah Chain Gloves','Gloves',23)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Mirrah Chain Leggings','Leggings',24)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Drakeblood Helm','Helm',25)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Drakeblood Chest','Chest',26)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Drakeblood Gloves','Gloves',27)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Drakeblood Leggings','Leggings',28)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Elite Knight Helm','Helm',29)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Elite Knight Chest','Chest',30)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Elite Knight Gloves','Gloves',31)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Elite Knight Leggings','Leggings',32)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Executioner Helm','Helm',33)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Executioner Chest','Chest',34)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Executioner Gloves','Gloves',35)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Executioner Leggings','Leggings',36)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Northern Armor Helm','Helm',37)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Northern Armor Chest','Chest',38)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Northern Armor Gloves','Gloves',39)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Northern Armor Leggings','Leggings',40)
GO

--(Consum�veis)

INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Divine Blessing','Consumable',41)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Hidden Blessing','Consumable',42)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Siegbrau','Consumable',43)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Green Blossom','Consumable',44)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Budding Green Blossom','Consumable',45)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Repair Powder','Consumable',46)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Blue Bug Pellet','Consumable',47)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Yellow Bug Pellet','Consumable',48)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Red Bug Pellet','Consumable',49)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Black Bug Pellet','Consumable',50)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Mossfruit','Consumable',51)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Bloodred Moss Clump','Consumable',52)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Purple Moss Clump','Consumable',53)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Blooming Purple Moss Clump','Consumable',54)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Rime-Blue Moss Clump','Consumable',55)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Purging Stone','Consumable',56)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Charcoal Pine Resin','Consumable',57)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Charcoal Pine Bundle','Consumable',58)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Gold Pine Resin','Consumable',59)
GO
INSERT INTO ds3.Item(Nome,Tipo,ID)
VALUES ('Pale Pine Resin','Consumable',60)
GO

--Item Equip�vel

INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (2.5,50,1)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (1.5,50,2)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (3,70,3)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (1,30,4)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (3,80,5)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (9,85,6)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (10,100,7)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6,75,8)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (5.5,35,9)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6.5,50,10)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6.5,90,11)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (14,85,12)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (9,80,13)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (21,340,14)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (10,85,15)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (7,60,16)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (4,50,17)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (10,100,18)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6,50,19)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (7.5,45,20)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (5.7,410,21)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (10.4,370,22)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (3.3,360,23)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (5.9,360,24)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6.3,410,25)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (13.9,410,26)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (4.6,420,27)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (8.3,490,28)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (5.2,380,29)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (8.9,350,30)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (3.4,350,31)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6.8,370,32)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (6.8,460,33)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (16,460,34)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (5.3,460,35)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (9.9,460,36)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (4.8,370,37)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (10.6,370,38)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (2.3,270,39)
GO
INSERT INTO ds3.Item_Equipavel(Peso,Durabilidade,Item)
VALUES (4.3,270,40)
GO

--Arma

INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (55,1)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (89,2)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (112,3)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (70,4)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (129,5)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (131,6)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (173,7)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (83,8)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (115,9)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (122,10)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (156,11)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (167,12)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (110,13)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (188,14)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (118,15)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (105,16)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (82,17)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (126,18)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (78,19)
GO
INSERT INTO ds3.Arma(Dano,Item_Equipavel)
VALUES (64,20)
GO

--Armadura

INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (4.5,21)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (12.7,22)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (3.2,23)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (6.5,24)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (4.8,25)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (14.2,26)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (3.5,27)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (7.9,28)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (4.5,29)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (12.1,30)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (3.4,31)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (7.8,32)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (6.7,33)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (18.3,34)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (4.6,35)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (10.6,36)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (4.8,37)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (12.6,38)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (2.2,39)
GO
INSERT INTO ds3.Armadura(Defesa,Item_Equipavel)
VALUES (6.1,40)
GO

--Item N�o Equip�vel

INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (10,41)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (12,42)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (14,43)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (16,44)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (18,45)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (20,46)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (12,47)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (13,48)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (34,49)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (42,50)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (17,51)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (4,52)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (30,53)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (28,54)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (29,55)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (35,56)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (21,57)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (14,58)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (15,59)
GO
INSERT INTO ds3.Item_Nao_Equipavel(Quantidade,Item)
VALUES (16,60)
GO

--Localizacao Saves



--Localizacao Itens

INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (1,'High Wall of Lothric','51,622,111')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (2,'Firelink Shrine','827,127,679')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (3,'Profaned Capital','248,487,754')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (4,'Consumed Kings Garden','204,648,379')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (5,'Untended Graves','491,246,190')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (6,'Road of Sacrifices','668,803,974')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (7,'Irithyll of the Boreal Valley','156,680,768')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (8,'Kiln of the First Flame','189,636,126')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (9,'High Wall of Lothric','675,178,967')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (10,'Cemetery of Ash','170,16,388')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (11,'Anor Londo','47,668,78')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (12,'Undead Settlement','21,868,336')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (13,'Kiln of the First Flame','544,950,278')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (14,'Anor Londo','240,139,462')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (15,'Untended Graves','393,858,171')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (16,'Firelink Shrine','497,211,718')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (17,'Profaned Capital','910,68,999')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (18,'Archdragon Peak','438,687,410')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (19,'Cemetery of Ash','153,671,244')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (20,'Undead Settlement','237,26,745')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (21,'Profaned Capital','812,796,372')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (22,'Irithyll of the Boreal Valley','39,665,947')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (23,'Undead Settlement','354,73,454')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (24,'Anor Londo','367,222,145')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (25,'Anor Londo','942,870,671')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (26,'Undead Settlement','702,636,806')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (27,'Irithyll Dungeon','352,521,643')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (28,'Archdragon Peak','723,130,172')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (29,'Church of Yorshka','903,932,25')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (30,'Profaned Capital','507,209,815')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (31,'Undead Settlement','829,811,730')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (32,'Archdragon Peak','715,317,845')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (33,'Undead Settlement','671,62,621')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (34,'Archdragon Peak','257,994,331')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (35,'Catacombs of Carthus','180,84,966')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (36,'Cemetery of Ash','269,798,700')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (37,'Catacombs of Carthus','829,771,553')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (38,'Untended Graves','493,53,916')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (39,'High Wall of Lothric','561,579,382')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (40,'Irithyll of the Boreal Valley','318,172,329')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (41,'Cemetery of Ash','414,568,799')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (42,'Undead Settlement','705,21,553')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (43,'Undead Settlement','48,390,111')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (44,'Firelink Shrine','560,770,556')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (45,'Untended Graves','953,921,254')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (46,'Kiln of the First Flame','354,259,595')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (47,'Irithyll Dungeon','383,988,29')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (48,'Kiln of the First Flame','895,753,195')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (49,'Church of Yorshka','356,196,730')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (50,'Irithyll of the Boreal Valley','865,415,400')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (51,'Irithyll of the Boreal Valley','765,609,85')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (52,'Church of Yorshka','569,170,398')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (53,'Profaned Capital','508,297,751')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (54,'High Wall of Lothric','286,590,427')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (55,'Untended Graves','519,16,732')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (56,'Church of Yorshka','209,268,259')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (57,'High Wall of Lothric','115,721,916')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (58,'Irithyll of the Boreal Valley','980,151,25')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (59,'Consumed Kings Garden','334,223,693')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (60,'Profaned Capital','811,239,0')
GO

--Localizacao Itens Repetidas

INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (14,'Catacombs of Carthus','877,425,433')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (1,'Archdragon Peak','716,771,34')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (36,'Farron Keep','219,157,819')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (29,'Anor Londo','544,948,352')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (12,'Archdragon Peak','268,826,628')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (52,'Catacombs of Carthus','763,485,272')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (54,'Firelink Shrine','592,672,66')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (22,'Untended Graves','882,245,606')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (20,'Irithyll of the Boreal Valley','325,842,105')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (16,'Archdragon Peak','981,290,815')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (15,'Road of Sacrifices','175,395,830')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (7,'Undead Settlement','809,767,177')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (35,'Kiln of the First Flame','471,534,660')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (46,'Kiln of the First Flame','890,275,751')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (45,'Firelink Shrine','367,831,329')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (17,'Undead Settlement','628,76,402')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (49,'Undead Settlement','293,602,567')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (51,'Cemetery of Ash','514,509,812')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (31,'Kiln of the First Flame','322,848,750')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (3,'Catacombs of Carthus','895,342,2')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (5,'High Wall of Lothric','173,601,71')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (28,'Untended Graves','333,592,701')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (56,'Firelink Shrine','576,973,404')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (8,'Profaned Capital','586,249,545')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (38,'Road of Sacrifices','49,240,835')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (34,'Road of Sacrifices','891,785,395')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (60,'Firelink Shrine','394,341,756')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (53,'Irithyll of the Boreal Valley','707,941,264')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (55,'Farron Keep','56,555,991')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (49,'Profaned Capital','626,187,739')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (1,'Road of Sacrifices','410,700,814')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (23,'Cemetery of Ash','450,391,720')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (39,'Undead Settlement','365,89,105')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (26,'Undead Settlement','639,608,865')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (31,'Firelink Shrine','886,48,877')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (44,'Consumed Kings Garden','689,134,790')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (41,'Profaned Capital','417,276,741')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (25,'Irithyll of the Boreal Valley','307,95,931')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (21,'Undead Settlement','540,983,760')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (41,'Untended Graves','478,595,362')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (50,'Archdragon Peak','834,853,9')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (44,'Profaned Capital','382,501,334')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (60,'Archdragon Peak','186,469,365')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (21,'Undead Settlement','820,412,584')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (13,'Catacombs of Carthus','872,341,716')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (10,'Farron Keep','607,305,280')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (42,'Archdragon Peak','337,377,377')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (41,'Irithyll Dungeon','556,514,720')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (21,'Profaned Capital','102,902,262')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (44,'Kiln of the First Flame','664,638,137')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (44,'Farron Keep','913,347,74')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (50,'Irithyll Dungeon','763,964,996')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (9,'Firelink Shrine','626,489,995')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (46,'Undead Settlement','152,218,468')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (58,'Irithyll Dungeon','177,3,190')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (56,'Undead Settlement','722,368,25')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (28,'Farron Keep','399,702,876')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (19,'Archdragon Peak','75,575,135')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (12,'Cemetery of Ash','202,31,491')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (31,'Profaned Capital','387,640,5')
GO

--locacalização inimigo
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Anor Londo','844,605,713')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Catacombs of Carthus','809,845,704')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Cemetery of Ash','648,241,166')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Firelink Shrine','11,12,69')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Irithyll of the Boreal Valley','941,54,276')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'High Wall of Lothric','799,174,477')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Undead Settlement','951,396,688')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Road of Sacrifices','180,845,224')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Archdragon Peak','313,869,619')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Church of Yorshka','444,307,204')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Consumed Kings Garden','427,432,399')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Farron Keep','736,102,357')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Irithyll Dungeon','855,94,355')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Kiln of the First Flame','775,400,790')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Profaned Capital','104,301,308')
GO
INSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)
VALUES (null,'Untended Graves','435,490,542')
GO

--Localizacao_Advers�rio insert

INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (38,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (34,'648,241,166')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (16,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (6,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (34,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (28,'444,307,204')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (30,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (32,'444,307,204')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (9,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (31,'648,241,166')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (31,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (16,'951,396,688')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (11,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (3,'855,94,355')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (3,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (23,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (8,'799,174,477')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (2,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (5,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (18,'444,307,204')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (19,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (13,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (18,'104,301,308')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (24,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (30,'180,845,224')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (19,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (21,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (34,'313,869,619')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (25,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (5,'648,241,166')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (15,'951,396,688')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (3,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (33,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (26,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (4,'180,845,224')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (22,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (9,'855,94,355')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (38,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (4,'104,301,308')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (27,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (1,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (21,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (34,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (9,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (4,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (34,'799,174,477')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (23,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (24,'855,94,355')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (20,'799,174,477')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (33,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (17,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (9,'648,241,166')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (23,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (20,'951,396,688')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (33,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (1,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (37,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (31,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (35,'799,174,477')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (22,'855,94,355')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (40,'855,94,355')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (32,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (37,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (37,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (37,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (32,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (38,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (5,'951,396,688')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (22,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (24,'313,869,619')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (2,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (25,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (12,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (8,'941,54,276')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (15,'799,174,477')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (34,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (24,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (3,'648,241,166')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (23,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (24,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (2,'104,301,308')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (39,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (4,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (15,'180,845,224')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (40,'104,301,308')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (13,'648,241,166')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (39,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (12,'844,605,713')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (33,'313,869,619')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (12,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (10,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (17,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (33,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (26,'799,174,477')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (30,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (20,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (8,'444,307,204')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (37,'313,869,619')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (23,'951,396,688')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (24,'104,301,308')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (6,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (20,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (5,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (27,'736,102,357')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (23,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (28,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (5,'855,94,355')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (35,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (13,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (19,'951,396,688')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (13,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (38,'435,490,542')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (12,'427,432,399')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (26,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (11,'104,301,308')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (18,'809,845,704')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (20,'775,400,790')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (38,'11,12,69')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (25,'313,869,619')
GO
INSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)
VALUES (29,'951,396,688')
GO
