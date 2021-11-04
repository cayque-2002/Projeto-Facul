
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
            this.lbIDChamado = new System.Windows.Forms.Label();
            this.CBoxIDChamado = new System.Windows.Forms.ComboBox();
            this.CBoxSituaCh = new System.Windows.Forms.ComboBox();
            this.CBoxDescriCh = new System.Windows.Forms.ComboBox();
            this.CBoxAtendimentoTec = new System.Windows.Forms.ComboBox();
            this.lbSituacaoCh = new System.Windows.Forms.Label();
            this.lbDescrChamado = new System.Windows.Forms.Label();
            this.lbAtendimentoTec = new System.Windows.Forms.Label();
            this.btnAtenderCh = new System.Windows.Forms.Button();
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
            // lbIDChamado
            // 
            this.lbIDChamado.AutoSize = true;
            this.lbIDChamado.BackColor = System.Drawing.Color.Transparent;
            this.lbIDChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIDChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDChamado.Location = new System.Drawing.Point(22, 373);
            this.lbIDChamado.Name = "lbIDChamado";
            this.lbIDChamado.Size = new System.Drawing.Size(147, 25);
            this.lbIDChamado.TabIndex = 46;
            this.lbIDChamado.Text = "ID Chamado:";
            // 
            // CBoxIDChamado
            // 
            this.CBoxIDChamado.FormattingEnabled = true;
            this.CBoxIDChamado.Location = new System.Drawing.Point(175, 373);
            this.CBoxIDChamado.Name = "CBoxIDChamado";
            this.CBoxIDChamado.Size = new System.Drawing.Size(115, 21);
            this.CBoxIDChamado.TabIndex = 45;
            // 
            // CBoxSituaCh
            // 
            this.CBoxSituaCh.FormattingEnabled = true;
            this.CBoxSituaCh.Items.AddRange(new object[] {
            "Em aberto",
            "Atendido"});
            this.CBoxSituaCh.Location = new System.Drawing.Point(519, 373);
            this.CBoxSituaCh.Name = "CBoxSituaCh";
            this.CBoxSituaCh.Size = new System.Drawing.Size(115, 21);
            this.CBoxSituaCh.TabIndex = 47;
            // 
            // CBoxDescriCh
            // 
            this.CBoxDescriCh.FormattingEnabled = true;
            this.CBoxDescriCh.Location = new System.Drawing.Point(258, 435);
            this.CBoxDescriCh.Name = "CBoxDescriCh";
            this.CBoxDescriCh.Size = new System.Drawing.Size(521, 21);
            this.CBoxDescriCh.TabIndex = 48;
            // 
            // CBoxAtendimentoTec
            // 
            this.CBoxAtendimentoTec.FormattingEnabled = true;
            this.CBoxAtendimentoTec.Location = new System.Drawing.Point(175, 497);
            this.CBoxAtendimentoTec.Name = "CBoxAtendimentoTec";
            this.CBoxAtendimentoTec.Size = new System.Drawing.Size(604, 21);
            this.CBoxAtendimentoTec.TabIndex = 49;
            // 
            // lbSituacaoCh
            // 
            this.lbSituacaoCh.AutoSize = true;
            this.lbSituacaoCh.BackColor = System.Drawing.Color.Transparent;
            this.lbSituacaoCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSituacaoCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacaoCh.Location = new System.Drawing.Point(296, 373);
            this.lbSituacaoCh.Name = "lbSituacaoCh";
            this.lbSituacaoCh.Size = new System.Drawing.Size(217, 25);
            this.lbSituacaoCh.TabIndex = 50;
            this.lbSituacaoCh.Text = "Situação Chamado:";
            // 
            // lbDescrChamado
            // 
            this.lbDescrChamado.AutoSize = true;
            this.lbDescrChamado.BackColor = System.Drawing.Color.Transparent;
            this.lbDescrChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDescrChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrChamado.Location = new System.Drawing.Point(22, 431);
            this.lbDescrChamado.Name = "lbDescrChamado";
            this.lbDescrChamado.Size = new System.Drawing.Size(230, 25);
            this.lbDescrChamado.TabIndex = 51;
            this.lbDescrChamado.Text = "Descrição Chamado:";
            // 
            // lbAtendimentoTec
            // 
            this.lbAtendimentoTec.AutoSize = true;
            this.lbAtendimentoTec.BackColor = System.Drawing.Color.Transparent;
            this.lbAtendimentoTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAtendimentoTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtendimentoTec.Location = new System.Drawing.Point(22, 491);
            this.lbAtendimentoTec.Name = "lbAtendimentoTec";
            this.lbAtendimentoTec.Size = new System.Drawing.Size(150, 25);
            this.lbAtendimentoTec.TabIndex = 52;
            this.lbAtendimentoTec.Text = "Atendimento:";
            // 
            // btnAtenderCh
            // 
            this.btnAtenderCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtenderCh.Location = new System.Drawing.Point(319, 559);
            this.btnAtenderCh.Name = "btnAtenderCh";
            this.btnAtenderCh.Size = new System.Drawing.Size(132, 25);
            this.btnAtenderCh.TabIndex = 63;
            this.btnAtenderCh.Text = "Atender Chamado";
            this.btnAtenderCh.UseVisualStyleBackColor = true;
            this.btnAtenderCh.Click += new System.EventHandler(this.btnAtenderCh_Click);
            // 
            // FRMTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.btnAtenderCh);
            this.Controls.Add(this.lbAtendimentoTec);
            this.Controls.Add(this.lbDescrChamado);
            this.Controls.Add(this.lbSituacaoCh);
            this.Controls.Add(this.CBoxAtendimentoTec);
            this.Controls.Add(this.CBoxDescriCh);
            this.Controls.Add(this.CBoxSituaCh);
            this.Controls.Add(this.lbIDChamado);
            this.Controls.Add(this.CBoxIDChamado);
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
        private System.Windows.Forms.Label lbIDChamado;
        private System.Windows.Forms.ComboBox CBoxIDChamado;
        private System.Windows.Forms.ComboBox CBoxSituaCh;
        private System.Windows.Forms.ComboBox CBoxDescriCh;
        private System.Windows.Forms.ComboBox CBoxAtendimentoTec;
        private System.Windows.Forms.Label lbSituacaoCh;
        private System.Windows.Forms.Label lbDescrChamado;
        private System.Windows.Forms.Label lbAtendimentoTec;
        private System.Windows.Forms.Button btnAtenderCh;
    }
}