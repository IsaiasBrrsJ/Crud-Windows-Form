
namespace ObjeFinanceiro
{
    partial class Sacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sacar));
            this.lblSacarID = new System.Windows.Forms.Label();
            this.lblSacarValor = new System.Windows.Forms.Label();
            this.txtSacarId = new System.Windows.Forms.TextBox();
            this.txtSacarValor = new System.Windows.Forms.TextBox();
            this.btnSacarVoltar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSacarID
            // 
            this.lblSacarID.AutoSize = true;
            this.lblSacarID.Location = new System.Drawing.Point(13, 91);
            this.lblSacarID.Name = "lblSacarID";
            this.lblSacarID.Size = new System.Drawing.Size(18, 15);
            this.lblSacarID.TabIndex = 0;
            this.lblSacarID.Text = "ID";
            // 
            // lblSacarValor
            // 
            this.lblSacarValor.AutoSize = true;
            this.lblSacarValor.Location = new System.Drawing.Point(13, 123);
            this.lblSacarValor.Name = "lblSacarValor";
            this.lblSacarValor.Size = new System.Drawing.Size(33, 15);
            this.lblSacarValor.TabIndex = 1;
            this.lblSacarValor.Text = "Valor";
            // 
            // txtSacarId
            // 
            this.txtSacarId.Location = new System.Drawing.Point(54, 88);
            this.txtSacarId.Name = "txtSacarId";
            this.txtSacarId.Size = new System.Drawing.Size(156, 23);
            this.txtSacarId.TabIndex = 2;
            // 
            // txtSacarValor
            // 
            this.txtSacarValor.Location = new System.Drawing.Point(54, 117);
            this.txtSacarValor.Name = "txtSacarValor";
            this.txtSacarValor.Size = new System.Drawing.Size(156, 23);
            this.txtSacarValor.TabIndex = 3;
            // 
            // btnSacarVoltar
            // 
            this.btnSacarVoltar.Location = new System.Drawing.Point(54, 158);
            this.btnSacarVoltar.Name = "btnSacarVoltar";
            this.btnSacarVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnSacarVoltar.TabIndex = 4;
            this.btnSacarVoltar.Text = "Voltar";
            this.btnSacarVoltar.UseVisualStyleBackColor = true;
            this.btnSacarVoltar.Click += new System.EventHandler(this.btnSacarVoltar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(135, 158);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(75, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 59);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 193);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnSacarVoltar);
            this.Controls.Add(this.txtSacarValor);
            this.Controls.Add(this.txtSacarId);
            this.Controls.Add(this.lblSacarValor);
            this.Controls.Add(this.lblSacarID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sacar";
            this.Load += new System.EventHandler(this.Sacar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSacarID;
        private System.Windows.Forms.Label lblSacarValor;
        private System.Windows.Forms.TextBox txtSacarId;
        private System.Windows.Forms.TextBox txtSacarValor;
        private System.Windows.Forms.Button btnSacarVoltar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}