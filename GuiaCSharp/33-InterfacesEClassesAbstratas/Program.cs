namespace _33_InterfacesEClassesAbstratas
{
    public class Program 
    {
        public static void Main()
        {
            IDBConection dbConection = new SQLServer()
            {
                ConnectionString = "SQLServer"
            };
            
            dbConection.OpenConnection();
            dbConection.CloseConnection();
        }
    }
}