using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{
    public class ListSaves
    {
        private Saves _save;
        private Jogador _jog;


        public ListSaves()
        {

        }

        public ListSaves(Saves save, Jogador jog, Personagem per)
        {
            this._save = save;
            this._jog = jog;
        }

        public override String ToString()
        {
            return $"Nome: {this._jog.Nome}, Horas: {this._save.Horas}, Classe: {this._jog.Classe},Ultima Localização: {this._save.Ultima_localizacao}";
        }
    
        public Saves save
        {
            get { return this._save; }
            set { this._save = value; }
        }

        public Jogador jog
        {
            get { return this._jog; }
            set { this._jog = value; }
        }

    }
}