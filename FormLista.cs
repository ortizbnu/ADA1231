using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Listas
{
    public partial class FormLista : Form
    {
        int tamanhoMaximoLista;
        int tamanhoAtribuidoLista;

        String[] lista;
        public FormLista()
        {
            InitializeComponent();
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            tamanhoAtribuidoLista = 0;
            tamanhoMaximoLista = (int) TamanhoListaNumericUpDown.Value;
            IniciarButton.Enabled = false;
            TamanhoListaNumericUpDown.Enabled = false;
            IniciarNovaFila(tamanhoMaximoLista);
        }

        private void IniciarNovaFila(int tamanhoMaximoLista)
        {
            lista = new String[tamanhoMaximoLista];
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            InserirValorFila(ValorFilaTextBox.Text);
        }

        private void InserirValorFila(string valor)
        {

            if (tamanhoAtribuidoLista == tamanhoMaximoLista)
            {
                MessageBox.Show("Tamanho da lista maximo atingido!");
                return;
                
            }
            lista[tamanhoAtribuidoLista] = valor;
            tamanhoAtribuidoLista++;
            AtualizaLista();
            
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                RemoverPosicao(listBox1.SelectedIndex);
            }
            else {
                MessageBox.Show("Lista Vazia!");
                return;
            }
        }

        private void RemoverPosicao(int selectedIndex)
        {
            if (lista[selectedIndex] != string.Empty)
            {
                lista[selectedIndex] = "";
                tamanhoAtribuidoLista--;
            }
            else 
            {
                MessageBox.Show("Posição Vazia!");
                return;
            }
            ReorganizarFila(selectedIndex);
        }

        private void AtualizaLista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
            listBox1.Refresh();
        }

        private void ReorganizarFila(int posicaoExcluida)
        {
            for (int varreProximosCampos = posicaoExcluida + 1; varreProximosCampos < tamanhoMaximoLista; varreProximosCampos++)
            {
                if (!String.IsNullOrEmpty(lista[varreProximosCampos]))
                {
                    lista[varreProximosCampos - 1] = lista[varreProximosCampos];
                    lista[varreProximosCampos] = "";
                }
                else { 
                    break; 
                }
            }
            AtualizaLista();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            
            if (lista != null)
            {
               
                for (int x = 0; x < tamanhoMaximoLista; x++)
                {
                    if (lista[x] == BuscarTextBox.Text)
                    {
                        MessageBox.Show(String.Format("Valor encontrado na Posição: {0}!", x.ToString()));
                        
                        return;
                    }
                
                }
                MessageBox.Show("Valor não encontrado");

            }
        }
    }
}