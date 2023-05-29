using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Personagem
    {
        private String _Nome;
        private String _Pontos_De_Vida;
        private String _ID;

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public String Pontos_De_Vida
        {
            get { return _Pontos_De_Vida; }
            set { _Pontos_De_Vida = value; }
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

        public Personagem() : base()
        {
        }

        public Personagem(String Personagem, String Pontos_De_Vida, String ID) : base()
        {
            this._Nome = Personagem;
            this._Pontos_De_Vida = Pontos_De_Vida;
            this._ID = ID;
        }
    }
}