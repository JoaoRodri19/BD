SELECT * FROM ds3.Boss
JOIN ds3.Adversario on Boss.Adversario = Adversario.Personagem 
JOIN ds3.Personagem on ID = Adversario.Personagem 
JOIN ds3.Localizacao_Adversario on Adversario.Personagem = Localizacao_Adversario.Adversario
JOIN ds3.Localizacao on Localizacao.coordenadas =  Localizacao_Adversario.coordenadas
JOIN ds3.Zona on Zona.Nome = Localizacao.Zona




