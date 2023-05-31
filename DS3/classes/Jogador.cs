using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Ds3
{

    [Serializable()]
    public class Jogador : Personagem
    {
        private String _Personagem;
        private String _Item_Discovery;
        private String _Stamina;
        private String _Classe;
        private String _Equip_Load;
        private String _Focus_Points;
        private String _Nivel;

        public String Personagem
        {
            get { return _Personagem; }
            set { _Personagem = value; }
        }

        public String Item_Discovery
        {
            get { return _Item_Discovery; }
            set { _Item_Discovery = value; }
        }

        public String Stamina
        {
            get { return _Stamina; }
            set { _Stamina = value; }
        }

        public String Classe
        {
            get { return _Classe; }
            set { _Classe = value; }
        }

        public String Equip_Load
        {
            get { return _Equip_Load; }
            set { _Equip_Load = value; }
        }

        public String Focus_Points
        {
            get { return _Focus_Points; }
            set { _Focus_Points = value; }
        }

        public String Nivel
        {
            get { return _Nivel; }
            set { _Nivel = value; }
        }

        public Jogador() : base()
        {
        }

        public Jogador(String Personagem, String Item_Discovery, String Stamina, String Classe, String Equip_Load, String Focus_Points, String Nivel) : base()
        {
            this._Personagem = Personagem;
            this._Item_Discovery = Item_Discovery;
            this._Stamina = Stamina;
            this._Classe = Classe;
            this._Equip_Load = Equip_Load;
            this._Focus_Points = Focus_Points;
            this._Nivel = Nivel;
        }
    }
}