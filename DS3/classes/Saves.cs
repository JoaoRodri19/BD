
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Saves
    {
        private String _ID;
        private String _Ultima_localizacao;
        private String _Horas;
        private String _Jogador;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        public String Ultima_localizacao
        {
            get { return _Ultima_localizacao; }
            set { _Ultima_localizacao = value; }
        }

        public String Horas
        {
            get { return _Horas; }
            set { _Horas = value; }
        }

        public String Jogador
        {
            get { return _Jogador; }
            set { _Jogador = value; }
        }

        public override String ToString()
        {
            return "\nJogador:" + _Jogador + "\nHoras:" + _Horas;
        }

        public Saves() : base()
        {
        }

        public Saves(String ID, String Ultima_localizacao, String Horas, String Jogador) : base()
        {
            this._ID = ID;
            this._Ultima_localizacao = Ultima_localizacao;
            this._Horas = Horas;
            this._Jogador = Jogador;
        }


    }
}

