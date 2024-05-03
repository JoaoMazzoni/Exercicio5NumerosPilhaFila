using Exercicio5NumerosPilhaFila;
using System.Drawing;

public class Program
{

    static Numero sortearNumeroPilha()
    {
        int numero = 0;
        for (int i = 0; i < 10; i++)
        {
            numero = new Random().Next(1, 100);
            Console.Write(numero + " ");

        }
        return new Numero(numero);
    }


    static Numero sortearNumeroFila()
    {
        int numero = 0;
        for (int i = 0; i < 10; i++)
        {
            numero = new Random().Next(1, 100);
            Console.Write(numero + " ");
        }
        return new Numero(numero);
    }



    internal static void Main(string[] args)
    {

        Pilha pilha = new Pilha();
        Fila fila = new Fila();
        Console.WriteLine("\nValores sorteados para a pilha");

        pilha.push(sortearNumeroPilha());


        pilha.imprimirPilha();
        Console.ReadLine();

        Console.WriteLine("\nValores sorteados para a fila");

        fila.push(sortearNumeroFila());


        fila.imprimirFila();
        Console.ReadLine();
    }
}