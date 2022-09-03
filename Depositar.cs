using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;


namespace ObjeFinanceiro
{
    public partial class Depositar : Form
    {
        List<ObjetivoFinanceiro> objetivo = new List<ObjetivoFinanceiro>();
        public Depositar()  
        {
            InitializeComponent();
        }

        private void Depositar_Load(object sender, EventArgs e)
        {

        }
        public void RecebeLista(ref List<ObjetivoFinanceiro> listObje)
        {
            objetivo.AddRange(listObje);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if ( ((String.IsNullOrWhiteSpace(txtDepositarValor.Text)) || (txtDepositarValor.Text == "")) || ((String.IsNullOrWhiteSpace(txtDepositarID.Text)) || txtDepositarID.Text == ""))
            {
                if (String.IsNullOrWhiteSpace(txtDepositarValor.Text))
                {
                    txtDepositarValor.Focus();
                }

                if (String.IsNullOrWhiteSpace(txtDepositarID.Text))
                {
                    txtDepositarID.Focus();
                }

              
                MessageBox.Show("Preencha todos os campos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                char[] remover = { '.', ',', '-' };
                int id;
                decimal Valordepositar;

                var converterInt = int.TryParse(txtDepositarID.Text, out id);
                var converterDecimal = decimal.TryParse(txtDepositarValor.Text, out Valordepositar);
                if (converterInt is false || converterDecimal is false)
                {
                    MessageBox.Show("VALOR INCORRETO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepositarID.Text = "";
                    txtDepositarValor.Text = "";
                    return;
                }

                if (Valordepositar > 0)
                {
                    foreach (var item in objetivo)
                    {
                        if (item.IdObjetivo.Equals(Convert.ToInt32(txtDepositarID.Text)))
                        {
                            item.Saldo += Convert.ToDecimal(Valordepositar);
                            var result = MessageBox.Show("DEPOSITO REALIZADO, VISUALIZAR SALDO ", "SUCESSO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                MessageBox.Show("Obrigado por utilizar nossos serviços", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valor deve ser maior que ZERO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }

            MessageBox.Show("ID INCORRETO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDepositarVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
