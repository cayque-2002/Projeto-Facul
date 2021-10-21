
namespace Projeto_Facul
{
    partial class FRMFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMFuncionario));
            this.btnPesquisarFunc = new System.Windows.Forms.Button();
            this.LbPesquisarFunc = new System.Windows.Forms.Label();
            this.TBoxPesquisarFunc = new System.Windows.Forms.TextBox();
            this.DGVFunc = new System.Windows.Forms.DataGridView();
            this.btnIncluirFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarFunc
            // 
            this.btnPesquisarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFunc.Location = new System.Drawing.Point(630, 38);
            this.btnPesquisarFunc.Name = "btnPesquisarFunc";
            this.btnPesquisarFunc.Size = new System.Drawing.Size(87, 25);
            this.btnPesquisarFunc.TabIndex = 22;
            this.btnPesquisarFunc.Text = "Pesquisar";
            this.btnPesquisarFunc.UseVisualStyleBackColor = true;
            // 
            // LbPesquisarFunc
            // 
            this.LbPesquisarFunc.AutoSize = true;
            this.LbPesquisarFunc.BackColor = System.Drawing.Color.Transparent;
            this.LbPesquisarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPesquisarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPesquisarFunc.Location = new System.Drawing.Point(43, 41);
            this.LbPesquisarFunc.Name = "LbPesquisarFunc";
            this.LbPesquisarFunc.Size = new System.Drawing.Size(248, 25);
            this.LbPesquisarFunc.TabIndex = 21;
            this.LbPesquisarFunc.Text = "Pesquisar funcionário:";
            // 
            // TBoxPesquisarFunc
            // 
            this.TBoxPesquisarFunc.Location = new System.Drawing.Point(249, 43);
            this.TBoxPesquisarFunc.Name = "TBoxPesquisarFunc";
            this.TBoxPesquisarFunc.Size = new System.Drawing.Size(375, 20);
            this.TBoxPesquisarFunc.TabIndex = 20;
            // 
            // DGVFunc
            // 
            this.DGVFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFunc.Location = new System.Drawing.Point(48, 89);
            this.DGVFunc.Name = "DGVFunc";
            this.DGVFunc.Size = new System.Drawing.Size(708, 284);
            this.DGVFunc.TabIndex = 19;
            // 
            // btnIncluirFunc
            // 
            this.btnIncluirFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirFunc.Location = new System.Drawing.Point(48, 390);
            this.btnIncluirFunc.Name = "btnIncluirFunc";
            this.btnIncluirFunc.Size = new System.Drawing.Size(87, 25);
            this.btnIncluirFunc.TabIndex = 23;
            this.btnIncluirFunc.Text = "Incluir";
            this.btnIncluirFunc.UseVisualStyleBackColor = true;
            this.btnIncluirFunc.Click += new System.EventHandler(this.btnIncluirFunc_Click_1);
            // 
            // FRMFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncluirFunc);
            this.Controls.Add(this.btnPesquisarFunc);
            this.Controls.Add(this.LbPesquisarFunc);
            this.Controls.Add(this.TBoxPesquisarFunc);
            this.Controls.Add(this.DGVFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMFuncionario";
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarFunc;
        private System.Windows.Forms.Label LbPesquisarFunc;
        private System.Windows.Forms.TextBox TBoxPesquisarFunc;
        private System.Windows.Forms.DataGridView DGVFunc;
        private System.Windows.Forms.Button btnIncluirFunc;
    }
}