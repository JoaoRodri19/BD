using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Localizacao
    {
        private String _Item;
        private String _Zona;
        private String _Coordenadas;

        public String Item
        {
            get { return _Item; }
            set { _Item = value; }
        }

        public String Zona
        {
            get { return _Zona; }
            set { _Zona = value; }
        }

        public String Coordenadas
        {
            get { return _Coordenadas; }
            set { _Coordenadas = value; }
        }
        public String toString()
        {
            return "";
        }

        public Localizacao() : base()
        {
        }

        public Localizacao(String Item, String Zona, String Coordenadas) : base()
        {
            this._Item = Item;
            this._Zona = Zona;
            this._Coordenadas = Coordenadas;
        }
    }
}