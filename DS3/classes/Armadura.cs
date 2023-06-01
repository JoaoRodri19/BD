using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Armadura : Item_Equipavel
    {
        private String _Defesa;
        private String _Item_Equipavel;

        public String Defesa
        {
            get { return _Defesa; }
            set { _Defesa = value; }
        }

        public String Item_Equipavel
        {
            get { return _Item_Equipavel; }
            set { _Item_Equipavel = value; }
        }
        public override string ToString()
        {
            return "ID: "+this._Item_Equipavel + ";Nome: "+this.Nome +";Defesa: "+this.Defesa;
        }

        public Armadura() : base()
        {
        }

        public Armadura(Item item) : base()
        {
            this.ID = item.ID;
            this.Nome = item.Nome;
            this.Tipo = item.Tipo;
        }

        public Armadura(String Defesa, String Item_Equipavel) : base()
        {
            this._Defesa = Defesa;
            this._Item_Equipavel = Item_Equipavel;
        }
    }
}