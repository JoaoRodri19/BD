import random

res = ""
res1 = ""
I = 1
N = 120
coordenadas = ['844,605,713','809,845,704','648,241,166','11,12,69','941,54,276','799,174,477','951,396,688','180,845,224','313,869,619','444,307,204','427,432,399','736,102,357','855,94,355','775,400,790','104,301,308','435,490,542']
zonas = ['Anor Londo','Catacombs of Carthus','Cemetery of Ash','Firelink Shrine','Irithyll of the Boreal Valley','High Wall of Lothric','Undead Settlement','Road of Sacrifices','Archdragon Peak','Church of Yorshka','Consumed Kings Garden','Farron Keep','Irithyll Dungeon','Kiln of the First Flame','Profaned Capital','Untended Graves']
lenght = len(zonas)
for i in range(I,N+1):
    res1+="\nINSERT INTO ds3.Localizacao(Item,Zona,Coordenadas)\nVALUES ("+"null"+", null, '"+zonas[random.randint(0,lenght-1)]+"','"+str(random.randint(0,1000))+","+str(random.randint(0,1000))+","+str(random.randint(0,1000))+"')\nGO"
    
for i in range (N):
    res+="\nINSERT INTO ds3.Localizacao_Adversario(Adversario,Localizacao)\nVALUES ("+str(random.randint(1,40))+",'"+coordenadas[random.randint(0,len(coordenadas)-1)]+"')\nGO"
print(res)

