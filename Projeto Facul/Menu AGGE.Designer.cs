
namespace Projeto_Facul
{
    partial class FRM_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            this.btnModuloTec = new System.Windows.Forms.Button();
            this.btnModuloAdm = new System.Windows.Forms.Button();
            this.lbMenuAGGE = new System.Windows.Forms.Label();
            this.BtnModuloAtendimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModuloTec
            // 
            this.btnModuloTec.BackColor = System.Drawing.Color.Transparent;
            this.btnModuloTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModuloTec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModuloTec.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuloTec.Image = ((System.Drawing.Image)(resources.GetObject("btnModuloTec.Image")));
            this.btnModuloTec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModuloTec.Location = new System.Drawing.Point(46, 73);
            this.btnModuloTec.Name = "btnModuloTec";
            this.btnModuloTec.Size = new System.Drawing.Size(172, 146);
            this.btnModuloTec.TabIndex = 0;
            this.btnModuloTec.Text = "TÉCNICO";
            this.btnModuloTec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModuloTec.UseVisualStyleBackColor = false;
            this.btnModuloTec.Click += new System.EventHandler(this.btnModuloTec_Click);
            // 
            // btnModuloAdm
            // 
            this.btnModuloAdm.BackColor = System.Drawing.Color.Transparent;
            this.btnModuloAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModuloAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModuloAdm.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuloAdm.ForeColor = System.Drawing.Color.Black;
            this.btnModuloAdm.Image = global::Projeto_Facul.Properties.Resources.administrador1;
            this.btnModuloAdm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModuloAdm.Location = new System.Drawing.Point(578, 73);
            this.btnModuloAdm.Name = "btnModuloAdm";
            this.btnModuloAdm.Size = new System.Drawing.Size(172, 146);
            this.btnModuloAdm.TabIndex = 1;
            this.btnModuloAdm.Text = "ADMINISTRATIVO";
            this.btnModuloAdm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModuloAdm.UseVisualStyleBackColor = false;
            this.btnModuloAdm.Click += new System.EventHandler(this.btnModuloAdm_Click);
            // 
            // lbMenuAGGE
            // 
            this.lbMenuAGGE.AutoSize = true;
            this.lbMenuAGGE.BackColor = System.Drawing.Color.Transparent;
            this.lbMenuAGGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMenuAGGE.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuAGGE.Location = new System.Drawing.Point(225, 9);
            this.lbMenuAGGE.Name = "lbMenuAGGE";
            this.lbMenuAGGE.Size = new System.Drawing.Size(349, 57);
            this.lbMenuAGGE.TabIndex = 2;
            this.lbMenuAGGE.Text = "MENU AGGE";
            // 
            // BtnModuloAtendimento
            // 
            this.BtnModuloAtendimento.BackColor = System.Drawing.Color.Transparent;
            this.BtnModuloAtendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModuloAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModuloAtendimento.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModuloAtendimento.ForeColor = System.Drawing.Color.Black;
            this.BtnModuloAtendimento.Image = global::Projeto_Facul.Properties.Resources.atendimento_ao_cliente__1_;
            this.BtnModuloAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModuloAtendimento.Location = new System.Drawing.Point(315, 73);
            this.BtnModuloAtendimento.Name = "BtnModuloAtendimento";
            this.BtnModuloAtendimento.Size = new System.Drawing.Size(172, 146);
            this.BtnModuloAtendimento.TabIndex = 3;
            this.BtnModuloAtendimento.Text = "ATENDIMENTO";
            this.BtnModuloAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModuloAtendimento.UseVisualStyleBackColor = false;
            this.BtnModuloAtendimento.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 263);
            this.Controls.Add(this.BtnModuloAtendimento);
            this.Controls.Add(this.lbMenuAGGE);
            this.Controls.Add(this.btnModuloAdm);
            this.Controls.Add(this.btnModuloTec);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu AGGE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Menu_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_Menu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModuloTec;
        private System.Windows.Forms.Button btnModuloAdm;
        private System.Windows.Forms.Label lbMenuAGGE;
        private System.Windows.Forms.Button BtnModuloAtendimento;
    }
}