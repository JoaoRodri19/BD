﻿namespace Ds3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label_Jogador0 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHP2 = new System.Windows.Forms.TextBox();
            this.txtHP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.DropBoss = new System.Windows.Forms.ComboBox();
            this.labelZona = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label_Coordenadas = new System.Windows.Forms.Label();
            this.txtItem_Discovery = new System.Windows.Forms.TextBox();
            this.txtStamina = new System.Windows.Forms.TextBox();
            this.label_dialogo = new System.Windows.Forms.Label();
            this.label_Trilha_Sonora = new System.Windows.Forms.Label();
            this.label_Resistencia = new System.Windows.Forms.Label();
            this.label_Fraqueza = new System.Windows.Forms.Label();
            this.Label_Drops = new System.Windows.Forms.Label();
            this.txtEquip_Load = new System.Windows.Forms.TextBox();
            this.txtFocusPoints = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtUltima_Localizacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label_Imunidade = new System.Windows.Forms.Label();
            this.Label_HP = new System.Windows.Forms.Label();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.LoadSaves = new System.Windows.Forms.ToolStripMenuItem();
            this.DropClass = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 535);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 535);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 535);
            this.panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(550, 535);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.panel3.Controls.Add(this.txtClass);
            this.panel3.Controls.Add(this.DropClass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtHP2);
            this.panel3.Controls.Add(this.txtHP1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonFiltrar);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtFiltrar);
            this.panel3.Controls.Add(this.DropBoss);
            this.panel3.Controls.Add(this.labelZona);
            this.panel3.Controls.Add(this.txtHP);
            this.panel3.Controls.Add(this.label_Coordenadas);
            this.panel3.Controls.Add(this.txtItem_Discovery);
            this.panel3.Controls.Add(this.txtStamina);
            this.panel3.Controls.Add(this.label_dialogo);
            this.panel3.Controls.Add(this.label_Trilha_Sonora);
            this.panel3.Controls.Add(this.label_Resistencia);
            this.panel3.Controls.Add(this.label_Fraqueza);
            this.panel3.Controls.Add(this.Label_Drops);
            this.panel3.Controls.Add(this.txtEquip_Load);
            this.panel3.Controls.Add(this.txtFocusPoints);
            this.panel3.Controls.Add(this.txtNivel);
            this.panel3.Controls.Add(this.txtHoras);
            this.panel3.Controls.Add(this.txtUltima_Localizacao);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.Label_Imunidade);
            this.panel3.Controls.Add(this.Label_HP);
            this.panel3.Controls.Add(this.Label_Nome);
            this.panel3.Controls.Add(this.bttnDelete);
            this.panel3.Controls.Add(this.bttnAdd);
            this.panel3.Controls.Add(this.bttnCancel);
            this.panel3.Controls.Add(this.bttnOK);
            this.panel3.Controls.Add(this.bttnEdit);
            this.panel3.Controls.Add(this.Label4);
            this.panel3.Controls.Add(this.Label_Jogador0);
            this.panel3.Controls.Add(this.Label9);
            this.panel3.Controls.Add(this.Label7);
            this.panel3.Controls.Add(this.Label6);
            this.panel3.Controls.Add(this.Label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 535);
            this.panel3.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 141;
            // 
            // Label_Jogador0
            // 
            this.Label_Jogador0.Location = new System.Drawing.Point(0, 0);
            this.Label_Jogador0.Name = "Label_Jogador0";
            this.Label_Jogador0.Size = new System.Drawing.Size(100, 23);
            this.Label_Jogador0.TabIndex = 142;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(0, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 143;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 23);
            this.Label7.TabIndex = 144;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(0, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 145;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(0, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 146;
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(0, 0);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(100, 22);
            this.txtZIP.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadSaves});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1194, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(273, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 231;
            this.label1.Text = "a";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(112, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 230;
            this.label3.Text = "Desde";
            // 
            // txtHP2
            // 
            this.txtHP2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHP2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHP2.Location = new System.Drawing.Point(312, 66);
            this.txtHP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtHP2.Name = "txtHP2";
            this.txtHP2.ReadOnly = true;
            this.txtHP2.Size = new System.Drawing.Size(56, 26);
            this.txtHP2.TabIndex = 229;
            // 
            // txtHP1
            // 
            this.txtHP1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHP1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHP1.Location = new System.Drawing.Point(196, 66);
            this.txtHP1.Margin = new System.Windows.Forms.Padding(4);
            this.txtHP1.Name = "txtHP1";
            this.txtHP1.ReadOnly = true;
            this.txtHP1.Size = new System.Drawing.Size(56, 26);
            this.txtHP1.TabIndex = 228;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 227;
            this.label2.Text = "HP";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFiltrar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonFiltrar.Location = new System.Drawing.Point(469, 39);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(104, 34);
            this.buttonFiltrar.TabIndex = 226;
            this.buttonFiltrar.Text = "Filtrar";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 225;
            this.label8.Text = "Filtrar";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFiltrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFiltrar.Location = new System.Drawing.Point(312, 11);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.ReadOnly = true;
            this.txtFiltrar.Size = new System.Drawing.Size(118, 26);
            this.txtFiltrar.TabIndex = 224;
            // 
            // DropBoss
            // 
            this.DropBoss.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropBoss.FormattingEnabled = true;
            this.DropBoss.Location = new System.Drawing.Point(131, 11);
            this.DropBoss.Name = "DropBoss";
            this.DropBoss.Size = new System.Drawing.Size(121, 24);
            this.DropBoss.TabIndex = 223;
            // 
            // labelZona
            // 
            this.labelZona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelZona.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelZona.Location = new System.Drawing.Point(336, 348);
            this.labelZona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.labelZona.Name = "labelZona";
            this.labelZona.Size = new System.Drawing.Size(128, 20);
            this.labelZona.TabIndex = 222;
            this.labelZona.Text = "Pontos De Vida";
            // 
            // txtHP
            // 
            this.txtHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHP.Location = new System.Drawing.Point(339, 370);
            this.txtHP.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtHP.Name = "txtHP";
            this.txtHP.ReadOnly = true;
            this.txtHP.Size = new System.Drawing.Size(180, 26);
            this.txtHP.TabIndex = 221;
            // 
            // label_Coordenadas
            // 
            this.label_Coordenadas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Coordenadas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Coordenadas.Location = new System.Drawing.Point(336, 281);
            this.label_Coordenadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_Coordenadas.Name = "label_Coordenadas";
            this.label_Coordenadas.Size = new System.Drawing.Size(162, 20);
            this.label_Coordenadas.TabIndex = 220;
            this.label_Coordenadas.Text = "Item Discovery";
            // 
            // txtItem_Discovery
            // 
            this.txtItem_Discovery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItem_Discovery.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtItem_Discovery.Location = new System.Drawing.Point(339, 303);
            this.txtItem_Discovery.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtItem_Discovery.Name = "txtItem_Discovery";
            this.txtItem_Discovery.ReadOnly = true;
            this.txtItem_Discovery.Size = new System.Drawing.Size(180, 26);
            this.txtItem_Discovery.TabIndex = 219;
            // 
            // txtStamina
            // 
            this.txtStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStamina.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtStamina.Location = new System.Drawing.Point(339, 244);
            this.txtStamina.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtStamina.Name = "txtStamina";
            this.txtStamina.ReadOnly = true;
            this.txtStamina.Size = new System.Drawing.Size(181, 26);
            this.txtStamina.TabIndex = 218;
            // 
            // label_dialogo
            // 
            this.label_dialogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_dialogo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_dialogo.Location = new System.Drawing.Point(336, 222);
            this.label_dialogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_dialogo.Name = "label_dialogo";
            this.label_dialogo.Size = new System.Drawing.Size(128, 20);
            this.label_dialogo.TabIndex = 217;
            this.label_dialogo.Text = "Stamina";
            // 
            // label_Trilha_Sonora
            // 
            this.label_Trilha_Sonora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Trilha_Sonora.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Trilha_Sonora.Location = new System.Drawing.Point(337, 160);
            this.label_Trilha_Sonora.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label_Trilha_Sonora.Name = "label_Trilha_Sonora";
            this.label_Trilha_Sonora.Size = new System.Drawing.Size(140, 20);
            this.label_Trilha_Sonora.TabIndex = 215;
            this.label_Trilha_Sonora.Text = "Class";
            // 
            // label_Resistencia
            // 
            this.label_Resistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Resistencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Resistencia.Location = new System.Drawing.Point(28, 275);
            this.label_Resistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_Resistencia.Name = "label_Resistencia";
            this.label_Resistencia.Size = new System.Drawing.Size(96, 20);
            this.label_Resistencia.TabIndex = 214;
            this.label_Resistencia.Text = "Nivel";
            // 
            // label_Fraqueza
            // 
            this.label_Fraqueza.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Fraqueza.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Fraqueza.Location = new System.Drawing.Point(28, 398);
            this.label_Fraqueza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_Fraqueza.Name = "label_Fraqueza";
            this.label_Fraqueza.Size = new System.Drawing.Size(96, 20);
            this.label_Fraqueza.TabIndex = 213;
            this.label_Fraqueza.Text = "Equip Load";
            // 
            // Label_Drops
            // 
            this.Label_Drops.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Drops.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Drops.Location = new System.Drawing.Point(28, 331);
            this.Label_Drops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_Drops.Name = "Label_Drops";
            this.Label_Drops.Size = new System.Drawing.Size(172, 20);
            this.Label_Drops.TabIndex = 212;
            this.Label_Drops.Text = "Focus Points";
            // 
            // txtEquip_Load
            // 
            this.txtEquip_Load.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEquip_Load.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtEquip_Load.Location = new System.Drawing.Point(30, 420);
            this.txtEquip_Load.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtEquip_Load.Name = "txtEquip_Load";
            this.txtEquip_Load.ReadOnly = true;
            this.txtEquip_Load.Size = new System.Drawing.Size(181, 26);
            this.txtEquip_Load.TabIndex = 211;
            // 
            // txtFocusPoints
            // 
            this.txtFocusPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFocusPoints.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFocusPoints.Location = new System.Drawing.Point(30, 364);
            this.txtFocusPoints.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtFocusPoints.Name = "txtFocusPoints";
            this.txtFocusPoints.ReadOnly = true;
            this.txtFocusPoints.Size = new System.Drawing.Size(181, 26);
            this.txtFocusPoints.TabIndex = 210;
            // 
            // txtNivel
            // 
            this.txtNivel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNivel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNivel.Location = new System.Drawing.Point(31, 297);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(180, 26);
            this.txtNivel.TabIndex = 209;
            // 
            // txtHoras
            // 
            this.txtHoras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHoras.Location = new System.Drawing.Point(30, 244);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(181, 26);
            this.txtHoras.TabIndex = 208;
            // 
            // txtUltima_Localizacao
            // 
            this.txtUltima_Localizacao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUltima_Localizacao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtUltima_Localizacao.Location = new System.Drawing.Point(30, 195);
            this.txtUltima_Localizacao.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtUltima_Localizacao.Name = "txtUltima_Localizacao";
            this.txtUltima_Localizacao.ReadOnly = true;
            this.txtUltima_Localizacao.Size = new System.Drawing.Size(181, 26);
            this.txtUltima_Localizacao.TabIndex = 206;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNome.Location = new System.Drawing.Point(31, 139);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(180, 26);
            this.txtNome.TabIndex = 204;
            // 
            // Label_Imunidade
            // 
            this.Label_Imunidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Imunidade.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Imunidade.Location = new System.Drawing.Point(27, 222);
            this.Label_Imunidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_Imunidade.Name = "Label_Imunidade";
            this.Label_Imunidade.Size = new System.Drawing.Size(96, 20);
            this.Label_Imunidade.TabIndex = 207;
            this.Label_Imunidade.Text = "Horas";
            // 
            // Label_HP
            // 
            this.Label_HP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_HP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_HP.Location = new System.Drawing.Point(27, 173);
            this.Label_HP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_HP.Name = "Label_HP";
            this.Label_HP.Size = new System.Drawing.Size(173, 20);
            this.Label_HP.TabIndex = 205;
            this.Label_HP.Text = "Ultima localização";
            // 
            // Label_Nome
            // 
            this.Label_Nome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Nome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Nome.Location = new System.Drawing.Point(28, 111);
            this.Label_Nome.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(96, 20);
            this.Label_Nome.TabIndex = 203;
            this.Label_Nome.Text = "Nome";
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnDelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnDelete.Location = new System.Drawing.Point(421, 480);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(128, 39);
            this.bttnDelete.TabIndex = 202;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click_1);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnAdd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnAdd.Location = new System.Drawing.Point(276, 480);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(128, 39);
            this.bttnAdd.TabIndex = 198;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click_1);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnCancel.Location = new System.Drawing.Point(421, 420);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(128, 39);
            this.bttnCancel.TabIndex = 200;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.Visible = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click_1);
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnOK.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnOK.Location = new System.Drawing.Point(276, 420);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(4);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(128, 39);
            this.bttnOK.TabIndex = 201;
            this.bttnOK.Text = "OK";
            this.bttnOK.Visible = false;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click_1);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnEdit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnEdit.Location = new System.Drawing.Point(421, 420);
            this.bttnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(128, 39);
            this.bttnEdit.TabIndex = 199;
            this.bttnEdit.Text = "Edit";
            // 
            // LoadSaves
            // 
            this.LoadSaves.Name = "LoadSaves";
            this.LoadSaves.Size = new System.Drawing.Size(53, 22);
            this.LoadSaves.Text = "Load";
            // 
            // DropClass
            // 
            this.DropClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropClass.FormattingEnabled = true;
            this.DropClass.Location = new System.Drawing.Point(340, 187);
            this.DropClass.Name = "DropClass";
            this.DropClass.Size = new System.Drawing.Size(179, 24);
            this.DropClass.TabIndex = 232;
            this.DropClass.SelectedIndexChanged += new System.EventHandler(this.DropClass_SelectedIndexChanged);
            // 
            // txtClass
            // 
            this.txtClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtClass.Location = new System.Drawing.Point(340, 188);
            this.txtClass.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(181, 26);
            this.txtClass.TabIndex = 233;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Saves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txtCountry;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label_Jogador0;
        private System.Windows.Forms.TextBox txtZIP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtHP2;
        internal System.Windows.Forms.TextBox txtHP1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button buttonFiltrar;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.ComboBox DropBoss;
        internal System.Windows.Forms.Label labelZona;
        internal System.Windows.Forms.TextBox txtHP;
        internal System.Windows.Forms.Label label_Coordenadas;
        internal System.Windows.Forms.TextBox txtItem_Discovery;
        internal System.Windows.Forms.TextBox txtStamina;
        internal System.Windows.Forms.Label label_dialogo;
        internal System.Windows.Forms.Label label_Trilha_Sonora;
        internal System.Windows.Forms.Label label_Resistencia;
        internal System.Windows.Forms.Label label_Fraqueza;
        internal System.Windows.Forms.Label Label_Drops;
        internal System.Windows.Forms.TextBox txtEquip_Load;
        internal System.Windows.Forms.TextBox txtFocusPoints;
        internal System.Windows.Forms.TextBox txtNivel;
        internal System.Windows.Forms.TextBox txtHoras;
        internal System.Windows.Forms.TextBox txtUltima_Localizacao;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label_Imunidade;
        internal System.Windows.Forms.Label Label_HP;
        internal System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.Button bttnDelete;
        internal System.Windows.Forms.Button bttnAdd;
        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Button bttnOK;
        internal System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.ToolStripMenuItem LoadSaves;
        private System.Windows.Forms.ComboBox DropClass;
        internal System.Windows.Forms.TextBox txtClass;
    }
}
