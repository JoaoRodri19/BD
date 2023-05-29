using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Quest
    {
        private String _Recompensa;
        private String _Objetivo;

        public String Recompensa
        {
            get { return _Recompensa; }
            set { _Recompensa = value; }
        }

        public String Objetivo
        {
            get { return _Objetivo; }
            set { _Objetivo = value; }
        }
        public String toString()
        {
            return "";
        }

        public Quest() : base()
        {
        }

        public Quest(String Recompensa, String Objetivo) : base()
        {
            this._Recompensa = Recompensa;
            this._Objetivo = Objetivo;
        }
    }
}