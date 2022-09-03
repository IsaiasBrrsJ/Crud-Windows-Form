
namespace ObjeFinanceiro
{
    partial class DeletarObjetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarObjetivo));
            this.lblDeletar = new System.Windows.Forms.Label();
            this.txtDeletarID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnDeletarVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeletar
            // 
            this.lblDeletar.AutoSize = true;
            this.lblDeletar.Location = new System.Drawing.Point(12, 102);
            this.lblDeletar.Name = "lblDeletar";
            this.lblDeletar.Size = new System.Drawing.Size(18, 15);
            this.lblDeletar.TabIndex = 0;
            this.lblDeletar.Text = "ID";
            // 
            // txtDeletarID
            // 
            this.txtDeletarID.Location = new System.Drawing.Point(36, 102);
            this.txtDeletarID.Name = "txtDeletarID";
            this.txtDeletarID.Size = new System.Drawing.Size(139, 23);
            this.txtDeletarID.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(59, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(104, 153);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(71, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnDeletarVoltar
            // 
            this.btnDeletarVoltar.Location = new System.Drawing.Point(36, 153);
            this.btnDeletarVoltar.Name = "btnDeletarVoltar";
            this.btnDeletarVoltar.Size = new System.Drawing.Size(62, 23);
            this.btnDeletarVoltar.TabIndex = 4;
            this.btnDeletarVoltar.Text = "Voltar";
            this.btnDeletarVoltar.UseVisualStyleBackColor = true;
            this.btnDeletarVoltar.Click += new System.EventHandler(this.btnDeletarVoltar_Click);
            // 
            // DeletarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 188);
            this.Controls.Add(this.btnDeletarVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDeletarID);
            this.Controls.Add(this.lblDeletar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DeletarObjetivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Objetivo";
            this.Load += new System.EventHandler(this.DeletarObjetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeletar;
        private System.Windows.Forms.TextBox txtDeletarID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnDeletarVoltar;
    }
}