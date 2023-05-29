using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Adversario
    {
        private String _Drops;
        private String _Fraqueza;
        private String _Resistencia;
        private String _Imunidade;
        private String _Personagem;

        public String Drops
        {
            get { return _Drops; }
            set { _Drops = value; }
        }

        public String Fraqueza
        {
            get { return _Fraqueza; }
            set { _Fraqueza = value; }
        }

        public String Resistencia
        {
            get { return _Resistencia; }
            set { _Resistencia = value; }
        }

        public String Imunidade
        {
            get { return _Imunidade; }
            set { _Imunidade = value; }
        }

        public String Personagem
        {
            get { return _Personagem; }
            set { _Personagem = value; }
        }
        public String toString()
        {
            return "";
        }

        public Adversario() : base()
        {
        }

        public Adversario(String Drops, String Fraqueza, String Resistencia, String Imunidade, String Personagem) : base()
        {
            this._Drops = Drops;
            this._Fraqueza = Fraqueza;
            this._Resistencia = Resistencia;
            this._Imunidade = Imunidade;
            this._Personagem = Personagem;
        }
}
}