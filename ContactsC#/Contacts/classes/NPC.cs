using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class NPC
    {
        private String _Dialogo;
        private String _Adversario;

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

        public NPC() : base()
        {
        }

        public NPC(String Dialogo, String Adversario) : base()
        {
            this._Dialogo = Dialogo;
            this._Adversario = Adversario;
        }
    }
}