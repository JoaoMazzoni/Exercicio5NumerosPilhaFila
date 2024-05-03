
namespace Exercicio5NumerosPilhaFila
{
    internal class Numero
    {
        int numero;
        Numero anterior;
        Numero proximo;

        public Numero(int numero)
        {
            this.numero = numero;
            anterior = null;
        }
    
        public void setAnterior(Numero numero)
        {
            anterior = numero;
        }
    
        public Numero getAnterior() 
        { 
            return anterior;
        }

        public int getValor()
        {
            return this.numero;
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


}
