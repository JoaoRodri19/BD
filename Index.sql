CREATE NONCLUSTERED INDEX indexInventario ON ds3.Item_Personagem(Item) WITH (FILLFACTOR = 85, PAD_INDEX = ON);

CREATE NONCLUSTERED INDEX indexNome ON ds3.Personagem(Nome);