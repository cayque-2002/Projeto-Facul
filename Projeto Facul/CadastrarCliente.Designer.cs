
namespace Projeto_Facul
{
    partial class Cadastrar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Cliente));
            this.lbCadCli = new System.Windows.Forms.Label();
            this.lbSexoCli = new System.Windows.Forms.Label();
            this.CBoxSexoCadCli = new System.Windows.Forms.ComboBox();
            this.BtnLimparCadastroCli = new System.Windows.Forms.Button();
            this.BtnCadastrarCli = new System.Windows.Forms.Button();
            this.TBoxEmailCadCli = new System.Windows.Forms.TextBox();
            this.lbEmailCli = new System.Windows.Forms.Label();
            this.MTBoxCPFCadCli = new System.Windows.Forms.MaskedTextBox();
            this.lbCPFCli = new System.Windows.Forms.Label();
            this.MTBoxCelCadCli = new System.Windows.Forms.MaskedTextBox();
            this.lbTelCli = new System.Windows.Forms.Label();
            this.TBoxRGCadCli = new System.Windows.Forms.TextBox();
            this.lbRGCli = new System.Windows.Forms.Label();
            this.lbNomeCli = new System.Windows.Forms.Label();
            this.TBoxNomeCadCli = new System.Windows.Forms.TextBox();
            this.TBoxTipoLog = new System.Windows.Forms.TextBox();
            this.lbTipoLogradouro = new System.Windows.Forms.Label();
            this.TBoxLogradouro = new System.Windows.Forms.TextBox();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.TBoxBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.TBoxCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.TBoxNumeroCasa = new System.Windows.Forms.TextBox();
            this.lbNumeroCasa = new System.Windows.Forms.Label();
            this.TBoxComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.CBoxIDCli = new System.Windows.Forms.ComboBox();
            this.lbIDCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCadCli
            // 
            this.lbCadCli.AutoSize = true;
            this.lbCadCli.BackColor = System.Drawing.Color.Transparent;
            this.lbCadCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCadCli.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadCli.Location = new System.Drawing.Point(185, 21);
            this.lbCadCli.Name = "lbCadCli";
            this.lbCadCli.Size = new System.Drawing.Size(445, 59);
            this.lbCadCli.TabIndex = 91;
            this.lbCadCli.Text = "Cadastrar Cliente";
            // 
            // lbSexoCli
            // 
            this.lbSexoCli.AutoSize = true;
            this.lbSexoCli.BackColor = System.Drawing.Color.Transparent;
            this.lbSexoCli.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexoCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSexoCli.Location = new System.Drawing.Point(53, 324);
            this.lbSexoCli.Name = "lbSexoCli";
            this.lbSexoCli.Size = new System.Drawing.Size(51, 21);
            this.lbSexoCli.TabIndex = 90;
            this.lbSexoCli.Text = "Sexo:";
            // 
            // CBoxSexoCadCli
            // 
            this.CBoxSexoCadCli.FormattingEnabled = true;
            this.CBoxSexoCadCli.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CBoxSexoCadCli.Location = new System.Drawing.Point(116, 326);
            this.CBoxSexoCadCli.Name = "CBoxSexoCadCli";
            this.CBoxSexoCadCli.Size = new System.Drawing.Size(121, 21);
            this.CBoxSexoCadCli.TabIndex = 89;
            // 
            // BtnLimparCadastroCli
            // 
            this.BtnLimparCadastroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimparCadastroCli.Location = new System.Drawing.Point(665, 378);
            this.BtnLimparCadastroCli.Name = "BtnLimparCadastroCli";
            this.BtnLimparCadastroCli.Size = new System.Drawing.Size(123, 44);
            this.BtnLimparCadastroCli.TabIndex = 84;
            this.BtnLimparCadastroCli.Text = "Limpar";
            this.BtnLimparCadastroCli.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrarCli
            // 
            this.BtnCadastrarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarCli.Location = new System.Drawing.Point(70, 378);
            this.BtnCadastrarCli.Name = "BtnCadastrarCli";
            this.BtnCadastrarCli.Size = new System.Drawing.Size(123, 44);
            this.BtnCadastrarCli.TabIndex = 83;
            this.BtnCadastrarCli.Text = "Cadastrar";
            this.BtnCadastrarCli.UseVisualStyleBackColor = true;
            this.BtnCadastrarCli.Click += new System.EventHandler(this.BtnCadastrarFunc_Click);
            // 
            // TBoxEmailCadCli
            // 
            this.TBoxEmailCadCli.Location = new System.Drawing.Point(432, 109);
            this.TBoxEmailCadCli.Name = "TBoxEmailCadCli";
            this.TBoxEmailCadCli.Size = new System.Drawing.Size(188, 20);
            this.TBoxEmailCadCli.TabIndex = 76;
            // 
            // lbEmailCli
            // 
            this.lbEmailCli.AutoSize = true;
            this.lbEmailCli.BackColor = System.Drawing.Color.Transparent;
            this.lbEmailCli.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEmailCli.Location = new System.Drawing.Point(374, 108);
            this.lbEmailCli.Name = "lbEmailCli";
            this.lbEmailCli.Size = new System.Drawing.Size(65, 21);
            this.lbEmailCli.TabIndex = 81;
            this.lbEmailCli.Text = "E-mail:";
            // 
            // MTBoxCPFCadCli
            // 
            this.MTBoxCPFCadCli.Location = new System.Drawing.Point(116, 227);
            this.MTBoxCPFCadCli.Mask = "000.000.000-00";
            this.MTBoxCPFCadCli.Name = "MTBoxCPFCadCli";
            this.MTBoxCPFCadCli.Size = new System.Drawing.Size(152, 20);
            this.MTBoxCPFCadCli.TabIndex = 74;
            // 
            // lbCPFCli
            // 
            this.lbCPFCli.AutoSize = true;
            this.lbCPFCli.BackColor = System.Drawing.Color.Transparent;
            this.lbCPFCli.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPFCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCPFCli.Location = new System.Drawing.Point(74, 225);
            this.lbCPFCli.Name = "lbCPFCli";
            this.lbCPFCli.Size = new System.Drawing.Size(45, 21);
            this.lbCPFCli.TabIndex = 79;
            this.lbCPFCli.Text = "CPF:";
            // 
            // MTBoxCelCadCli
            // 
            this.MTBoxCelCadCli.Location = new System.Drawing.Point(116, 268);
            this.MTBoxCelCadCli.Mask = "(99) 00000-0000";
            this.MTBoxCelCadCli.Name = "MTBoxCelCadCli";
            this.MTBoxCelCadCli.Size = new System.Drawing.Size(152, 20);
            this.MTBoxCelCadCli.TabIndex = 73;
            // 
            // lbTelCli
            // 
            this.lbTelCli.AutoSize = true;
            this.lbTelCli.BackColor = System.Drawing.Color.Transparent;
            this.lbTelCli.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTelCli.Location = new System.Drawing.Point(49, 268);
            this.lbTelCli.Name = "lbTelCli";
            this.lbTelCli.Size = new System.Drawing.Size(70, 21);
            this.lbTelCli.TabIndex = 75;
            this.lbTelCli.Text = "Celular:";
            // 
            // TBoxRGCadCli
            // 
            this.TBoxRGCadCli.Location = new System.Drawing.Point(116, 177);
            this.TBoxRGCadCli.Name = "TBoxRGCadCli";
            this.TBoxRGCadCli.Size = new System.Drawing.Size(152, 20);
            this.TBoxRGCadCli.TabIndex = 71;
            // 
            // lbRGCli
            // 
            this.lbRGCli.AutoSize = true;
            this.lbRGCli.BackColor = System.Drawing.Color.Transparent;
            this.lbRGCli.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRGCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRGCli.Location = new System.Drawing.Point(82, 177);
            this.lbRGCli.Name = "lbRGCli";
            this.lbRGCli.Size = new System.Drawing.Size(37, 21);
            this.lbRGCli.TabIndex = 72;
            this.lbRGCli.Text = "RG:";
            // 
            // lbNomeCli
            // 
            this.lbNomeCli.AutoSize = true;
            this.lbNomeCli.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeCli.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNomeCli.Location = new System.Drawing.Point(60, 106);
            this.lbNomeCli.Name = "lbNomeCli";
            this.lbNomeCli.Size = new System.Drawing.Size(59, 21);
            this.lbNomeCli.TabIndex = 70;
            this.lbNomeCli.Text = "Nome:";
            // 
            // TBoxNomeCadCli
            // 
            this.TBoxNomeCadCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBoxNomeCadCli.Location = new System.Drawing.Point(116, 106);
            this.TBoxNomeCadCli.Name = "TBoxNomeCadCli";
            this.TBoxNomeCadCli.Size = new System.Drawing.Size(237, 20);
            this.TBoxNomeCadCli.TabIndex = 69;
            // 
            // TBoxTipoLog
            // 
            this.TBoxTipoLog.Location = new System.Drawing.Point(442, 166);
            this.TBoxTipoLog.Name = "TBoxTipoLog";
            this.TBoxTipoLog.Size = new System.Drawing.Size(188, 20);
            this.TBoxTipoLog.TabIndex = 92;
            // 
            // lbTipoLogradouro
            // 
            this.lbTipoLogradouro.AutoSize = true;
            this.lbTipoLogradouro.BackColor = System.Drawing.Color.Transparent;
            this.lbTipoLogradouro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoLogradouro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTipoLogradouro.Location = new System.Drawing.Point(299, 166);
            this.lbTipoLogradouro.Name = "lbTipoLogradouro";
            this.lbTipoLogradouro.Size = new System.Drawing.Size(140, 21);
            this.lbTipoLogradouro.TabIndex = 93;
            this.lbTipoLogradouro.Text = "Tipo Logradouro:";
            // 
            // TBoxLogradouro
            // 
            this.TBoxLogradouro.Location = new System.Drawing.Point(442, 208);
            this.TBoxLogradouro.Name = "TBoxLogradouro";
            this.TBoxLogradouro.Size = new System.Drawing.Size(188, 20);
            this.TBoxLogradouro.TabIndex = 94;
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.BackColor = System.Drawing.Color.Transparent;
            this.lbLogradouro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogradouro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLogradouro.Location = new System.Drawing.Point(334, 208);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(102, 21);
            this.lbLogradouro.TabIndex = 95;
            this.lbLogradouro.Text = "Logradouro:";
            // 
            // TBoxBairro
            // 
            this.TBoxBairro.Location = new System.Drawing.Point(442, 249);
            this.TBoxBairro.Name = "TBoxBairro";
            this.TBoxBairro.Size = new System.Drawing.Size(188, 20);
            this.TBoxBairro.TabIndex = 96;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.Color.Transparent;
            this.lbBairro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBairro.Location = new System.Drawing.Point(373, 247);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(62, 21);
            this.lbBairro.TabIndex = 97;
            this.lbBairro.Text = "Bairro:";
            // 
            // TBoxCidade
            // 
            this.TBoxCidade.Location = new System.Drawing.Point(442, 293);
            this.TBoxCidade.Name = "TBoxCidade";
            this.TBoxCidade.Size = new System.Drawing.Size(188, 20);
            this.TBoxCidade.TabIndex = 98;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.BackColor = System.Drawing.Color.Transparent;
            this.lbCidade.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCidade.Location = new System.Drawing.Point(367, 291);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(69, 21);
            this.lbCidade.TabIndex = 99;
            this.lbCidade.Text = "Cidade:";
            // 
            // TBoxNumeroCasa
            // 
            this.TBoxNumeroCasa.Location = new System.Drawing.Point(714, 204);
            this.TBoxNumeroCasa.Name = "TBoxNumeroCasa";
            this.TBoxNumeroCasa.Size = new System.Drawing.Size(54, 20);
            this.TBoxNumeroCasa.TabIndex = 100;
            // 
            // lbNumeroCasa
            // 
            this.lbNumeroCasa.AutoSize = true;
            this.lbNumeroCasa.BackColor = System.Drawing.Color.Transparent;
            this.lbNumeroCasa.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroCasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNumeroCasa.Location = new System.Drawing.Point(675, 204);
            this.lbNumeroCasa.Name = "lbNumeroCasa";
            this.lbNumeroCasa.Size = new System.Drawing.Size(33, 21);
            this.lbNumeroCasa.TabIndex = 101;
            this.lbNumeroCasa.Text = "Nº:";
            // 
            // TBoxComplemento
            // 
            this.TBoxComplemento.Location = new System.Drawing.Point(441, 335);
            this.TBoxComplemento.Name = "TBoxComplemento";
            this.TBoxComplemento.Size = new System.Drawing.Size(188, 20);
            this.TBoxComplemento.TabIndex = 102;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lbComplemento.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbComplemento.Location = new System.Drawing.Point(317, 333);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(122, 21);
            this.lbComplemento.TabIndex = 103;
            this.lbComplemento.Text = "Complemento:";
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.Location = new System.Drawing.Point(314, 378);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(201, 44);
            this.btnAtualizarDados.TabIndex = 104;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // CBoxIDCli
            // 
            this.CBoxIDCli.FormattingEnabled = true;
            this.CBoxIDCli.Location = new System.Drawing.Point(125, 142);
            this.CBoxIDCli.Name = "CBoxIDCli";
            this.CBoxIDCli.Size = new System.Drawing.Size(52, 21);
            this.CBoxIDCli.TabIndex = 106;
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbIDCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbIDCliente.Location = new System.Drawing.Point(29, 140);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(90, 21);
            this.lbIDCliente.TabIndex = 107;
            this.lbIDCliente.Text = "ID Cliente:";
            // 
            // Cadastrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Facul.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.CBoxIDCli);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.TBoxComplemento);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.TBoxNumeroCasa);
            this.Controls.Add(this.lbNumeroCasa);
            this.Controls.Add(this.TBoxCidade);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.TBoxBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.TBoxLogradouro);
            this.Controls.Add(this.lbLogradouro);
            this.Controls.Add(this.TBoxTipoLog);
            this.Controls.Add(this.lbTipoLogradouro);
            this.Controls.Add(this.lbCadCli);
            this.Controls.Add(this.lbSexoCli);
            this.Controls.Add(this.CBoxSexoCadCli);
            this.Controls.Add(this.BtnLimparCadastroCli);
            this.Controls.Add(this.BtnCadastrarCli);
            this.Controls.Add(this.TBoxEmailCadCli);
            this.Controls.Add(this.lbEmailCli);
            this.Controls.Add(this.MTBoxCPFCadCli);
            this.Controls.Add(this.lbCPFCli);
            this.Controls.Add(this.MTBoxCelCadCli);
            this.Controls.Add(this.lbTelCli);
            this.Controls.Add(this.TBoxRGCadCli);
            this.Controls.Add(this.lbRGCli);
            this.Controls.Add(this.lbNomeCli);
            this.Controls.Add(this.TBoxNomeCadCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar_Cliente";
            this.Text = "Cadastrar_Cliente";
            this.Load += new System.EventHandler(this.Cadastrar_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCadCli;
        private System.Windows.Forms.Label lbSexoCli;
        private System.Windows.Forms.ComboBox CBoxSexoCadCli;
        private System.Windows.Forms.Button BtnLimparCadastroCli;
        private System.Windows.Forms.Button BtnCadastrarCli;
        private System.Windows.Forms.TextBox TBoxEmailCadCli;
        private System.Windows.Forms.Label lbEmailCli;
        private System.Windows.Forms.MaskedTextBox MTBoxCPFCadCli;
        private System.Windows.Forms.Label lbCPFCli;
        private System.Windows.Forms.MaskedTextBox MTBoxCelCadCli;
        private System.Windows.Forms.Label lbTelCli;
        private System.Windows.Forms.TextBox TBoxRGCadCli;
        private System.Windows.Forms.Label lbRGCli;
        private System.Windows.Forms.Label lbNomeCli;
        private System.Windows.Forms.TextBox TBoxNomeCadCli;
        private System.Windows.Forms.TextBox TBoxTipoLog;
        private System.Windows.Forms.Label lbTipoLogradouro;
        private System.Windows.Forms.TextBox TBoxLogradouro;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.TextBox TBoxBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox TBoxCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox TBoxNumeroCasa;
        private System.Windows.Forms.Label lbNumeroCasa;
        private System.Windows.Forms.TextBox TBoxComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.ComboBox CBoxIDCli;
        private System.Windows.Forms.Label lbIDCliente;
    }
}