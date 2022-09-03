using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ObjeFinanceiro
{
    public partial class ExibeObjetivo : Form
    {
        public ExibeObjetivo()
        {
            InitializeComponent();
        }

        private void ExibeObjetivo_Load(object sender, EventArgs e)
        {

        }
        public void RecebeLista(int id, string objetivo, decimal valorObjetivo, decimal saldoAtual)
        {
          
            listBoxExibeObjetivo.Items.Add
            (
             $"ID: {id}"
            ) ;
            listBoxExibeObjetivo.Items.Add
            (
             $"Objetivo: {objetivo}"
            );

            listBoxExibeObjetivo.Items.Add
            (
             $"Valor do Objetivo: {valorObjetivo.ToString("C",CultureInfo.CurrentCulture)}"
            );
            listBoxExibeObjetivo.Items.Add
            (
             $"Saldo Atual: {saldoAtual.ToString("C", CultureInfo.CurrentCulture)}"
            );

        }

        private void ExibeObjetivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBoxExibeObjetivo.Items.Clear();
        }
    }
}
