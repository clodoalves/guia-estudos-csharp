using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesLambda
{
    public delegate void PagarEvent(double valor);
    public class Pedido 
    {
        public event PagarEvent Pagar;

        public void Fechar(double valor) 
        {
            this.Pagar(valor);
        }
    }

    public class PedidoRefatorado
    {
        public double valor;
        public void Fechar(PagarEvent pagar) 
        {
            pagar(valor);
        }
    }
}
