
namespace ObjeFinanceiro
{
    partial class CadastrarObjetivoFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarObjetivoFinanceiro));
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtCadastrarObjetivo = new System.Windows.Forms.TextBox();
            this.txtCadastrarValorObjetivo = new System.Windows.Forms.TextBox();
            this.lblValorDoObjetivo = new System.Windows.Forms.Label();
            this.btnCadastrarVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(7, 76);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(52, 15);
            this.lblObjetivo.TabIndex = 0;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // txtCadastrarObjetivo
            // 
            this.txtCadastrarObjetivo.Location = new System.Drawing.Point(75, 73);
            this.txtCadastrarObjetivo.Name = "txtCadastrarObjetivo";
            this.txtCadastrarObjetivo.Size = new System.Drawing.Size(198, 23);
            this.txtCadastrarObjetivo.TabIndex = 1;
            // 
            // txtCadastrarValorObjetivo
            // 
            this.txtCadastrarValorObjetivo.Location = new System.Drawing.Point(75, 110);
            this.txtCadastrarValorObjetivo.Name = "txtCadastrarValorObjetivo";
            this.txtCadastrarValorObjetivo.Size = new System.Drawing.Size(198, 23);
            this.txtCadastrarValorObjetivo.TabIndex = 3;
            // 
            // lblValorDoObjetivo
            // 
            this.lblValorDoObjetivo.AutoSize = true;
            this.lblValorDoObjetivo.Location = new System.Drawing.Point(7, 113);
            this.lblValorDoObjetivo.Name = "lblValorDoObjetivo";
            this.lblValorDoObjetivo.Size = new System.Drawing.Size(33, 15);
            this.lblValorDoObjetivo.TabIndex = 2;
            this.lblValorDoObjetivo.Text = "Valor";
            // 
            // btnCadastrarVoltar
            // 
            this.btnCadastrarVoltar.Location = new System.Drawing.Point(75, 141);
            this.btnCadastrarVoltar.Name = "btnCadastrarVoltar";
            this.btnCadastrarVoltar.Size = new System.Drawing.Size(90, 23);
            this.btnCadastrarVoltar.TabIndex = 4;
            this.btnCadastrarVoltar.Text = "Voltar";
            this.btnCadastrarVoltar.UseVisualStyleBackColor = true;
            this.btnCadastrarVoltar.Click += new System.EventHandler(this.btnCadastrarVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(183, 141);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(110, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 55);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarObjetivoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 174);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCadastrarVoltar);
            this.Controls.Add(this.txtCadastrarValorObjetivo);
            this.Controls.Add(this.lblValorDoObjetivo);
            this.Controls.Add(this.txtCadastrarObjetivo);
            this.Controls.Add(this.lblObjetivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastrarObjetivoFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Objetivo";
            this.Load += new System.EventHandler(this.CadastrarObjetivoFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtCadastrarObjetivo;
        private System.Windows.Forms.TextBox txtCadastrarValorObjetivo;
        private System.Windows.Forms.Label lblValorDoObjetivo;
        private System.Windows.Forms.Button btnCadastrarVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}