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
            this.SuspendLayout();
            // 
            // btSaves
            // 
            this.btSaves.Location = new System.Drawing.Point(695, 151);
            this.btSaves.Name = "btSaves";
            this.btSaves.Size = new System.Drawing.Size(198, 86);
            this.btSaves.TabIndex = 0;
            this.btSaves.Text = "Saves";
            this.btSaves.UseVisualStyleBackColor = true;
            this.btSaves.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBosses
            // 
            this.btBosses.Location = new System.Drawing.Point(328, 151);
            this.btBosses.Name = "btBosses";
            this.btBosses.Size = new System.Drawing.Size(190, 86);
            this.btBosses.TabIndex = 1;
            this.btBosses.Text = "Bosses";
            this.btBosses.UseVisualStyleBackColor = true;
            this.btBosses.Click += new System.EventHandler(this.btBosses_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 450);
            this.Controls.Add(this.btBosses);
            this.Controls.Add(this.btSaves);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSaves;
        private System.Windows.Forms.Button btBosses;
    }
}