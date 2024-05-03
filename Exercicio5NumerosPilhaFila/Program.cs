using System;

namespace Exercicio5NumerosPilhaFila
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            Fila fila = new Fila();
            Console.WriteLine("\nValores sorteados para a pilha");

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 21);
                Console.Write(numero + " ");
                pilha.push(new Numero(numero));
            }
            pilha.imprimirPilha();
            Console.ReadLine();

            Console.WriteLine("\nValores sorteados para a fila");
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 21);
                Console.Write(numero + " ");
                fila.push(new Numero(numero));
            }
            fila.imprimirFila();
            Console.ReadLine();

            imprimirNumeroComuns(pilha, fila);
        }

        static void imprimirNumeroComuns(Pilha pilha, Fila fila)
        {
            Console.WriteLine("\nNúmeros em comum entre a pilha e a fila:");

            int[] ocorrenciasPilha = new int[20];
            int[] ocorrenciasFila = new int[20];

            // Conta as ocorrências de cada número na pilha
            while (!pilha.Empty())
            {
                int numero = pilha.pop().getValor();
                ocorrenciasPilha[numero - 1]++;
            }

            // Conta as ocorrências de cada número na fila
            while (!fila.Empty())
            {
                int numero = fila.pop().getValor();
                ocorrenciasFila[numero - 1]++; //Subtrair -1 para alocar o número na posição correta
            }

            // Verifica e imprime os números comuns
            for (int i = 0; i < ocorrenciasPilha.Length; i++)
            {
                int ocorrenciasComuns = 0;

                if (ocorrenciasPilha[i] < ocorrenciasFila[i])
                {
                    ocorrenciasComuns = ocorrenciasPilha[i];
                }
                else
                {
                    ocorrenciasComuns = ocorrenciasFila[i];
                }

                for (int j = 0; j < ocorrenciasComuns; j++)
                {
                    Console.Write((i + 1) + " ");
                }
            }

        }
    }
}
