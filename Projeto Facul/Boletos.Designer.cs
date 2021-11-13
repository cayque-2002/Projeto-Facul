
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
            this.lbTitBoletos = new System.Windows.Forms.Label();
            this.dataGVBoletos = new System.Windows.Forms.DataGridView();
            this.CboxIDCtBol = new System.Windows.Forms.ComboBox();
            this.lbIDContrato = new System.Windows.Forms.Label();
            this.CBoxClienteBol = new System.Windows.Forms.ComboBox();
            this.LbPesquisarCliBol = new System.Windows.Forms.Label();
            this.CBoxIDProgBol = new System.Windows.Forms.ComboBox();
            this.lbProgIDBol = new System.Windows.Forms.Label();
            this.CBoxProgBol = new System.Windows.Forms.ComboBox();
            this.LbProgBol = new System.Windows.Forms.Label();
            this.CboxValorBol = new System.Windows.Forms.ComboBox();
            this.lbValorBol = new System.Windows.Forms.Label();
            this.CBoxBanco = new System.Windows.Forms.ComboBox();
            this.lbBanco = new System.Windows.Forms.Label();
            this.CBoxContaCredito = new System.Windows.Forms.ComboBox();
            this.lbContaCredito = new System.Windows.Forms.Label();
            this.CBoxAgencia = new System.Windows.Forms.ComboBox();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.btnRegistrarBoleto = new System.Windows.Forms.Button();
            this.BtnBaixarFatura = new System.Windows.Forms.Button();
            this.BtnPesqFatura = new System.Windows.Forms.Button();
            this.CBoxParcela = new System.Windows.Forms.ComboBox();
            this.lbParcela = new System.Windows.Forms.Label();
            this.lbDataVenc = new System.Windows.Forms.Label();
            this.lbDataEmi = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitBoletos
            // 
            this.lbTitBoletos.AutoSize = true;
            this.lbTitBoletos.BackColor = System.Drawing.Color.Transparent;
            this.lbTitBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitBoletos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitBoletos.Location = new System.Drawing.Point(317, 28);
            this.lbTitBoletos.Name = "lbTitBoletos";
            this.lbTitBoletos.Size = new System.Drawing.Size(191, 55);
            this.lbTitBoletos.TabIndex = 55;
            this.lbTitBoletos.Text = "Boletos";
            // 
            // dataGVBoletos
            // 
            this.dataGVBoletos.AllowDrop = true;
            this.dataGVBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVBoletos.Location = new System.Drawing.Point(13, 468);
            this.dataGVBoletos.Name = "dataGVBoletos";
            this.dataGVBoletos.Size = new System.Drawing.Size(775, 150);
            this.dataGVBoletos.TabIndex = 51;
            // 
            // CboxIDCtBol
            // 
            this.CboxIDCtBol.FormattingEnabled = true;
            this.CboxIDCtBol.Location = new System.Drawing.Point(733, 121);
            this.CboxIDCtBol.Name = "CboxIDCtBol";
            this.CboxIDCtBol.Size = new System.Drawing.Size(52, 21);
            this.CboxIDCtBol.TabIndex = 63;
            // 
            // lbIDContrato
            // 
            this.lbIDContrato.AutoSize = true;
            this.lbIDContrato.BackColor = System.Drawing.Color.Transparent;
            this.lbIDContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIDContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDContrato.Location = new System.Drawing.Point(589, 117);
            this.lbIDContrato.Name = "lbIDContrato";
            this.lbIDContrato.Size = new System.Drawing.Size(138, 25);
            this.lbIDContrato.TabIndex = 62;
            this.lbIDContrato.Text = "ID Contrato:";
            // 
            // CBoxClienteBol
            // 
            this.CBoxClienteBol.FormattingEnabled = true;
            this.CBoxClienteBol.Location = new System.Drawing.Point(225, 121);
            this.CBoxClienteBol.Name = "CBoxClienteBol";
            this.CBoxClienteBol.Size = new System.Drawing.Size(358, 21);
            this.CBoxClienteBol.TabIndex = 61;
            // 
            // LbPesquisarCliBol
            // 
            this.LbPesquisarCliBol.AutoSize = true;
            this.LbPesquisarCliBol.BackColor = System.Drawing.Color.Transparent;
            this.LbPesquisarCliBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPesquisarCliBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPesquisarCliBol.Location = new System.Drawing.Point(18, 117);
            this.LbPesquisarCliBol.Name = "LbPesquisarCliBol";
            this.LbPesquisarCliBol.Size = new System.Drawing.Size(201, 25);
            this.LbPesquisarCliBol.TabIndex = 60;
            this.LbPesquisarCliBol.Text = "Pesquisar cliente:";
            // 
            // CBoxIDProgBol
            // 
            this.CBoxIDProgBol.FormattingEnabled = true;
            this.CBoxIDProgBol.Location = new System.Drawing.Point(635, 170);
            this.CBoxIDProgBol.Name = "CBoxIDProgBol";
            this.CBoxIDProgBol.Size = new System.Drawing.Size(52, 21);
            this.CBoxIDProgBol.TabIndex = 65;
            // 
            // lbProgIDBol
            // 
            this.lbProgIDBol.AutoSize = true;
            this.lbProgIDBol.BackColor = System.Drawing.Color.Transparent;
            this.lbProgIDBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbProgIDBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgIDBol.Location = new System.Drawing.Point(450, 166);
            this.lbProgIDBol.Name = "lbProgIDBol";
            this.lbProgIDBol.Size = new System.Drawing.Size(187, 25);
            this.lbProgIDBol.TabIndex = 64;
            this.lbProgIDBol.Text = "ID Programação:";
            // 
            // CBoxProgBol
            // 
            this.CBoxProgBol.FormattingEnabled = true;
            this.CBoxProgBol.Location = new System.Drawing.Point(182, 170);
            this.CBoxProgBol.Name = "CBoxProgBol";
            this.CBoxProgBol.Size = new System.Drawing.Size(262, 21);
            this.CBoxProgBol.TabIndex = 67;
            // 
            // LbProgBol
            // 
            this.LbProgBol.AutoSize = true;
            this.LbProgBol.BackColor = System.Drawing.Color.Transparent;
            this.LbProgBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbProgBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProgBol.Location = new System.Drawing.Point(18, 164);
            this.LbProgBol.Name = "LbProgBol";
            this.LbProgBol.Size = new System.Drawing.Size(158, 25);
            this.LbProgBol.TabIndex = 66;
            this.LbProgBol.Text = "Programação:";
            // 
            // CboxValorBol
            // 
            this.CboxValorBol.FormattingEnabled = true;
            this.CboxValorBol.Location = new System.Drawing.Point(182, 215);
            this.CboxValorBol.Name = "CboxValorBol";
            this.CboxValorBol.Size = new System.Drawing.Size(89, 21);
            this.CboxValorBol.TabIndex = 69;
            // 
            // lbValorBol
            // 
            this.lbValorBol.AutoSize = true;
            this.lbValorBol.BackColor = System.Drawing.Color.Transparent;
            this.lbValorBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbValorBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorBol.Location = new System.Drawing.Point(23, 211);
            this.lbValorBol.Name = "lbValorBol";
            this.lbValorBol.Size = new System.Drawing.Size(149, 25);
            this.lbValorBol.TabIndex = 68;
            this.lbValorBol.Text = "Valor Fatura:";
            // 
            // CBoxBanco
            // 
            this.CBoxBanco.FormattingEnabled = true;
            this.CBoxBanco.Location = new System.Drawing.Point(383, 215);
            this.CBoxBanco.Name = "CBoxBanco";
            this.CBoxBanco.Size = new System.Drawing.Size(159, 21);
            this.CBoxBanco.TabIndex = 71;
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.BackColor = System.Drawing.Color.Transparent;
            this.lbBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanco.Location = new System.Drawing.Point(295, 211);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(92, 25);
            this.lbBanco.TabIndex = 70;
            this.lbBanco.Text = "Banco: ";
            // 
            // CBoxContaCredito
            // 
            this.CBoxContaCredito.FormattingEnabled = true;
            this.CBoxContaCredito.Location = new System.Drawing.Point(193, 258);
            this.CBoxContaCredito.Name = "CBoxContaCredito";
            this.CBoxContaCredito.Size = new System.Drawing.Size(194, 21);
            this.CBoxContaCredito.TabIndex = 73;
            // 
            // lbContaCredito
            // 
            this.lbContaCredito.AutoSize = true;
            this.lbContaCredito.BackColor = System.Drawing.Color.Transparent;
            this.lbContaCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbContaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContaCredito.Location = new System.Drawing.Point(23, 254);
            this.lbContaCredito.Name = "lbContaCredito";
            this.lbContaCredito.Size = new System.Drawing.Size(164, 25);
            this.lbContaCredito.TabIndex = 72;
            this.lbContaCredito.Text = "Conta Crédito:";
            // 
            // CBoxAgencia
            // 
            this.CBoxAgencia.FormattingEnabled = true;
            this.CBoxAgencia.Location = new System.Drawing.Point(648, 215);
            this.CBoxAgencia.Name = "CBoxAgencia";
            this.CBoxAgencia.Size = new System.Drawing.Size(137, 21);
            this.CBoxAgencia.TabIndex = 75;
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.BackColor = System.Drawing.Color.Transparent;
            this.lbAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgencia.Location = new System.Drawing.Point(547, 211);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(104, 25);
            this.lbAgencia.TabIndex = 74;
            this.lbAgencia.Text = "Agência:";
            // 
            // btnRegistrarBoleto
            // 
            this.btnRegistrarBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarBoleto.Location = new System.Drawing.Point(28, 373);
            this.btnRegistrarBoleto.Name = "btnRegistrarBoleto";
            this.btnRegistrarBoleto.Size = new System.Drawing.Size(153, 25);
            this.btnRegistrarBoleto.TabIndex = 76;
            this.btnRegistrarBoleto.Text = "Registrar Boleto";
            this.btnRegistrarBoleto.UseVisualStyleBackColor = true;
            // 
            // BtnBaixarFatura
            // 
            this.BtnBaixarFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaixarFatura.Location = new System.Drawing.Point(206, 373);
            this.BtnBaixarFatura.Name = "BtnBaixarFatura";
            this.BtnBaixarFatura.Size = new System.Drawing.Size(153, 25);
            this.BtnBaixarFatura.TabIndex = 77;
            this.BtnBaixarFatura.Text = "Baixar Boleto";
            this.BtnBaixarFatura.UseVisualStyleBackColor = true;
            // 
            // BtnPesqFatura
            // 
            this.BtnPesqFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesqFatura.Location = new System.Drawing.Point(606, 373);
            this.BtnPesqFatura.Name = "BtnPesqFatura";
            this.BtnPesqFatura.Size = new System.Drawing.Size(153, 25);
            this.BtnPesqFatura.TabIndex = 78;
            this.BtnPesqFatura.Text = "Pesquisar Fatura";
            this.BtnPesqFatura.UseVisualStyleBackColor = true;
            // 
            // CBoxParcela
            // 
            this.CBoxParcela.FormattingEnabled = true;
            this.CBoxParcela.Location = new System.Drawing.Point(509, 260);
            this.CBoxParcela.Name = "CBoxParcela";
            this.CBoxParcela.Size = new System.Drawing.Size(194, 21);
            this.CBoxParcela.TabIndex = 80;
            // 
            // lbParcela
            // 
            this.lbParcela.AutoSize = true;
            this.lbParcela.BackColor = System.Drawing.Color.Transparent;
            this.lbParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParcela.Location = new System.Drawing.Point(404, 256);
            this.lbParcela.Name = "lbParcela";
            this.lbParcela.Size = new System.Drawing.Size(99, 25);
            this.lbParcela.TabIndex = 79;
            this.lbParcela.Text = "Parcela:";
            // 
            // lbDataVenc
            // 
            this.lbDataVenc.AutoSize = true;
            this.lbDataVenc.BackColor = System.Drawing.Color.Transparent;
            this.lbDataVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDataVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataVenc.Location = new System.Drawing.Point(404, 312);
            this.lbDataVenc.Name = "lbDataVenc";
            this.lbDataVenc.Size = new System.Drawing.Size(198, 25);
            this.lbDataVenc.TabIndex = 83;
            this.lbDataVenc.Text = "Data Vencimento:";
            // 
            // lbDataEmi
            // 
            this.lbDataEmi.AutoSize = true;
            this.lbDataEmi.BackColor = System.Drawing.Color.Transparent;
            this.lbDataEmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDataEmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEmi.Location = new System.Drawing.Point(23, 310);
            this.lbDataEmi.Name = "lbDataEmi";
            this.lbDataEmi.Size = new System.Drawing.Size(164, 25);
            this.lbDataEmi.TabIndex = 81;
            this.lbDataEmi.Text = "Data Emissão:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(206, 312);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 84;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(635, 318);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 85;
            // 
            // Boletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Facul.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbDataVenc);
            this.Controls.Add(this.lbDataEmi);
            this.Controls.Add(this.CBoxParcela);
            this.Controls.Add(this.lbParcela);
            this.Controls.Add(this.BtnPesqFatura);
            this.Controls.Add(this.BtnBaixarFatura);
            this.Controls.Add(this.btnRegistrarBoleto);
            this.Controls.Add(this.CBoxAgencia);
            this.Controls.Add(this.lbAgencia);
            this.Controls.Add(this.CBoxContaCredito);
            this.Controls.Add(this.lbContaCredito);
            this.Controls.Add(this.CBoxBanco);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.CboxValorBol);
            this.Controls.Add(this.lbValorBol);
            this.Controls.Add(this.CBoxProgBol);
            this.Controls.Add(this.LbProgBol);
            this.Controls.Add(this.CBoxIDProgBol);
            this.Controls.Add(this.lbProgIDBol);
            this.Controls.Add(this.CboxIDCtBol);
            this.Controls.Add(this.lbIDContrato);
            this.Controls.Add(this.CBoxClienteBol);
            this.Controls.Add(this.LbPesquisarCliBol);
            this.Controls.Add(this.lbTitBoletos);
            this.Controls.Add(this.dataGVBoletos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Boletos";
            this.Text = "Boletos";
            this.Load += new System.EventHandler(this.Boletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitBoletos;
        private System.Windows.Forms.DataGridView dataGVBoletos;
        private System.Windows.Forms.ComboBox CboxIDCtBol;
        private System.Windows.Forms.Label lbIDContrato;
        private System.Windows.Forms.ComboBox CBoxClienteBol;
        private System.Windows.Forms.Label LbPesquisarCliBol;
        private System.Windows.Forms.ComboBox CBoxIDProgBol;
        private System.Windows.Forms.Label lbProgIDBol;
        private System.Windows.Forms.ComboBox CBoxProgBol;
        private System.Windows.Forms.Label LbProgBol;
        private System.Windows.Forms.ComboBox CboxValorBol;
        private System.Windows.Forms.Label lbValorBol;
        private System.Windows.Forms.ComboBox CBoxBanco;
        private System.Windows.Forms.Label lbBanco;
        private System.Windows.Forms.ComboBox CBoxContaCredito;
        private System.Windows.Forms.Label lbContaCredito;
        private System.Windows.Forms.ComboBox CBoxAgencia;
        private System.Windows.Forms.Label lbAgencia;
        private System.Windows.Forms.Button btnRegistrarBoleto;
        private System.Windows.Forms.Button BtnBaixarFatura;
        private System.Windows.Forms.Button BtnPesqFatura;
        private System.Windows.Forms.ComboBox CBoxParcela;
        private System.Windows.Forms.Label lbParcela;
        private System.Windows.Forms.Label lbDataVenc;
        private System.Windows.Forms.Label lbDataEmi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}