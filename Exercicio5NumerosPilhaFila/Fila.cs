internal class Fila
{
    private Numero headNumero;
    private Numero tailNumero;

    public Fila()
    {
        this.headNumero = null;
        this.tailNumero = null;
        Console.WriteLine("\nFila Criada!");
    }
    public bool Empty()
    {
        return headNumero == null;
    }

    public void push(Numero auxNumero)
    {
        if (headNumero == null)
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

    public Numero pop()
    {
        if (Empty())
        {
            Console.WriteLine("Fila Vazia! Impossível Remover.");
            Console.Write("Pressione qualquer tecla para continuar:");
            Console.ReadKey();
            return null;
        }
        else
        {
            Numero numeroRemovido = headNumero;
            headNumero = headNumero.getNext();
            if (headNumero == null)
            {
                tailNumero = null;
            }
            return numeroRemovido;
        }
    }

    public void imprimirFila()
    {
        Console.WriteLine("\n\nValores na fila:");
        Numero numeroAtual = headNumero;
        while (numeroAtual != null)
        {
            Console.Write(numeroAtual.getValor() + " ");
            numeroAtual = numeroAtual.getNext();
        }
    }
}