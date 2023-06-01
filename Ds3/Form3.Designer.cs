namespace Ds3
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHP2 = new System.Windows.Forms.TextBox();
            this.txtHP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.DropBoss = new System.Windows.Forms.ComboBox();
            this.labelZona = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.label_Coordenadas = new System.Windows.Forms.Label();
            this.txtCoordenadas = new System.Windows.Forms.TextBox();
            this.txtDialogo = new System.Windows.Forms.TextBox();
            this.txtTrilha = new System.Windows.Forms.TextBox();
            this.label_dialogo = new System.Windows.Forms.Label();
            this.label_Trilha_Sonora = new System.Windows.Forms.Label();
            this.label_Resistencia = new System.Windows.Forms.Label();
            this.label_Fraqueza = new System.Windows.Forms.Label();
            this.Label_Drops = new System.Windows.Forms.Label();
            this.txtFraqueza = new System.Windows.Forms.TextBox();
            this.txtDrops = new System.Windows.Forms.TextBox();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.txtImunidade = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label_Imunidade = new System.Windows.Forms.Label();
            this.Label_HP = new System.Windows.Forms.Label();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todos = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(1310, 731);
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
            this.splitContainer1.Size = new System.Drawing.Size(1310, 731);
            this.splitContainer1.SplitterDistance = 600;
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
            this.panel2.Size = new System.Drawing.Size(600, 731);
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
            this.listBox1.Size = new System.Drawing.Size(600, 731);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.todos);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtHP2);
            this.panel3.Controls.Add(this.txtHP1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonFiltrar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtFiltrar);
            this.panel3.Controls.Add(this.DropBoss);
            this.panel3.Controls.Add(this.labelZona);
            this.panel3.Controls.Add(this.txtZona);
            this.panel3.Controls.Add(this.label_Coordenadas);
            this.panel3.Controls.Add(this.txtCoordenadas);
            this.panel3.Controls.Add(this.txtDialogo);
            this.panel3.Controls.Add(this.txtTrilha);
            this.panel3.Controls.Add(this.label_dialogo);
            this.panel3.Controls.Add(this.label_Trilha_Sonora);
            this.panel3.Controls.Add(this.label_Resistencia);
            this.panel3.Controls.Add(this.label_Fraqueza);
            this.panel3.Controls.Add(this.Label_Drops);
            this.panel3.Controls.Add(this.txtFraqueza);
            this.panel3.Controls.Add(this.txtDrops);
            this.panel3.Controls.Add(this.txtResistencia);
            this.panel3.Controls.Add(this.txtImunidade);
            this.panel3.Controls.Add(this.txtHP);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.Label_Imunidade);
            this.panel3.Controls.Add(this.Label_HP);
            this.panel3.Controls.Add(this.Label_Nome);
            this.panel3.Controls.Add(this.bttnDelete);
            this.panel3.Controls.Add(this.bttnAdd);
            this.panel3.Controls.Add(this.bttnCancel);
            this.panel3.Controls.Add(this.bttnOK);
            this.panel3.Controls.Add(this.bttnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 731);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(364, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 197;
            this.label4.Text = "a";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(203, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 196;
            this.label3.Text = "Desde";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHP2
            // 
            this.txtHP2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHP2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHP2.Location = new System.Drawing.Point(403, 207);
            this.txtHP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtHP2.Name = "txtHP2";
            this.txtHP2.ReadOnly = true;
            this.txtHP2.Size = new System.Drawing.Size(56, 26);
            this.txtHP2.TabIndex = 195;
            // 
            // txtHP1
            // 
            this.txtHP1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHP1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHP1.Location = new System.Drawing.Point(287, 207);
            this.txtHP1.Margin = new System.Windows.Forms.Padding(4);
            this.txtHP1.Name = "txtHP1";
            this.txtHP1.ReadOnly = true;
            this.txtHP1.Size = new System.Drawing.Size(56, 26);
            this.txtHP1.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(105, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 193;
            this.label2.Text = "HP";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFiltrar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonFiltrar.Location = new System.Drawing.Point(560, 180);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(104, 34);
            this.buttonFiltrar.TabIndex = 192;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(82, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 191;
            this.label1.Text = "Filtrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFiltrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFiltrar.Location = new System.Drawing.Point(403, 152);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.ReadOnly = true;
            this.txtFiltrar.Size = new System.Drawing.Size(118, 26);
            this.txtFiltrar.TabIndex = 190;
            // 
            // DropBoss
            // 
            this.DropBoss.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropBoss.FormattingEnabled = true;
            this.DropBoss.Location = new System.Drawing.Point(222, 152);
            this.DropBoss.Name = "DropBoss";
            this.DropBoss.Size = new System.Drawing.Size(121, 24);
            this.DropBoss.TabIndex = 189;
            // 
            // labelZona
            // 
            this.labelZona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelZona.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelZona.Location = new System.Drawing.Point(427, 489);
            this.labelZona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.labelZona.Name = "labelZona";
            this.labelZona.Size = new System.Drawing.Size(109, 20);
            this.labelZona.TabIndex = 188;
            this.labelZona.Text = "Zona";
            // 
            // txtZona
            // 
            this.txtZona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtZona.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtZona.Location = new System.Drawing.Point(430, 511);
            this.txtZona.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtZona.Name = "txtZona";
            this.txtZona.ReadOnly = true;
            this.txtZona.Size = new System.Drawing.Size(180, 26);
            this.txtZona.TabIndex = 187;
            // 
            // label_Coordenadas
            // 
            this.label_Coordenadas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Coordenadas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Coordenadas.Location = new System.Drawing.Point(427, 422);
            this.label_Coordenadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_Coordenadas.Name = "label_Coordenadas";
            this.label_Coordenadas.Size = new System.Drawing.Size(128, 20);
            this.label_Coordenadas.TabIndex = 186;
            this.label_Coordenadas.Text = "Coordenadas";
            // 
            // txtCoordenadas
            // 
            this.txtCoordenadas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCoordenadas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtCoordenadas.Location = new System.Drawing.Point(430, 444);
            this.txtCoordenadas.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtCoordenadas.Name = "txtCoordenadas";
            this.txtCoordenadas.ReadOnly = true;
            this.txtCoordenadas.Size = new System.Drawing.Size(180, 26);
            this.txtCoordenadas.TabIndex = 185;
            // 
            // txtDialogo
            // 
            this.txtDialogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDialogo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDialogo.Location = new System.Drawing.Point(430, 385);
            this.txtDialogo.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtDialogo.Name = "txtDialogo";
            this.txtDialogo.ReadOnly = true;
            this.txtDialogo.Size = new System.Drawing.Size(181, 26);
            this.txtDialogo.TabIndex = 182;
            // 
            // txtTrilha
            // 
            this.txtTrilha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTrilha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtTrilha.Location = new System.Drawing.Point(431, 329);
            this.txtTrilha.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrilha.Name = "txtTrilha";
            this.txtTrilha.ReadOnly = true;
            this.txtTrilha.Size = new System.Drawing.Size(180, 26);
            this.txtTrilha.TabIndex = 180;
            // 
            // label_dialogo
            // 
            this.label_dialogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_dialogo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_dialogo.Location = new System.Drawing.Point(427, 363);
            this.label_dialogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_dialogo.Name = "label_dialogo";
            this.label_dialogo.Size = new System.Drawing.Size(128, 20);
            this.label_dialogo.TabIndex = 181;
            this.label_dialogo.Text = "Diálogo";
            // 
            // label_Trilha_Sonora
            // 
            this.label_Trilha_Sonora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Trilha_Sonora.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Trilha_Sonora.Location = new System.Drawing.Point(428, 301);
            this.label_Trilha_Sonora.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label_Trilha_Sonora.Name = "label_Trilha_Sonora";
            this.label_Trilha_Sonora.Size = new System.Drawing.Size(140, 20);
            this.label_Trilha_Sonora.TabIndex = 179;
            this.label_Trilha_Sonora.Text = "Trilha Sonora";
            // 
            // label_Resistencia
            // 
            this.label_Resistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Resistencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Resistencia.Location = new System.Drawing.Point(119, 416);
            this.label_Resistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_Resistencia.Name = "label_Resistencia";
            this.label_Resistencia.Size = new System.Drawing.Size(118, 20);
            this.label_Resistencia.TabIndex = 178;
            this.label_Resistencia.Text = "Resistência";
            // 
            // label_Fraqueza
            // 
            this.label_Fraqueza.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Fraqueza.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Fraqueza.Location = new System.Drawing.Point(119, 539);
            this.label_Fraqueza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.label_Fraqueza.Name = "label_Fraqueza";
            this.label_Fraqueza.Size = new System.Drawing.Size(96, 20);
            this.label_Fraqueza.TabIndex = 177;
            this.label_Fraqueza.Text = "Fraqueza";
            // 
            // Label_Drops
            // 
            this.Label_Drops.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Drops.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Drops.Location = new System.Drawing.Point(119, 472);
            this.Label_Drops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_Drops.Name = "Label_Drops";
            this.Label_Drops.Size = new System.Drawing.Size(96, 20);
            this.Label_Drops.TabIndex = 176;
            this.Label_Drops.Text = "Drops";
            // 
            // txtFraqueza
            // 
            this.txtFraqueza.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFraqueza.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFraqueza.Location = new System.Drawing.Point(121, 561);
            this.txtFraqueza.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtFraqueza.Name = "txtFraqueza";
            this.txtFraqueza.ReadOnly = true;
            this.txtFraqueza.Size = new System.Drawing.Size(181, 26);
            this.txtFraqueza.TabIndex = 175;
            // 
            // txtDrops
            // 
            this.txtDrops.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDrops.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDrops.Location = new System.Drawing.Point(121, 505);
            this.txtDrops.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtDrops.Name = "txtDrops";
            this.txtDrops.ReadOnly = true;
            this.txtDrops.Size = new System.Drawing.Size(181, 26);
            this.txtDrops.TabIndex = 174;
            // 
            // txtResistencia
            // 
            this.txtResistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtResistencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtResistencia.Location = new System.Drawing.Point(122, 438);
            this.txtResistencia.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.ReadOnly = true;
            this.txtResistencia.Size = new System.Drawing.Size(180, 26);
            this.txtResistencia.TabIndex = 173;
            // 
            // txtImunidade
            // 
            this.txtImunidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtImunidade.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtImunidade.Location = new System.Drawing.Point(121, 385);
            this.txtImunidade.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtImunidade.Name = "txtImunidade";
            this.txtImunidade.ReadOnly = true;
            this.txtImunidade.Size = new System.Drawing.Size(181, 26);
            this.txtImunidade.TabIndex = 172;
            // 
            // txtHP
            // 
            this.txtHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHP.Location = new System.Drawing.Point(121, 336);
            this.txtHP.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtHP.Name = "txtHP";
            this.txtHP.ReadOnly = true;
            this.txtHP.Size = new System.Drawing.Size(181, 26);
            this.txtHP.TabIndex = 170;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNome.Location = new System.Drawing.Point(122, 280);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(180, 26);
            this.txtNome.TabIndex = 168;
            // 
            // Label_Imunidade
            // 
            this.Label_Imunidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Imunidade.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Imunidade.Location = new System.Drawing.Point(118, 363);
            this.Label_Imunidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_Imunidade.Name = "Label_Imunidade";
            this.Label_Imunidade.Size = new System.Drawing.Size(129, 20);
            this.Label_Imunidade.TabIndex = 171;
            this.Label_Imunidade.Text = "Imunidade";
            // 
            // Label_HP
            // 
            this.Label_HP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_HP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_HP.Location = new System.Drawing.Point(118, 314);
            this.Label_HP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_HP.Name = "Label_HP";
            this.Label_HP.Size = new System.Drawing.Size(173, 20);
            this.Label_HP.TabIndex = 169;
            this.Label_HP.Text = "Pontos de Vida";
            // 
            // Label_Nome
            // 
            this.Label_Nome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Nome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Nome.Location = new System.Drawing.Point(119, 252);
            this.Label_Nome.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(96, 20);
            this.Label_Nome.TabIndex = 167;
            this.Label_Nome.Text = "Nome";
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnDelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnDelete.Location = new System.Drawing.Point(512, 621);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(128, 39);
            this.bttnDelete.TabIndex = 157;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click_1);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnAdd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnAdd.Location = new System.Drawing.Point(367, 621);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(128, 39);
            this.bttnAdd.TabIndex = 153;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click_1);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnCancel.Location = new System.Drawing.Point(512, 561);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(128, 39);
            this.bttnCancel.TabIndex = 155;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.Visible = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click_1);
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnOK.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnOK.Location = new System.Drawing.Point(367, 561);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(4);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(128, 39);
            this.bttnOK.TabIndex = 156;
            this.bttnOK.Text = "OK";
            this.bttnOK.Visible = false;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click_1);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnEdit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnEdit.Location = new System.Drawing.Point(512, 561);
            this.bttnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(128, 39);
            this.bttnEdit.TabIndex = 154;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click_1);
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
            this.load,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(53, 22);
            this.load.Text = "Load";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // todos
            // 
            this.todos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.todos.Font = new System.Drawing.Font("Verdana", 40F);
            this.todos.Location = new System.Drawing.Point(242, -2);
            this.todos.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(340, 100);
            this.todos.TabIndex = 204;
            this.todos.Text = "Bosses";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtID.Location = new System.Drawing.Point(35, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(110, 26);
            this.txtID.TabIndex = 205;
            this.txtID.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1310, 757);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
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
        private System.Windows.Forms.TextBox txtZIP;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bttnDelete;
        internal System.Windows.Forms.Button bttnAdd;
        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Button bttnOK;
        internal System.Windows.Forms.Button bttnEdit;
        internal System.Windows.Forms.Label label_Coordenadas;
        internal System.Windows.Forms.TextBox txtCoordenadas;
        internal System.Windows.Forms.TextBox txtLocalizacao;
        internal System.Windows.Forms.TextBox txtDialogo;
        internal System.Windows.Forms.TextBox txtTrilha;
        internal System.Windows.Forms.Label label_Localizacao;
        internal System.Windows.Forms.Label label_dialogo;
        internal System.Windows.Forms.Label label_Trilha_Sonora;
        internal System.Windows.Forms.Label label_Resistencia;
        internal System.Windows.Forms.Label label_Fraqueza;
        internal System.Windows.Forms.Label Label_Drops;
        internal System.Windows.Forms.TextBox txtFraqueza;
        internal System.Windows.Forms.TextBox txtDrops;
        internal System.Windows.Forms.TextBox txtResistencia;
        internal System.Windows.Forms.TextBox txtImunidade;
        internal System.Windows.Forms.TextBox txtHP;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label_Imunidade;
        internal System.Windows.Forms.Label Label_HP;
        internal System.Windows.Forms.Label Label_Nome;
        internal System.Windows.Forms.Label labelZona;
        internal System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.ComboBox DropBoss;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtFiltrar;
        internal System.Windows.Forms.Button buttonFiltrar;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtHP2;
        internal System.Windows.Forms.TextBox txtHP1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        internal System.Windows.Forms.Label todos;
        internal System.Windows.Forms.TextBox txtID;
    }
}

