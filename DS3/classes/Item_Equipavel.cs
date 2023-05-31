using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Item_Equipavel : Item
    {
        private String _Peso;
        private String _Durabilidade;
        private String _Item;

        public String Peso
        {
            get { return _Peso; }
            set { _Peso = value; }
        }

        public String Durabilidade
        {
            get { return _Durabilidade; }
            set { _Durabilidade = value;}
        }

        public String Item
        {
            get { return _Item; }
            set { _Item = value; }
        }
        public String toString()
        {
            return "";
        }

        public Item_Equipavel() : base()
        {
        }

        public Item_Equipavel(Item item) : base()
        {
            this.Nome = item.Nome;
            this.ID = item.ID;
            this.Tipo = item.Tipo;
        }

        public Item_Equipavel(String Peso, String Durabilidade, String Item) : base()
        {
            this._Peso = Peso;
            this._Durabilidade = Durabilidade;
            this._Item = Item;
        }
    }
}