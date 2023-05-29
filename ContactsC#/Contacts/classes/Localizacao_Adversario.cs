using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Localizacao_Adversario
    {
        private String _Localizacao;
        private String _Adversario;

        public String Localizacao
        {
            get { return _Localizacao; }
            set { _Localizacao = value; }
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

        public Localizacao_Adversario() : base()
        {
        }

        public Localizacao_Adversario(String Localizacao, String Adversario) : base()
        {
            this._Localizacao = Localizacao;
            this._Adversario = Adversario;
        }
    }
}