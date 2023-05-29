using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Atributos
    {
        private String _ID;
        private String _Designacao;
        private String _Valor;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public String Designacao
        {
            get { return _Designacao; }
            set { _Designacao = value; }
        }

        public String Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public String toString()
        {
            return "";
        }

        public Atributos() : base()
        {
        }

        public Atributos(String ID, String Designacao, String Valor) : base()
        {
            this._ID = ID;
            this._Designacao = Designacao;
            this._Valor = Valor;
        }
    }
}