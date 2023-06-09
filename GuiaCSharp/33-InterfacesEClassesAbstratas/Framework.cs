using System;

namespace _33_InterfacesEClassesAbstratas
{
    interface IDBConection
    {
        void OpenConnection();

        void CloseConnection();
    }
    
    public abstract class DBConnection : IDBConection
    {
        public string ConnectionString { get; set; }

        public virtual void OpenConnection()
        {
            Console.WriteLine($"Abrindo conexao para: {ConnectionString}");
        }
        public virtual void CloseConnection()
        {
            Console.WriteLine($"Fechando conexao");
        }
    }

    public class SQLServer : DBConnection
    {
        public override void OpenConnection()
        {
            base.OpenConnection();
            Console.WriteLine("Configuracao especifica - SQLServer");
        }
        public override void CloseConnection()
        {
            base.CloseConnection();
            Console.WriteLine("Configuracao especifica - SQLServer");
        }
    }

    public class Oracle : DBConnection
    {
        public override void OpenConnection()
        {
            base.OpenConnection();
            Console.WriteLine("Configuracao especifica - Oracle");
        }
        public override void CloseConnection()
        {
            base.CloseConnection();
            Console.WriteLine("Configuracao especifica - Oracle");
        }
    }
}