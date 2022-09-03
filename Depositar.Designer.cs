
namespace ObjeFinanceiro
{
    partial class Depositar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depositar));
            this.lblID = new System.Windows.Forms.Label();
            this.txtDepositarID = new System.Windows.Forms.TextBox();
            this.txtDepositarValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnDepositarVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtDepositarID
            // 
            this.txtDepositarID.Location = new System.Drawing.Point(52, 71);
            this.txtDepositarID.Name = "txtDepositarID";
            this.txtDepositarID.Size = new System.Drawing.Size(156, 23);
            this.txtDepositarID.TabIndex = 1;
            // 
            // txtDepositarValor
            // 
            this.txtDepositarValor.Location = new System.Drawing.Point(51, 103);
            this.txtDepositarValor.Name = "txtDepositarValor";
            this.txtDepositarValor.Size = new System.Drawing.Size(156, 23);
            this.txtDepositarValor.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 106);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(133, 138);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnDepositarVoltar
            // 
            this.btnDepositarVoltar.Location = new System.Drawing.Point(52, 138);
            this.btnDepositarVoltar.Name = "btnDepositarVoltar";
            this.btnDepositarVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositarVoltar.TabIndex = 5;
            this.btnDepositarVoltar.Text = "Voltar";
            this.btnDepositarVoltar.UseVisualStyleBackColor = true;
            this.btnDepositarVoltar.Click += new System.EventHandler(this.btnDepositarVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 173);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDepositarVoltar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtDepositarValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDepositarID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.Load += new System.EventHandler(this.Depositar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDepositarID;
        private System.Windows.Forms.TextBox txtDepositarValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnDepositarVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}