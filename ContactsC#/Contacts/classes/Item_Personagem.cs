using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Item_Personagem
    {
        private String _Item;
        private String _Personagem;

        public String Item
        {
            get { return _Item; }
            set { _Item = value; }
        }

        public String Personagem
        {
            get { return _Personagem; }
            set { _Personagem = value; }
        }
        public String toString()
        {
            return "";
        }

        public Item_Personagem() : base()
        {
        }

        public Item_Personagem(String Item, String Personagem) : base()
        {
            this._Item = Item;
            this._Personagem = Personagem;
        }
    }
}