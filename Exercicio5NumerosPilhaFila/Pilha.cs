
namespace Exercicio5NumerosPilhaFila
{
    internal class Pilha
    {
        Numero headNumero;

        public Pilha()
        {
            this.headNumero = null;
            Console.WriteLine("\nPilha criada!");
        }

        bool Empty()
        {
            return headNumero == null;
        }

        public void push (Numero auxNumero)
        {
            if (Empty() == true)
            {
                headNumero = auxNumero;
            }
            else
            {
                auxNumero.setAnterior(headNumero);
                headNumero = auxNumero;
            }
        
        }

        public void imprimirPilha()
        {
            Console.WriteLine("\nValores na pilha:");
            Numero numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getAnterior();
            }
        }
    
    
    
    
    
    }
}

