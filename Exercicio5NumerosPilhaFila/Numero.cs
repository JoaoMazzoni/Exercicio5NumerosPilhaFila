internal class Numero
{
    private int numero;
    private Numero anterior;
    private Numero proximo;

    public Numero(int numero)
    {
        this.numero = numero;
        anterior = null;
    }

    public int getValor()
    {
        return this.numero;
    }

    public void setAnterior(Numero numero)
    {
        anterior = numero;
    }

    public Numero getAnterior()
    {
        return anterior;
    }

    public void setNext(Numero numero)
    {
        proximo = numero;
    }

    public Numero getNext()
    {
        return proximo;
    }
}