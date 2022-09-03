using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjeFinanceiro
{
    public partial class ConsultarObjetivo : Form
    {
        List<ObjetivoFinanceiro> listConsulta = new List<ObjetivoFinanceiro>(); 
        public ConsultarObjetivo()
        {
            InitializeComponent();
        }

        private void ConsultarObjetivo_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void btnConsultarVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void RecebeLista(ref List<ObjetivoFinanceiro> listObjetivos)
        {
            listConsulta.AddRange(listObjetivos);
        }
        private void Consulta()
        {
            if (String.IsNullOrEmpty(txtIDConsultar.Text))
            {
                MessageBox.Show("PREENCHA O CAMPO ID", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var Id = Convert.ToInt32(txtIDConsultar.Text);
            foreach (var item in listConsulta)
            {
                if (item.IdObjetivo.Equals(Id))
                {
                    Hide();
                    var exibe = new ExibeObjetivo();
                    exibe.RecebeLista(Id, item.NomeObjetivo, item.ValorDoObjetivo, item.Saldo);
                    exibe.ShowDialog();
                    Show();
                    return;
                }
            }
            MessageBox.Show("ID INCORRETO OU INEXISTENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
