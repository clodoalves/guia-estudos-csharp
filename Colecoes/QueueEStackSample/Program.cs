using System;

namespace QueueEStackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarFifoSample();
            Console.ReadLine();
        }

        public static void ExecutarFifoSample()
        {
            FifoSample fifoSample = new FifoSample();

            fifoSample.PreencherFila();

            Console.WriteLine("Lista de clientes:");
            Console.WriteLine(fifoSample);

            Console.WriteLine($"Atendendo próximo cliente: {fifoSample.ObterProximoCliente()}");
            fifoSample.AtenderProximoCliente();

            Console.WriteLine("Lista de clientes atualizada:");
            Console.WriteLine(fifoSample);

            Console.WriteLine($"Atendendo próximo cliente: {fifoSample.ObterProximoCliente()}");
            fifoSample.AtenderProximoCliente();

            Console.WriteLine("Lista de clientes atualizada:");
            Console.WriteLine(fifoSample);
        } 

        public static void ExecutarLifoSample()
        {
            LifoSample lifoSample = new LifoSample();

            lifoSample.PreencherPilha();

            Console.WriteLine("Pilha de pratos:");
            Console.WriteLine(lifoSample);

            Console.WriteLine($"Retirando próximo prato: {lifoSample.ObterProximoPrato()}");
            lifoSample.RetirarProximoPrato();

            Console.WriteLine("Pilha de pratos atualizada:");
            Console.WriteLine(lifoSample);
            
            Console.WriteLine($"Retirando próximo prato: {lifoSample.ObterProximoPrato()}");
            lifoSample.RetirarProximoPrato();

            Console.WriteLine("Pilha de pratos atualizada:");
            Console.WriteLine(lifoSample);                      
        }
    }
}