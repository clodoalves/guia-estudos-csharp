using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            //pedido.Pagar += new PagarEvent(Pedido_Pagar);
            pedido.Pagar += delegate (double valor)
            {
                Console.WriteLine($"Boleto pago no valor de {valor}");
            };

            pedido.Fechar(500);
            Console.ReadLine();
        }
    }
}
