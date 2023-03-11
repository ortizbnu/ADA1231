using System;

class Program
{
    static int BuscaBinaria(int[] array, int buscaValor)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;
            Console.WriteLine(String.Format("Meio da lista Posicao: {0}",meio.ToString()));

            if (array[meio] == buscaValor)
            {
                return meio;
            }
            else if (array[meio] < buscaValor)
            {
                esquerda = meio + 1;
                Console.WriteLine(String.Format("novo valor maximo a esquerda {0}", meio.ToString()));

            }
            else
            {
                direita = meio - 1;
                Console.WriteLine(String.Format("novo valor maximo a direita {0}", meio.ToString()));

            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        //int[] arr = { 2, 4, 6, 8, 10 }; 
        int[] array = { 2, 4, 6, 8, 10, 20, 30, 80, 88 };

        int value = 6;
        int index = BuscaBinaria(array, value);
        if (index == -1)
        {
            Console.WriteLine("Valor não encontrado");
        }
        else
        {
            Console.WriteLine("Valor encontrado na posição " + index);
        }
    }
}
