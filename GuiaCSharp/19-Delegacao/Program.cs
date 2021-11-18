using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            pedido.Fechar(2000);

            Console.ReadLine();
        }
    }
}
