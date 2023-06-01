using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Item_Nao_Equipavel : Item
    {
        private String _Quantidade;
        private String _Item;

        public String Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        public String Item
        {
            get { return _Item; }
            set { _Item = value; }
        }
        public override string ToString()
        {
            return "ID: " + this._Item + ";Nome: " + this.Nome;
        }

        public Item_Nao_Equipavel() : base()
        {
        }

        public Item_Nao_Equipavel(Item item) : base()
        {
            this.ID = item.ID;
            this.Nome = item.Nome;
            this.Tipo = item.Tipo;
        }

        public Item_Nao_Equipavel(String Quantidade, String Item) : base()
        {
            this._Quantidade = Quantidade;
            this._Item = Item;
        }
    }
}