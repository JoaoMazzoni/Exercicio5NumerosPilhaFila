namespace Exercicio5NumerosPilhaFila
{
    internal class Pilha
    {
        private Numero headNumero;

        public Pilha()
        {
            this.headNumero = null;
            Console.WriteLine("\n\nPilha criada!");
        }

        public void push(Numero auxNumero)
        {
            auxNumero.setAnterior(headNumero);
            headNumero = auxNumero;
        }

        public bool Empty()
        {
            return headNumero == null;
        }
        public Numero pop()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha Vazia! Impossível Remover.");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
                return null; 
            }
            else
            {
                Numero numeroRemovido = headNumero;
                headNumero = headNumero.getAnterior();
                return numeroRemovido;
            }
        }
        public void imprimirPilha()
        {
            Console.WriteLine("\n\nValores na pilha:");
            Numero numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getAnterior();
            }
        }
    }

}