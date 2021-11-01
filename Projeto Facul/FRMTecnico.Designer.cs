
namespace Projeto_Facul
{
    partial class FRMTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMTecnico));
            this.btnPesquisarCh = new System.Windows.Forms.Button();
            this.LbPesqChamados = new System.Windows.Forms.Label();
            this.TBoxChamadoPesq = new System.Windows.Forms.TextBox();
            this.dataGVchamados = new System.Windows.Forms.DataGridView();
            this.lbTitTecnico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVchamados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarCh
            // 
            this.btnPesquisarCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCh.Location = new System.Drawing.Point(569, 117);
            this.btnPesquisarCh.Name = "btnPesquisarCh";
            this.btnPesquisarCh.Size = new System.Drawing.Size(87, 25);
            this.btnPesquisarCh.TabIndex = 22;
            this.btnPesquisarCh.Text = "Pesquisar";
            this.btnPesquisarCh.UseVisualStyleBackColor = true;
            this.btnPesquisarCh.Click += new System.EventHandler(this.btnPesquisarCh_Click);
            // 
            // LbPesqChamados
            // 
            this.LbPesqChamados.AutoSize = true;
            this.LbPesqChamados.BackColor = System.Drawing.Color.Transparent;
            this.LbPesqChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPesqChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPesqChamados.Location = new System.Drawing.Point(100, 117);
            this.LbPesqChamados.Name = "LbPesqChamados";
            this.LbPesqChamados.Size = new System.Drawing.Size(130, 25);
            this.LbPesqChamados.TabIndex = 21;
            this.LbPesqChamados.Text = "Chamados:";
            // 
            // TBoxChamadoPesq
            // 
            this.TBoxChamadoPesq.Location = new System.Drawing.Point(236, 120);
            this.TBoxChamadoPesq.Name = "TBoxChamadoPesq";
            this.TBoxChamadoPesq.Size = new System.Drawing.Size(327, 20);
            this.TBoxChamadoPesq.TabIndex = 20;
            // 
            // dataGVchamados
            // 
            this.dataGVchamados.AllowDrop = true;
            this.dataGVchamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVchamados.Location = new System.Drawing.Point(12, 187);
            this.dataGVchamados.Name = "dataGVchamados";
            this.dataGVchamados.Size = new System.Drawing.Size(775, 150);
            this.dataGVchamados.TabIndex = 19;
            // 
            // lbTitTecnico
            // 
            this.lbTitTecnico.AutoSize = true;
            this.lbTitTecnico.BackColor = System.Drawing.Color.Transparent;
            this.lbTitTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitTecnico.Location = new System.Drawing.Point(136, 22);
            this.lbTitTecnico.Name = "lbTitTecnico";
            this.lbTitTecnico.Size = new System.Drawing.Size(520, 55);
            this.lbTitTecnico.TabIndex = 30;
            this.lbTitTecnico.Text = "Chamados em aberto:";
            // 
            // FRMTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 416);
            this.Controls.Add(this.lbTitTecnico);
            this.Controls.Add(this.btnPesquisarCh);
            this.Controls.Add(this.LbPesqChamados);
            this.Controls.Add(this.TBoxChamadoPesq);
            this.Controls.Add(this.dataGVchamados);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGGE - Tecnico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMTecnico_FormClosing);
            this.Load += new System.EventHandler(this.FRMTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVchamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarCh;
        private System.Windows.Forms.Label LbPesqChamados;
        private System.Windows.Forms.TextBox TBoxChamadoPesq;
        private System.Windows.Forms.DataGridView dataGVchamados;
        private System.Windows.Forms.Label lbTitTecnico;
    }
}