using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Jogador_Atributos
    {
        private String _Jogador;
        private String _Atributos;

        public String Jogador
        {
            get { return _Jogador; }
            set { _Jogador = value; }
        }

        public String Atributos
        {
            get { return _Atributos; }
            set { _Atributos = value; }
        }
        public String toString()
        {
            return "";
        }

        public Jogador_Atributos() : base()
        {
        }

        public Jogador_Atributos(String Jogador, String Atributos) : base()
        {
            this._Jogador = Jogador;
            this._Atributos = Atributos;
        }
    }
}