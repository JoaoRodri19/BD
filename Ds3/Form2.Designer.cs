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
            this.btSaves = new System.Windows.Forms.Button();
            this.btBosses = new System.Windows.Forms.Button();
            this.DropJogador = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Load += new System.EventHandler(this.Form2_Load);
            // 
            // btSaves
            // 
            this.btSaves.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSaves.Location = new System.Drawing.Point(385, 181);
            this.btSaves.Name = "btSaves";
            this.btSaves.Size = new System.Drawing.Size(198, 86);
            this.btSaves.TabIndex = 0;
            this.btSaves.Text = "Saves";
            this.btSaves.UseVisualStyleBackColor = false;
            this.btSaves.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBosses
            // 
            this.btBosses.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btBosses.Location = new System.Drawing.Point(385, 22);
            this.btBosses.Name = "btBosses";
            this.btBosses.Size = new System.Drawing.Size(190, 86);
            this.btBosses.TabIndex = 1;
            this.btBosses.Text = "Bosses";
            this.btBosses.UseVisualStyleBackColor = false;
            this.btBosses.Click += new System.EventHandler(this.btBosses_Click);
            // 
            // DropJogador
            // 
            this.DropJogador.FormattingEnabled = true;
            this.DropJogador.Location = new System.Drawing.Point(766, 53);
            this.DropJogador.Name = "DropJogador";
            this.DropJogador.Size = new System.Drawing.Size(183, 24);
            this.DropJogador.TabIndex = 2;
            this.DropJogador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(810, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inspecionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DropJogador);
            this.Controls.Add(this.btBosses);
            this.Controls.Add(this.btSaves);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSaves;
        private System.Windows.Forms.Button btBosses;
        private System.Windows.Forms.ComboBox DropJogador;
        private System.Windows.Forms.Button button1;
    }
}