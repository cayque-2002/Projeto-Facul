
namespace Projeto_Facul
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFunPesquisar = new System.Windows.Forms.Button();
            this.LbPerfil = new System.Windows.Forms.Label();
            this.BtnIncluirFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnFunPesquisar
            // 
            this.btnFunPesquisar.Location = new System.Drawing.Point(639, 40);
            this.btnFunPesquisar.Name = "btnFunPesquisar";
            this.btnFunPesquisar.Size = new System.Drawing.Size(69, 23);
            this.btnFunPesquisar.TabIndex = 2;
            this.btnFunPesquisar.Text = "Pesquisar";
            this.btnFunPesquisar.UseVisualStyleBackColor = true;
            // 
            // LbPerfil
            // 
            this.LbPerfil.AutoSize = true;
            this.LbPerfil.BackColor = System.Drawing.Color.Transparent;
            this.LbPerfil.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbPerfil.Location = new System.Drawing.Point(101, 40);
            this.LbPerfil.Name = "LbPerfil";
            this.LbPerfil.Size = new System.Drawing.Size(185, 21);
            this.LbPerfil.TabIndex = 44;
            this.LbPerfil.Text = "Pesquisar funcionário:";
            // 
            // BtnIncluirFunc
            // 
            this.BtnIncluirFunc.Location = new System.Drawing.Point(105, 403);
            this.BtnIncluirFunc.Name = "BtnIncluirFunc";
            this.BtnIncluirFunc.Size = new System.Drawing.Size(69, 23);
            this.BtnIncluirFunc.TabIndex = 45;
            this.BtnIncluirFunc.Text = "Incluir";
            this.BtnIncluirFunc.UseVisualStyleBackColor = true;
            this.BtnIncluirFunc.Click += new System.EventHandler(this.BtnIncluirFunc_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 454);
            this.Controls.Add(this.BtnIncluirFunc);
            this.Controls.Add(this.LbPerfil);
            this.Controls.Add(this.btnFunPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroTecnico_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFunPesquisar;
        private System.Windows.Forms.Label LbPerfil;
        private System.Windows.Forms.Button BtnIncluirFunc;
    }
}