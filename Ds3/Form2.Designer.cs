namespace Ds3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btSaves = new System.Windows.Forms.Button();
            this.btBosses = new System.Windows.Forms.Button();
            this.DropJogador = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.todos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSaves
            // 
            this.btSaves.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btSaves.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaves.Location = new System.Drawing.Point(1299, 607);
            this.btSaves.Name = "btSaves";
            this.btSaves.Size = new System.Drawing.Size(217, 89);
            this.btSaves.TabIndex = 0;
            this.btSaves.Text = "EDITAR";
            this.btSaves.UseVisualStyleBackColor = false;
            this.btSaves.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBosses
            // 
            this.btBosses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBosses.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btBosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBosses.Location = new System.Drawing.Point(1299, 377);
            this.btBosses.Name = "btBosses";
            this.btBosses.Size = new System.Drawing.Size(217, 86);
            this.btBosses.TabIndex = 1;
            this.btBosses.Text = "EDITAR";
            this.btBosses.UseVisualStyleBackColor = false;
            this.btBosses.Click += new System.EventHandler(this.btBosses_Click);
            // 
            // DropJogador
            // 
            this.DropJogador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DropJogador.FormattingEnabled = true;
            this.DropJogador.Location = new System.Drawing.Point(1321, 72);
            this.DropJogador.Name = "DropJogador";
            this.DropJogador.Size = new System.Drawing.Size(195, 24);
            this.DropJogador.TabIndex = 2;
            this.DropJogador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1299, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "EDITAR";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.todos);
            this.panel1.Controls.Add(this.btSaves);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DropJogador);
            this.panel1.Controls.Add(this.btBosses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1751, 798);
            this.panel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // todos
            // 
            this.todos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.todos.Font = new System.Drawing.Font("Verdana", 40F);
            this.todos.ForeColor = System.Drawing.Color.Snow;
            this.todos.Location = new System.Drawing.Point(447, 607);
            this.todos.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(542, 112);
            this.todos.TabIndex = 205;
            this.todos.Text = "Editar Bosses";
            this.todos.Click += new System.EventHandler(this.todos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Verdana", 40F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(462, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 112);
            this.label1.TabIndex = 206;
            this.label1.Text = "Editar Saves";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Verdana", 40F);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(447, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(634, 112);
            this.label2.TabIndex = 207;
            this.label2.Text = "Editar Inventário";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 798);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSaves;
        private System.Windows.Forms.Button btBosses;
        private System.Windows.Forms.ComboBox DropJogador;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.Label todos;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}