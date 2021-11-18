using System;

namespace Delegacao
{
    public class Boleto 
    {
        public void Pagar(double valor) 
        {
            Console.WriteLine($"Boleto pago no valor de {valor}");
        }
    }

    public class Pedido
    {
        private Boleto _boleto = new Boleto();

        public void Fechar(double valor) 
        {
            //delegacao
            _boleto.Pagar(valor);
        }
    }
}
