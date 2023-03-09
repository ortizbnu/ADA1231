using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Listas
{
    //Documentação para implementacao de fila em C#
    //Representa uma coleção primeiro a entrar, primeiro a sair de objetos.
    //https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.Queue-1?view=net-7.0
    public partial class FormFila : Form
    {
        Queue<int> listaSenhas = new Queue<int>();
        int ultimaSenha = 0;

        public FormFila()
        {
            InitializeComponent();


        }


        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            CriarSenha();
        }

        private void CriarSenha()
        {
            ultimaSenha += 1;

            listaSenhas.Enqueue(ultimaSenha);

            MessageBox.Show(string.Concat("Senha gerada numero: ", ultimaSenha.ToString()));

            SenhaGeradaTextBox.Text = ultimaSenha.ToString();

        }


        private void removerButton_Click(object sender, EventArgs e)
        {
            ChamarProximaSenha();
        }

        private void ChamarProximaSenha()
        {
            if (listaSenhas.Count == 0)
            {
                MessageBox.Show("Fila de Atendimento Vazia");
            }
            else { 
                var proximoNumeroDaFila = listaSenhas.Dequeue();
                if (proximoNumeroDaFila != 0)
                { 
                    MessageBox.Show(string.Concat("Proximo Atendimento senha numero: ", proximoNumeroDaFila.ToString()));
                    UltimaSenhaTextBox.Text = proximoNumeroDaFila.ToString();

                }
            }
        }

    }

    
}