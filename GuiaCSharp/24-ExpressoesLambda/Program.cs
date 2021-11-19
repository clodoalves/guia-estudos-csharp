using System;

namespace ExpressoesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido();
            PedidoRefatorado pedido2 = new PedidoRefatorado() { valor = 1000 };

            //pedido.Pagar += (valor) => {Console.WriteLine($"Boleto pago no valor de {valor}");};
            pedido1.Pagar += (valor => Console.WriteLine($"Boleto pago no valor de {valor}"));
            pedido1.Fechar(600);

            pedido2.Fechar(valor => Console.WriteLine($"Boleto pago no valor de {valor}"));
            
            Console.ReadLine();
        }
    }
}