using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Item_Nao_Equipavel
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
        public String toString()
        {
            return "";
        }

        public Item_Nao_Equipavel() : base()
        {
        }

        public Item_Nao_Equipavel(String Quantidade, String Item) : base()
        {
            this._Quantidade = Quantidade;
            this._Item = Item;
        }
    }
}