using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Zona
{

    [Serializable()]
    public class Zona
    {
        private String _Nome;
        private String _Trilha_sonora;

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public String Trilha_sonora
        {
            get { return _Trilha_sonora; }
            set { _Trilha_sonora = value; }
        }
        public String toString()
        {
            return "";
        }

        public Zona() : base()
        {
        }

        public Zona(String Nome, String Trilha_sonora) : base()
        {
            this._Nome = Nome;
            this._Trilha_sonora = Trilha_sonora;
        }
    }
}