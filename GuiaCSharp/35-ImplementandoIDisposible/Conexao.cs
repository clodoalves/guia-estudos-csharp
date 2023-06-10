using System;

namespace _35_ImplementandoIDisposible
{
    public class Conexao : IDisposable
    {
        public string Handle;
        
        public Conexao()
        {
            Handle = "Recurso em uso";
            Console.WriteLine("Recurso alocado");     
        }

        public void Abrir()
        {
            Console.WriteLine("Conexao aberta");
        }

        public void Fechar()
        {
            Console.WriteLine("Conexao fechada");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        /// <summary>
        /// Simula liberacao de recurso nao gerenciado pela CLR
        /// </summary>
        private void LiberarRecurso()
        {
            Handle = "";
            Console.WriteLine("Recurso liberado com sucesso");
        }

        public virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                //libera recursos gerenciados pela CLR
            }
            
            //libera recursos nao gerenciados pela CLR
            LiberarRecurso();
        }
    }
}