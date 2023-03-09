using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Listas
{
    //Documentação para implementacao de fila em C#
    //Representa uma coleção UEPS (último a entrar, primeiro a sair) de tamanho variável das instâncias do mesmo tipo especificado.
    //https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.stack-1?view=net-7.0
    public partial class FormPilha : Form

    {

        Stack<int> listaCarros = new Stack<int>();
        int ultimoVeiculo = 0;

        public FormPilha()
        {
            InitializeComponent();
        }


        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            Estacionar();
        }

        private void Estacionar()
        {
            ultimoVeiculo += 1;

            listaCarros.Push(ultimoVeiculo);

            MessageBox.Show(string.Concat("Carro Estacionado codigo: ", ultimoVeiculo.ToString()));

            SenhaGeradaTextBox.Text = ultimoVeiculo.ToString();

        }


        private void removerButton_Click(object sender, EventArgs e)
        {
            SairComUltimoVeiculo();
        }

        private void SairComUltimoVeiculo()
        {
            if (listaCarros.Count == 0)
            {
                MessageBox.Show("Estacionamento Vazio");
            }
            else { 
                var proximoNumeroDaFila = listaCarros.Pop();
                if (proximoNumeroDaFila != 0)
                { 
                    MessageBox.Show(string.Concat("Ultimo Carro que entrou e esta saindo numero: ", proximoNumeroDaFila.ToString()));
                    UltimaSenhaTextBox.Text = proximoNumeroDaFila.ToString();

                }
            }
        }

    }

    
}