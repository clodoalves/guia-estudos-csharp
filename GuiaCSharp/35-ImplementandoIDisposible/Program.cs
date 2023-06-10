using System;

namespace _35_ImplementandoIDisposible
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (Conexao conexao = new Conexao())
            {
                conexao.Abrir();
                conexao.Fechar();
            }

            #region Usando try-finally
            // Conexao conexao = new Conexao();
            //     
            // try
            // {
            //     conexao.Abrir();
            //     conexao.Fechar();
            // }
            // finally
            // {
            //     if (conexao != null)
            //         conexao.Dispose();
            // 
            #endregion

            Console.ReadLine();
        }
    }
}