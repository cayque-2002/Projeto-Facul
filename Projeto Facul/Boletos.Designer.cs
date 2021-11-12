
namespace Projeto_Facul
{
    partial class Boletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boletos));
            this.lbSituacaoCh = new System.Windows.Forms.Label();
            this.CBoxSituaCh = new System.Windows.Forms.ComboBox();
            this.lbIDChamado = new System.Windows.Forms.Label();
            this.CBoxIDChamado = new System.Windows.Forms.ComboBox();
            this.lbTitTecnico = new System.Windows.Forms.Label();
            this.btnPesquisarCh = new System.Windows.Forms.Button();
            this.LbPesqChamados = new System.Windows.Forms.Label();
            this.TBoxChamadoPesq = new System.Windows.Forms.TextBox();
            this.dataGVchamados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVchamados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSituacaoCh
            // 
            this.lbSituacaoCh.AutoSize = true;
            this.lbSituacaoCh.BackColor = System.Drawing.Color.Transparent;
            this.lbSituacaoCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSituacaoCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacaoCh.Location = new System.Drawing.Point(297, 388);
            this.lbSituacaoCh.Name = "lbSituacaoCh";
            this.lbSituacaoCh.Size = new System.Drawing.Size(217, 25);
            this.lbSituacaoCh.TabIndex = 59;
            this.lbSituacaoCh.Text = "Situação Chamado:";
            // 
            // CBoxSituaCh
            // 
            this.CBoxSituaCh.FormattingEnabled = true;
            this.CBoxSituaCh.Items.AddRange(new object[] {
            "Em aberto",
            "Atendido"});
            this.CBoxSituaCh.Location = new System.Drawing.Point(520, 388);
            this.CBoxSituaCh.Name = "CBoxSituaCh";
            this.CBoxSituaCh.Size = new System.Drawing.Size(115, 21);
            this.CBoxSituaCh.TabIndex = 58;
            // 
            // lbIDChamado
            // 
            this.lbIDChamado.AutoSize = true;
            this.lbIDChamado.BackColor = System.Drawing.Color.Transparent;
            this.lbIDChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIDChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDChamado.Location = new System.Drawing.Point(23, 388);
            this.lbIDChamado.Name = "lbIDChamado";
            this.lbIDChamado.Size = new System.Drawing.Size(147, 25);
            this.lbIDChamado.TabIndex = 57;
            this.lbIDChamado.Text = "ID Chamado:";
            // 
            // CBoxIDChamado
            // 
            this.CBoxIDChamado.FormattingEnabled = true;
            this.CBoxIDChamado.Location = new System.Drawing.Point(176, 388);
            this.CBoxIDChamado.Name = "CBoxIDChamado";
            this.CBoxIDChamado.Size = new System.Drawing.Size(115, 21);
            this.CBoxIDChamado.TabIndex = 56;
            // 
            // lbTitTecnico
            // 
            this.lbTitTecnico.AutoSize = true;
            this.lbTitTecnico.BackColor = System.Drawing.Color.Transparent;
            this.lbTitTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitTecnico.Location = new System.Drawing.Point(137, 37);
            this.lbTitTecnico.Name = "lbTitTecnico";
            this.lbTitTecnico.Size = new System.Drawing.Size(520, 55);
            this.lbTitTecnico.TabIndex = 55;
            this.lbTitTecnico.Text = "Chamados em aberto:";
            // 
            // btnPesquisarCh
            // 
            this.btnPesquisarCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCh.Location = new System.Drawing.Point(570, 132);
            this.btnPesquisarCh.Name = "btnPesquisarCh";
            this.btnPesquisarCh.Size = new System.Drawing.Size(87, 25);
            this.btnPesquisarCh.TabIndex = 54;
            this.btnPesquisarCh.Text = "Pesquisar";
            this.btnPesquisarCh.UseVisualStyleBackColor = true;
            // 
            // LbPesqChamados
            // 
            this.LbPesqChamados.AutoSize = true;
            this.LbPesqChamados.BackColor = System.Drawing.Color.Transparent;
            this.LbPesqChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPesqChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPesqChamados.Location = new System.Drawing.Point(101, 132);
            this.LbPesqChamados.Name = "LbPesqChamados";
            this.LbPesqChamados.Size = new System.Drawing.Size(130, 25);
            this.LbPesqChamados.TabIndex = 53;
            this.LbPesqChamados.Text = "Chamados:";
            // 
            // TBoxChamadoPesq
            // 
            this.TBoxChamadoPesq.Location = new System.Drawing.Point(237, 135);
            this.TBoxChamadoPesq.Name = "TBoxChamadoPesq";
            this.TBoxChamadoPesq.Size = new System.Drawing.Size(327, 20);
            this.TBoxChamadoPesq.TabIndex = 52;
            // 
            // dataGVchamados
            // 
            this.dataGVchamados.AllowDrop = true;
            this.dataGVchamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVchamados.Location = new System.Drawing.Point(13, 202);
            this.dataGVchamados.Name = "dataGVchamados";
            this.dataGVchamados.Size = new System.Drawing.Size(775, 150);
            this.dataGVchamados.TabIndex = 51;
            // 
            // Boletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Facul.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSituacaoCh);
            this.Controls.Add(this.CBoxSituaCh);
            this.Controls.Add(this.lbIDChamado);
            this.Controls.Add(this.CBoxIDChamado);
            this.Controls.Add(this.lbTitTecnico);
            this.Controls.Add(this.btnPesquisarCh);
            this.Controls.Add(this.LbPesqChamados);
            this.Controls.Add(this.TBoxChamadoPesq);
            this.Controls.Add(this.dataGVchamados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Boletos";
            this.Text = "Boletos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVchamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSituacaoCh;
        private System.Windows.Forms.ComboBox CBoxSituaCh;
        private System.Windows.Forms.Label lbIDChamado;
        private System.Windows.Forms.ComboBox CBoxIDChamado;
        private System.Windows.Forms.Label lbTitTecnico;
        private System.Windows.Forms.Button btnPesquisarCh;
        private System.Windows.Forms.Label LbPesqChamados;
        private System.Windows.Forms.TextBox TBoxChamadoPesq;
        private System.Windows.Forms.DataGridView dataGVchamados;
    }
}