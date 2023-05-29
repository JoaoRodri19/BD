namespace Ds3
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
            
            this.Label_ID = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label_Jogador0 = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.bttnOK = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label_Ultima_localizacao = new System.Windows.Forms.Label();
            this.Label_Horas = new System.Windows.Forms.Label();
            this.Label_Jogador = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUltima_localizacao = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtJogador = new System.Windows.Forms.TextBox();
            
            this.bttnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 533);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 533);
            this.splitContainer1.SplitterDistance = 483;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 533);
            this.panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(483, 533);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtUltima_localizacao);
            this.panel3.Controls.Add(this.txtHoras);
            this.panel3.Controls.Add(this.txtJogador);

            this.panel3.Controls.Add(this.Label_ID);
            this.panel3.Controls.Add(this.Label4);
            this.panel3.Controls.Add(this.Label_Jogador0);
            this.panel3.Controls.Add(this.bttnOK);
            this.panel3.Controls.Add(this.bttnEdit);
            this.panel3.Controls.Add(this.Label9);
            this.panel3.Controls.Add(this.Label7);
            this.panel3.Controls.Add(this.Label6);
            this.panel3.Controls.Add(this.Label5);
            this.panel3.Controls.Add(this.Label_Ultima_localizacao);
            this.panel3.Controls.Add(this.Label_Horas);
            this.panel3.Controls.Add(this.Label_Jogador);
            this.panel3.Controls.Add(this.bttnCancel);
            this.panel3.Controls.Add(this.bttnAdd);
            this.panel3.Controls.Add(this.bttnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 533);
            this.panel3.TabIndex = 0;
            // 
            // Label_ID
            // 
            this.Label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_ID.Location = new System.Drawing.Point(48, 60);
            this.Label_ID.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(96, 20);
            this.Label_ID.TabIndex = 139;
            this.Label_ID.Text = "ID";
            // 
            // Label_Ultima_localizacao
            // 
            this.Label_Ultima_localizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Ultima_localizacao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Ultima_localizacao.Location = new System.Drawing.Point(48, 171);
            this.Label_Ultima_localizacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_Ultima_localizacao.Name = "Label_Ultima_localizacao";
            this.Label_Ultima_localizacao.Size = new System.Drawing.Size(96, 20);
            this.Label_Ultima_localizacao.TabIndex = 120;
            this.Label_Ultima_localizacao.Text = "Ultima Localização";
            // 
            // Label_Horas
            // 
            this.Label_Horas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Horas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Horas.Location = new System.Drawing.Point(48, 122);
            this.Label_Horas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.Label_Horas.Name = "Label_Horas";
            this.Label_Horas.Size = new System.Drawing.Size(96, 20);
            this.Label_Horas.TabIndex = 118;
            this.Label_Horas.Text = "Horas";
            // 
            // Label_Jogador
            // 
            this.Label_Jogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Jogador.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Jogador.Location = new System.Drawing.Point(152, 60);
            this.Label_Jogador.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.Label_Jogador.Name = "Label_Jogador";
            this.Label_Jogador.Size = new System.Drawing.Size(96, 20);
            this.Label_Jogador.TabIndex = 116;
            this.Label_Jogador.Text = "Jogador";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtID.Location = new System.Drawing.Point(52, 87);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(91, 26);
            this.txtID.TabIndex = 140;
            // 
            // txtUltima_localizacao
            // 
            this.txtUltima_localizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUltima_localizacao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtUltima_localizacao.Location = new System.Drawing.Point(50, 193);
            this.txtUltima_localizacao.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtUltima_localizacao.Name = "txtUltima_localizacao";
            this.txtUltima_localizacao.ReadOnly = true;
            this.txtUltima_localizacao.Size = new System.Drawing.Size(457, 26);
            this.txtUltima_localizacao.TabIndex = 121;
            // 
            // txtHoras
            // 
            this.txtHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHoras.Location = new System.Drawing.Point(50, 144);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(351, 26);
            this.txtHoras.TabIndex = 119;
            // 
            // txtJogador
            // 
            this.txtJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJogador.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtJogador.Location = new System.Drawing.Point(152, 87);
            this.txtJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.ReadOnly = true;
            this.txtJogador.Size = new System.Drawing.Size(356, 26);
            this.txtJogador.TabIndex = 117;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnDelete.Location = new System.Drawing.Point(370, 465);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(128, 39);
            this.bttnDelete.TabIndex = 136;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnCancel.Location = new System.Drawing.Point(104, 465);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(128, 39);
            this.bttnCancel.TabIndex = 132;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.Visible = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnAdd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnAdd.Location = new System.Drawing.Point(48, 465);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(128, 39);
            this.bttnAdd.TabIndex = 130;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOK.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnOK.Location = new System.Drawing.Point(314, 465);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(128, 39);
            this.bttnOK.TabIndex = 133;
            this.bttnOK.Text = "OK";
            this.bttnOK.Visible = false;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnEdit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnEdit.Location = new System.Drawing.Point(213, 465);
            this.bttnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(128, 39);
            this.bttnEdit.TabIndex = 131;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCustomersToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCustomersToolStripMenuItem
            // 
            this.loadCustomersToolStripMenuItem.Name = "loadCustomersToolStripMenuItem";
            this.loadCustomersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadCustomersToolStripMenuItem.Text = "Load Customers";
            this.loadCustomersToolStripMenuItem.Click += new System.EventHandler(this.loadCustomersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Contacts";
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
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label_ID;
        internal System.Windows.Forms.TextBox txtCountry;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label_Jogador0;
        private System.Windows.Forms.TextBox txtZIP;
        internal System.Windows.Forms.Button bttnOK;
        internal System.Windows.Forms.Button bttnEdit;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label_Ultima_localizacao;
        internal System.Windows.Forms.Label Label_Horas;
        internal System.Windows.Forms.Label Label_Jogador;
        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Button bttnAdd;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtUltima_localizacao;
        internal System.Windows.Forms.TextBox txtHoras;
        internal System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

