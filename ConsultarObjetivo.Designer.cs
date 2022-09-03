
namespace ObjeFinanceiro
{
    partial class ConsultarObjetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarObjetivo));
            this.lblConsultarId = new System.Windows.Forms.Label();
            this.txtIDConsultar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultarVoltar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarId
            // 
            this.lblConsultarId.AutoSize = true;
            this.lblConsultarId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblConsultarId.Location = new System.Drawing.Point(12, 81);
            this.lblConsultarId.Name = "lblConsultarId";
            this.lblConsultarId.Size = new System.Drawing.Size(19, 15);
            this.lblConsultarId.TabIndex = 0;
            this.lblConsultarId.Text = "ID";
            // 
            // txtIDConsultar
            // 
            this.txtIDConsultar.Location = new System.Drawing.Point(38, 78);
            this.txtIDConsultar.Name = "txtIDConsultar";
            this.txtIDConsultar.Size = new System.Drawing.Size(156, 23);
            this.txtIDConsultar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultarVoltar
            // 
            this.btnConsultarVoltar.Location = new System.Drawing.Point(38, 119);
            this.btnConsultarVoltar.Name = "btnConsultarVoltar";
            this.btnConsultarVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVoltar.TabIndex = 3;
            this.btnConsultarVoltar.Text = "Voltar";
            this.btnConsultarVoltar.UseVisualStyleBackColor = true;
            this.btnConsultarVoltar.Click += new System.EventHandler(this.btnConsultarVoltar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(119, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ConsultarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 153);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnConsultarVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIDConsultar);
            this.Controls.Add(this.lblConsultarId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarObjetivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Objetivo";
            this.Load += new System.EventHandler(this.ConsultarObjetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarId;
        private System.Windows.Forms.TextBox txtIDConsultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultarVoltar;
        private System.Windows.Forms.Button btnConsultar;
    }
}