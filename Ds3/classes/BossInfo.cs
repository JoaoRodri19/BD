using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class BossInfo
    {
        private String _Nome;
        private String _Hp;
        private String _Zona;
  
        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public String Hp
        {
            get { return _Hp; }
            set { _Hp = value; }
        }

        public String Zona
        {
            get { return _Zona; }
            set { _Zona = value; }
        }



        public override string ToString()
        {
            return $"Nome: {Nome}, HP: {Hp}, Zona: {Zona}";
        }

        public BossInfo() : base()
        {
        }

        public BossInfo(String Nome, String Hp, String Zona) : base()
        {
            this._Nome = Nome;
            this._Zona =Zona;
            this._Hp = Hp;
        }
}
}