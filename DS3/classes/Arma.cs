using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Arma : Item_Equipavel
    {
        private String _Dano;
        private String _Item_Equipavel;

        public String Dano
        {
            get { return _Dano; }
            set { _Dano = value; }
        }

        public String Item_Equipavel
        {
            get { return _Item_Equipavel; }
            set { _Item_Equipavel = value; }
        }
        public String toString()
        {
            return "";
        }

        public Arma() : base()
        {
        }

        public Arma(Item item)
        {
            this.ID = item.ID;
            this.Nome = item.Nome;
            this.Tipo = item.Tipo;
        }

        public Arma(String Dano, String Item_Equipavel) : base()
        {
            this._Dano = Dano;
            this._Item_Equipavel = Item_Equipavel;
        }
    }
}