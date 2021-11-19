using System;

namespace MetodosAnonimos
{
    public delegate void PagarEvent(double valor);

    public class Pedido
    {
        public event PagarEvent Pagar;
        public void Fechar(double valor) 
        {
            //delegação
            this.Pagar(valor);
        }
    }
}
