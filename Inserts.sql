--INSERTS ZONAS

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

--INSERTS BOSSES
--Personagem

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

--Adversario

GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Coiled Sword','Fire','Dark','Poison',1)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Boreal Valley Vordt','Dark','Magic','Poison',2)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Transposing Kiln','Fire',null,'Bleed',3)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Crystal Sage','Toxic','Magic','None',4)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of the Blood of the Wolf','Lightning','Dark','Poison',5)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Small Doll Archdeacon Set','Hollowslayer Greatsword','Dark',null,6)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of High Lord Wolnir','Bracelets','Dark','Frost',7)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of the Old Demon King','Knight Slayer Tsorig','Fire','Bleed',8)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Pontiff Sulyvahn','Thrust','Bleed',null,9)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Yhorm the Giant','Storm Ruler','Physical','Bleed',10)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Aldrich','Lightning','Magic','Poison',11)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of the Dancer','Dark','Bleed','Frost',12)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Dragonslayer Armour','Frost','Dark','Bleed',13)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Consumed Oceiros','Lightning','Magic','Poison',14)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of Champion Gundyr','Lightning','Bleed',null,15)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of the Twin Princes','Frost','Dark','Toxic',16)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Dragon Head Stone','Plunging Attack','Toxic',null,17)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of the Nameless King','Fire','Lightning','Poison',18)
GO
INSERT INTO ds3.Adversario(Moveset,Drops,Fraquezas,Resistencias,Imunidades,Personagem)
VALUES ('','Soul of the Lords','Lightning','Fire','Poison',19)

--Boss

GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',1)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',2)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',3)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',4)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',5)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',6)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',7)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',8)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',9)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',10)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',11)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',12)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',13)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',14)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',15)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',16)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',17)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',18)
GO
INSERT INTO ds3.Boss('','',1)
VALUES ('','',19)