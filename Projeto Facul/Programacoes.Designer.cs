
namespace Projeto_Facul
{
    partial class Programacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programacoes));
            this.lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbNome = new System.Windows.Forms.Label();
            this.LbVeloc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LbTipTec = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(78, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(350, 55);
            this.lb.TabIndex = 7;
            this.lb.Text = "Programações";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 8;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.BackColor = System.Drawing.Color.Transparent;
            this.LbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.Location = new System.Drawing.Point(60, 131);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(79, 25);
            this.LbNome.TabIndex = 9;
            this.LbNome.Text = "Nome:";
            // 
            // LbVeloc
            // 
            this.LbVeloc.AutoSize = true;
            this.LbVeloc.BackColor = System.Drawing.Color.Transparent;
            this.LbVeloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbVeloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbVeloc.Location = new System.Drawing.Point(60, 207);
            this.LbVeloc.Name = "LbVeloc";
            this.LbVeloc.Size = new System.Drawing.Size(322, 25);
            this.LbVeloc.TabIndex = 11;
            this.LbVeloc.Text = "Velocidade da Programação :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(490, 20);
            this.textBox2.TabIndex = 10;
            // 
            // LbTipTec
            // 
            this.LbTipTec.AutoSize = true;
            this.LbTipTec.BackColor = System.Drawing.Color.Transparent;
            this.LbTipTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTipTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipTec.Location = new System.Drawing.Point(442, 132);
            this.LbTipTec.Name = "LbTipTec";
            this.LbTipTec.Size = new System.Drawing.Size(221, 25);
            this.LbTipTec.TabIndex = 13;
            this.LbTipTec.Text = "Tipo de Tecnologia:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(527, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Programacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Facul.Properties.Resources.WhatsApp_Image_2021_10_20_at_8_12_17_PM;
            this.ClientSize = new System.Drawing.Size(826, 436);
            this.Controls.Add(this.LbTipTec);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LbVeloc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Programacoes";
            this.Text = "Programacoes";
            this.Load += new System.EventHandler(this.Programacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label LbVeloc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LbTipTec;
        private System.Windows.Forms.TextBox textBox3;
    }
}