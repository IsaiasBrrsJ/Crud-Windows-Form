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
    public partial class Form1 : Form
    {
        CadastrarObjetivoFinanceiro cadastrarObjetivo;
        List<ObjetivoFinanceiro> listObjetivo = new List<ObjetivoFinanceiro>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboMenuOpcoes.Items.Add("Cadastrar Objetivo");
            comboMenuOpcoes.Items.Add("Consultar");
            comboMenuOpcoes.Items.Add("Depositar");
            comboMenuOpcoes.Items.Add("Sacar");
            comboMenuOpcoes.Items.Add("Deletar Objetivo");
            comboMenuOpcoes.SelectedIndex = 0;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {   
            
            Hide();
            switch (comboMenuOpcoes.SelectedItem)
            {
                case "Cadastrar Objetivo":
                    CadastrarObjetivo();
            
                    break;
                case "Consultar":
                    ConsultarObjetivos();
                 break;
                case "Depositar":
                    Depositar();
                    break;
                case "Sacar":
                    Sacar();
                    break;
                case "Deletar Objetivo":
                    DeletarObjetivo();
                break;
                default:
                    MessageBox.Show("Escolha uma opção válida");
                    break;
            }
            comboMenuOpcoes.SelectedIndex = 0;
            Show();

        }
        public void CadastrarObjetivo()
        {
            cadastrarObjetivo = new CadastrarObjetivoFinanceiro();
            cadastrarObjetivo.ShowDialog();
            ref var recebeListaPreenchida = ref cadastrarObjetivo.RetornarLista();
            listObjetivo.AddRange(recebeListaPreenchida);
        }
        public void ConsultarObjetivos()
        {
            var consultaObjetivo = new ConsultarObjetivo();
            consultaObjetivo.RecebeLista(ref listObjetivo);
            consultaObjetivo.ShowDialog();
        }
        public void Depositar()
        {
            var depositar = new Depositar();
            depositar.RecebeLista(ref listObjetivo);
            depositar.ShowDialog();
        }
        public void Sacar()
        {
            var sacar = new Sacar();
            sacar.RecebeLista(ref listObjetivo);
            sacar.ShowDialog();
        }
        public void DeletarObjetivo()
        {

            DeletarObjetivo deletarObjetivo;
            bool deletarDoFor;
            bool tentarNovamente;
            bool entrouNoFor;

            do {
                tentarNovamente = false;
                deletarDoFor = false;
                entrouNoFor = false;
                deletarObjetivo = new DeletarObjetivo();
                var ID = deletarObjetivo.ID;
  

                for (int i = 0; i < listObjetivo.Count(); i++)
                {
                    if (listObjetivo[i].IdObjetivo.Equals(ID))
                    {
                        listObjetivo.RemoveAt(i);
                        var dialog = MessageBox.Show("DELETADO COM SUCESSO, CONTINUAR DELETANDO ?", "SUCESSO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes.Equals(dialog)) { deletarDoFor = true;}
                        entrouNoFor = true;
                        break;
                    }
                }

                if(entrouNoFor is false)
                {
                    var dialog2 = MessageBox.Show("ID NAO ENCONTRADO OU INEXISTENTE, CONTINUAR DELETANDO ?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    tentarNovamente = DialogResult.Yes == dialog2 ? true : false;
                }
        

            } while (deletarDoFor || tentarNovamente is true );

          

        }
    }
}
