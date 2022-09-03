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
    public partial class Sacar : Form
    {
        List<ObjetivoFinanceiro> objSacar = new List<ObjetivoFinanceiro>();
        public Sacar()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Verifica();
        }

        private void btnSacarVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void RecebeLista(ref List<ObjetivoFinanceiro> listSacar)
        {
            objSacar.AddRange(listSacar);
        }
        private void Verifica()
        {
            
            if (((String.IsNullOrWhiteSpace(txtSacarId.Text)) || (txtSacarId.Text == "")) || ((String.IsNullOrWhiteSpace(txtSacarValor.Text)) || txtSacarValor.Text == ""))
            {
                if (String.IsNullOrWhiteSpace(txtSacarId.Text))
                {
                    txtSacarId.Focus();
                }

                if (String.IsNullOrWhiteSpace(txtSacarValor.Text))
                {
                    txtSacarValor.Focus();
                }


                MessageBox.Show("Preencha todos os campos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                char[] remover = { '.', ',', '-' };
                int id;
                decimal valor;
                var converterPraInteiro = int.TryParse(txtSacarId.Text, out id);
                var converterPraDecimal = decimal.TryParse(txtSacarValor.Text.Trim(remover), out valor);

                if(converterPraDecimal is false || converterPraInteiro is false)
                {
                    MessageBox.Show("VALOR INCORRETO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSacarId.Text = "";
                    txtSacarValor.Text = "";
                    return;
                }

                foreach (var item in objSacar)
                {
                    if (item.IdObjetivo.Equals(id))
                    {
                         
                        if (valor <= item.Saldo && item.Saldo != 0)
                        {   
                            
                            var saldo = item.Saldo.ToString().Trim(remover);
                            var calculo = (Convert.ToDecimal(saldo) - valor);
                            item.Saldo = calculo;
                            var result = MessageBox.Show("SAQUE REALIZADO, VISUALIZAR SALDO ", "SUCESSO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result.Equals(DialogResult.Yes))
                            {
                                Hide();
                                var exibiObjetivo = new ExibeObjetivo();
                                exibiObjetivo.RecebeLista(item.IdObjetivo, item.NomeObjetivo, item.ValorDoObjetivo, item.Saldo);
                                exibiObjetivo.ShowDialog();
                                Show();
                            }
                            else
                            {
                                MessageBox.Show("Obrigado por utilizar nossos serviços");
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Saldo Insuficiente", "AVISO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                       
                    }
                }
            }
            MessageBox.Show("ID INCORRETO OU INEXISTENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Sacar_Load(object sender, EventArgs e)
        {

        }
    }
}
