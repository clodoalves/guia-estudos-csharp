using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_PropagandoExceptionsComThrow
{
    class Program
    {
        public static void ChamarRepositorio(string tarefa) 
        {
            DateTime data = Convert.ToDateTime(tarefa);
        }
        
        public static void ChamarServico(string tarefa) 
        {
            try
            {
                ChamarRepositorio(tarefa);
            }
            catch (FormatException e)
            {
               throw new Exception("Serviço detectou erro: "+e.Message);
            }
        }

        public static void ChamarRegraNegocio(string tarefa) 
        {
            try
            {
                ChamarServico(tarefa);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro interno");
            }
        }

        static void Main(string[] args)
        {
            string tarefa = "99/99/9999";
            Console.WriteLine("Salvar data...");
            ChamarRegraNegocio(tarefa);

            Console.ReadLine();
        }
    }
}
