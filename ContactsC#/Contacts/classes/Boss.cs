using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Boss
    {
        private String _Trilha_Sonora;
        private String _Dialogo;
        private String _Adversario;

        public String Trilha_Sonora
        {
            get { return _Trilha_Sonora; }
            set { _Trilha_Sonora = value; }
        }

        public String Dialogo
        {
            get { return _Dialogo; }
            set { _Dialogo = value; }
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

        public Boss() : base()
        {
        }

        public Boss(String Trilha_Sonora, String Dialogo, String Adversario) : base()
        {
            this._Trilha_Sonora = Trilha_Sonora;
            this._Dialogo = Dialogo;
            this._Adversario = Adversario;
        }
    }
}