using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ObjeFinanceiro
{
    public partial class DeletarObjetivo : Form
    {
        public int ID { get; private set; }
       
        public DeletarObjetivo()
        {
            ID = -1;
            InitializeComponent();
            ShowDialog();
        }
        private void DeletarObjetivo_Load(object sender, EventArgs e)
        {

        }

        private void btnDeletarVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Deletar();

            Close();
        }
        public  void Deletar()
        {
            int id;
            bool opcaoValida = true;

            opcaoValida = int.TryParse(txtDeletarID.Text, out id);

            if (opcaoValida is false)
            {
                ID = -1;
              
            }
            else
            {
                ID = id;
            }
        }

    }
}
