
namespace ObjeFinanceiro
{
    partial class ExibeObjetivo
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
            this.listBoxExibeObjetivo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxExibeObjetivo
            // 
            this.listBoxExibeObjetivo.FormattingEnabled = true;
            this.listBoxExibeObjetivo.ItemHeight = 15;
            this.listBoxExibeObjetivo.Location = new System.Drawing.Point(12, 12);
            this.listBoxExibeObjetivo.Name = "listBoxExibeObjetivo";
            this.listBoxExibeObjetivo.Size = new System.Drawing.Size(551, 109);
            this.listBoxExibeObjetivo.TabIndex = 0;
            // 
            // ExibeObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 143);
            this.Controls.Add(this.listBoxExibeObjetivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExibeObjetivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExibeObjetivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExibeObjetivo_FormClosing);
            this.Load += new System.EventHandler(this.ExibeObjetivo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExibeObjetivo;
    }
}