
namespace Projeto_Facul
{
    partial class CadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFuncionario));
            this.LbPerfil = new System.Windows.Forms.Label();
            this.CBoxPerfil = new System.Windows.Forms.ComboBox();
            this.BtnLimparCadastroFunc = new System.Windows.Forms.Button();
            this.BtnCadastrarFunc = new System.Windows.Forms.Button();
            this.TBoxEmailCadFunc = new System.Windows.Forms.TextBox();
            this.lbEmailFunc = new System.Windows.Forms.Label();
            this.MTBoxCPFCadFunc = new System.Windows.Forms.MaskedTextBox();
            this.lbCPFFunc = new System.Windows.Forms.Label();
            this.MTBoxCelCadFunc = new System.Windows.Forms.MaskedTextBox();
            this.lbTelFunc = new System.Windows.Forms.Label();
            this.TBoxRGCadFunc = new System.Windows.Forms.TextBox();
            this.lbRGFunc = new System.Windows.Forms.Label();
            this.lbNomeFunc = new System.Windows.Forms.Label();
            this.TBoxNomeCadFunc = new System.Windows.Forms.TextBox();
            this.lbCadFunc = new System.Windows.Forms.Label();
            this.lbSenhaFunc = new System.Windows.Forms.Label();
            this.TBoxSenhaCadFunc = new System.Windows.Forms.TextBox();
            this.TBoxLoginCadFunc = new System.Windows.Forms.TextBox();
            this.lbLoginFunc = new System.Windows.Forms.Label();
            this.lbSexoFunc = new System.Windows.Forms.Label();
            this.CBoxSexoCadFunc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbPerfil
            // 
            this.LbPerfil.AutoSize = true;
            this.LbPerfil.BackColor = System.Drawing.Color.Transparent;
            this.LbPerfil.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbPerfil.Location = new System.Drawing.Point(440, 215);
            this.LbPerfil.Name = "LbPerfil";
            this.LbPerfil.Size = new System.Drawing.Size(57, 21);
            this.LbPerfil.TabIndex = 43;
            this.LbPerfil.Text = "Perfil:";
            // 
            // CBoxPerfil
            // 
            this.CBoxPerfil.FormattingEnabled = true;
            this.CBoxPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Técnico",
            "Vendedor"});
            this.CBoxPerfil.Location = new System.Drawing.Point(503, 217);
            this.CBoxPerfil.Name = "CBoxPerfil";
            this.CBoxPerfil.Size = new System.Drawing.Size(121, 21);
            this.CBoxPerfil.TabIndex = 42;
            // 
            // BtnLimparCadastroFunc
            // 
            this.BtnLimparCadastroFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimparCadastroFunc.Location = new System.Drawing.Point(518, 331);
            this.BtnLimparCadastroFunc.Name = "BtnLimparCadastroFunc";
            this.BtnLimparCadastroFunc.Size = new System.Drawing.Size(123, 44);
            this.BtnLimparCadastroFunc.TabIndex = 38;
            this.BtnLimparCadastroFunc.Text = "Limpar";
            this.BtnLimparCadastroFunc.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrarFunc
            // 
            this.BtnCadastrarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarFunc.Location = new System.Drawing.Point(313, 331);
            this.BtnCadastrarFunc.Name = "BtnCadastrarFunc";
            this.BtnCadastrarFunc.Size = new System.Drawing.Size(123, 44);
            this.BtnCadastrarFunc.TabIndex = 37;
            this.BtnCadastrarFunc.Text = "Cadastrar";
            this.BtnCadastrarFunc.UseVisualStyleBackColor = true;
            this.BtnCadastrarFunc.Click += new System.EventHandler(this.BtnCadastrarFunc_Click);
            // 
            // TBoxEmailCadFunc
            // 
            this.TBoxEmailCadFunc.Location = new System.Drawing.Point(497, 103);
            this.TBoxEmailCadFunc.Name = "TBoxEmailCadFunc";
            this.TBoxEmailCadFunc.Size = new System.Drawing.Size(188, 20);
            this.TBoxEmailCadFunc.TabIndex = 30;
            // 
            // lbEmailFunc
            // 
            this.lbEmailFunc.AutoSize = true;
            this.lbEmailFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbEmailFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEmailFunc.Location = new System.Drawing.Point(439, 102);
            this.lbEmailFunc.Name = "lbEmailFunc";
            this.lbEmailFunc.Size = new System.Drawing.Size(65, 21);
            this.lbEmailFunc.TabIndex = 35;
            this.lbEmailFunc.Text = "E-mail:";
            // 
            // MTBoxCPFCadFunc
            // 
            this.MTBoxCPFCadFunc.Location = new System.Drawing.Point(161, 191);
            this.MTBoxCPFCadFunc.Mask = "000.000.000-00";
            this.MTBoxCPFCadFunc.Name = "MTBoxCPFCadFunc";
            this.MTBoxCPFCadFunc.Size = new System.Drawing.Size(152, 20);
            this.MTBoxCPFCadFunc.TabIndex = 28;
            // 
            // lbCPFFunc
            // 
            this.lbCPFFunc.AutoSize = true;
            this.lbCPFFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbCPFFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPFFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCPFFunc.Location = new System.Drawing.Point(119, 189);
            this.lbCPFFunc.Name = "lbCPFFunc";
            this.lbCPFFunc.Size = new System.Drawing.Size(45, 21);
            this.lbCPFFunc.TabIndex = 33;
            this.lbCPFFunc.Text = "CPF:";
            // 
            // MTBoxCelCadFunc
            // 
            this.MTBoxCelCadFunc.Location = new System.Drawing.Point(161, 232);
            this.MTBoxCelCadFunc.Mask = "(99) 00000-0000";
            this.MTBoxCelCadFunc.Name = "MTBoxCelCadFunc";
            this.MTBoxCelCadFunc.Size = new System.Drawing.Size(152, 20);
            this.MTBoxCelCadFunc.TabIndex = 27;
            // 
            // lbTelFunc
            // 
            this.lbTelFunc.AutoSize = true;
            this.lbTelFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbTelFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTelFunc.Location = new System.Drawing.Point(94, 232);
            this.lbTelFunc.Name = "lbTelFunc";
            this.lbTelFunc.Size = new System.Drawing.Size(70, 21);
            this.lbTelFunc.TabIndex = 29;
            this.lbTelFunc.Text = "Celular:";
            // 
            // TBoxRGCadFunc
            // 
            this.TBoxRGCadFunc.Location = new System.Drawing.Point(161, 141);
            this.TBoxRGCadFunc.Name = "TBoxRGCadFunc";
            this.TBoxRGCadFunc.Size = new System.Drawing.Size(152, 20);
            this.TBoxRGCadFunc.TabIndex = 25;
            // 
            // lbRGFunc
            // 
            this.lbRGFunc.AutoSize = true;
            this.lbRGFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbRGFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRGFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRGFunc.Location = new System.Drawing.Point(127, 141);
            this.lbRGFunc.Name = "lbRGFunc";
            this.lbRGFunc.Size = new System.Drawing.Size(37, 21);
            this.lbRGFunc.TabIndex = 26;
            this.lbRGFunc.Text = "RG:";
            // 
            // lbNomeFunc
            // 
            this.lbNomeFunc.AutoSize = true;
            this.lbNomeFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNomeFunc.Location = new System.Drawing.Point(105, 101);
            this.lbNomeFunc.Name = "lbNomeFunc";
            this.lbNomeFunc.Size = new System.Drawing.Size(59, 21);
            this.lbNomeFunc.TabIndex = 24;
            this.lbNomeFunc.Text = "Nome:";
            // 
            // TBoxNomeCadFunc
            // 
            this.TBoxNomeCadFunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBoxNomeCadFunc.Location = new System.Drawing.Point(161, 101);
            this.TBoxNomeCadFunc.Name = "TBoxNomeCadFunc";
            this.TBoxNomeCadFunc.Size = new System.Drawing.Size(275, 20);
            this.TBoxNomeCadFunc.TabIndex = 23;
            // 
            // lbCadFunc
            // 
            this.lbCadFunc.AutoSize = true;
            this.lbCadFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbCadFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCadFunc.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadFunc.Location = new System.Drawing.Point(96, 22);
            this.lbCadFunc.Name = "lbCadFunc";
            this.lbCadFunc.Size = new System.Drawing.Size(554, 59);
            this.lbCadFunc.TabIndex = 22;
            this.lbCadFunc.Text = "Cadastrar Funcionário";
            // 
            // lbSenhaFunc
            // 
            this.lbSenhaFunc.AutoSize = true;
            this.lbSenhaFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbSenhaFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSenhaFunc.Location = new System.Drawing.Point(433, 173);
            this.lbSenhaFunc.Name = "lbSenhaFunc";
            this.lbSenhaFunc.Size = new System.Drawing.Size(64, 21);
            this.lbSenhaFunc.TabIndex = 41;
            this.lbSenhaFunc.Text = "Senha:";
            // 
            // TBoxSenhaCadFunc
            // 
            this.TBoxSenhaCadFunc.Location = new System.Drawing.Point(503, 175);
            this.TBoxSenhaCadFunc.Name = "TBoxSenhaCadFunc";
            this.TBoxSenhaCadFunc.PasswordChar = '*';
            this.TBoxSenhaCadFunc.Size = new System.Drawing.Size(147, 20);
            this.TBoxSenhaCadFunc.TabIndex = 34;
            // 
            // TBoxLoginCadFunc
            // 
            this.TBoxLoginCadFunc.Location = new System.Drawing.Point(503, 135);
            this.TBoxLoginCadFunc.Name = "TBoxLoginCadFunc";
            this.TBoxLoginCadFunc.Size = new System.Drawing.Size(147, 20);
            this.TBoxLoginCadFunc.TabIndex = 32;
            // 
            // lbLoginFunc
            // 
            this.lbLoginFunc.AutoSize = true;
            this.lbLoginFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLoginFunc.Location = new System.Drawing.Point(445, 133);
            this.lbLoginFunc.Name = "lbLoginFunc";
            this.lbLoginFunc.Size = new System.Drawing.Size(57, 21);
            this.lbLoginFunc.TabIndex = 39;
            this.lbLoginFunc.Text = "Login:";
            // 
            // lbSexoFunc
            // 
            this.lbSexoFunc.AutoSize = true;
            this.lbSexoFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbSexoFunc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexoFunc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSexoFunc.Location = new System.Drawing.Point(98, 288);
            this.lbSexoFunc.Name = "lbSexoFunc";
            this.lbSexoFunc.Size = new System.Drawing.Size(51, 21);
            this.lbSexoFunc.TabIndex = 45;
            this.lbSexoFunc.Text = "Sexo:";
            // 
            // CBoxSexoCadFunc
            // 
            this.CBoxSexoCadFunc.FormattingEnabled = true;
            this.CBoxSexoCadFunc.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CBoxSexoCadFunc.Location = new System.Drawing.Point(161, 290);
            this.CBoxSexoCadFunc.Name = "CBoxSexoCadFunc";
            this.CBoxSexoCadFunc.Size = new System.Drawing.Size(121, 21);
            this.CBoxSexoCadFunc.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSexoFunc);
            this.Controls.Add(this.CBoxSexoCadFunc);
            this.Controls.Add(this.LbPerfil);
            this.Controls.Add(this.CBoxPerfil);
            this.Controls.Add(this.BtnLimparCadastroFunc);
            this.Controls.Add(this.BtnCadastrarFunc);
            this.Controls.Add(this.TBoxSenhaCadFunc);
            this.Controls.Add(this.lbSenhaFunc);
            this.Controls.Add(this.TBoxLoginCadFunc);
            this.Controls.Add(this.lbLoginFunc);
            this.Controls.Add(this.TBoxEmailCadFunc);
            this.Controls.Add(this.lbEmailFunc);
            this.Controls.Add(this.MTBoxCPFCadFunc);
            this.Controls.Add(this.lbCPFFunc);
            this.Controls.Add(this.MTBoxCelCadFunc);
            this.Controls.Add(this.lbTelFunc);
            this.Controls.Add(this.TBoxRGCadFunc);
            this.Controls.Add(this.lbRGFunc);
            this.Controls.Add(this.lbNomeFunc);
            this.Controls.Add(this.TBoxNomeCadFunc);
            this.Controls.Add(this.lbCadFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarFuncionario";
            this.Text = "CadastrarFuncionario";
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPerfil;
        private System.Windows.Forms.ComboBox CBoxPerfil;
        private System.Windows.Forms.Button BtnLimparCadastroFunc;
        private System.Windows.Forms.Button BtnCadastrarFunc;
        private System.Windows.Forms.TextBox TBoxEmailCadFunc;
        private System.Windows.Forms.Label lbEmailFunc;
        private System.Windows.Forms.MaskedTextBox MTBoxCPFCadFunc;
        private System.Windows.Forms.Label lbCPFFunc;
        private System.Windows.Forms.MaskedTextBox MTBoxCelCadFunc;
        private System.Windows.Forms.Label lbTelFunc;
        private System.Windows.Forms.TextBox TBoxRGCadFunc;
        private System.Windows.Forms.Label lbRGFunc;
        private System.Windows.Forms.Label lbNomeFunc;
        private System.Windows.Forms.TextBox TBoxNomeCadFunc;
        private System.Windows.Forms.Label lbCadFunc;
        private System.Windows.Forms.Label lbSenhaFunc;
        private System.Windows.Forms.TextBox TBoxSenhaCadFunc;
        private System.Windows.Forms.TextBox TBoxLoginCadFunc;
        private System.Windows.Forms.Label lbLoginFunc;
        private System.Windows.Forms.Label lbSexoFunc;
        private System.Windows.Forms.ComboBox CBoxSexoCadFunc;
        private System.Windows.Forms.Button button1;
    }
}