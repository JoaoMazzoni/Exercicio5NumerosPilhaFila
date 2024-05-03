

namespace Exercicio5NumerosPilhaFila
{
    internal class Fila
    {
        Numero headNumero;
        Numero tailNumero;

        public Fila()
        {
            this.headNumero = null;
            this.tailNumero = null;
            Console.WriteLine("\nFila Criada!");
        }

        public void push(Numero auxNumero)
        {
            if (Empty())
            {
                headNumero = auxNumero;
                tailNumero = auxNumero;
            }
            else
            {
                tailNumero.setNext(auxNumero);
                tailNumero = auxNumero;
            }
            
        }
        bool Empty()
        {
            return headNumero == null;
        }
        public void imprimirFila()
        {
            Console.WriteLine("\nValores na fila:");
            Numero numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getNext();
            }
        }

    }
}
