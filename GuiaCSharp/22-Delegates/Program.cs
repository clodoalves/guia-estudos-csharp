using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.Pagar += new PagarEvent(Pedido_Pagar);
            pedido.Fechar(500);
            Console.ReadLine();
        }

        private static void Pedido_Pagar(double valor)
        {
            Console.WriteLine($"Boleto pago no valor de {valor}");
        }
    }
}
