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
    public partial class CadastrarObjetivoFinanceiro : Form
    {
        List<ObjetivoFinanceiro> listCadastrarObjetivo = new List<ObjetivoFinanceiro>();
        public CadastrarObjetivoFinanceiro()
        {
            InitializeComponent();
        }
        private void CadastrarObjetivoFinanceiro_Load(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnCadastrarVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cadastrar()
        {
            if (String.IsNullOrWhiteSpace(txtCadastrarObjetivo.Text) || String.IsNullOrWhiteSpace(txtCadastrarValorObjetivo.Text))
            {
                if (String.IsNullOrWhiteSpace(txtCadastrarObjetivo.Text))
                {
                    txtCadastrarObjetivo.Focus();
                }
                else if (String.IsNullOrWhiteSpace(txtCadastrarValorObjetivo.Text))
                {
                    txtCadastrarValorObjetivo.Focus();
                }

                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var objetivo = txtCadastrarObjetivo.Text;
            decimal valorObjetivo;

            var Convertervalor = decimal.TryParse(txtCadastrarValorObjetivo.Text, out valorObjetivo);
            if(Convertervalor is false || valorObjetivo < 0)
            {
                MessageBox.Show("VALOR INCORRETO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCadastrarValorObjetivo.Text = "";
                return;
            }

            var ID = new Random().Next(0, 100);
            listCadastrarObjetivo.Add
                (
                 new ObjetivoFinanceiro
                 {
                     IdObjetivo = ID,
                     NomeObjetivo = objetivo,
                     ValorDoObjetivo = Convert.ToDecimal(valorObjetivo),
                     Saldo = 0
                 }
                );
            MessageBox.Show($"CADASTRO REALIZADO, GUARDE O ID: {ID}", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public ref List<ObjetivoFinanceiro> RetornarLista()
        {
            return ref listCadastrarObjetivo;
        }
    }
}
