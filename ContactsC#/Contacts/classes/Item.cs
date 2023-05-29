using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Item
    {
        private String _Nome;
        private String _Tipo;
        private String _ID;

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public String Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public String toString()
        {
            return "";
        }

        public Item() : base()
        {
        }

        public Item(String Nome, String Tipo, String ID) : base()
        {
            this._Nome = Nome;
            this._Tipo = Tipo;
            this._ID = ID;
        }
    }
}