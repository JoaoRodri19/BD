using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Inimigo
    {
        private String _Tipo;
        private String _Adversario;

        public String Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public String Adversario
        {
            get { return _Adversario; }
            set { _Adversario = value; }
        }
        public String toString()
        {
            return "";
        }

        public Inimigo() : base()
        {
        }

        public Inimigo(String Tipo, String Adversario) : base()
        {
            this._Tipo = Tipo;
            this._Adversario = Adversario;
        }
    }
}