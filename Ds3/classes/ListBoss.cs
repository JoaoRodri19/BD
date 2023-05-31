using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{
    public class ListBoss
    {
        private Boss _boss;
        private Localizacao _loc;

        public ListBoss()
        {

        }

        public ListBoss(Boss boss, Localizacao loc)
        {
            this._boss = boss;
            this._loc = loc;
        }

        public override String ToString()
        {
            return $"Nome: {this._boss.Nome}, HP: {this._boss.Pontos_De_Vida}, Zona: {this._loc.Zona}";
        }
    
        public Boss boss
        {
            get { return this._boss; }
            set { this._boss = value; }
        }

        public Localizacao loc
        {
            get { return this._loc; }
            set { this._loc = value; }
        }
    }
}