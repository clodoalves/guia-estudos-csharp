using System;
using System.Collections;
using System.Data;

namespace _37_ArrayList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Jose");
            arrayList.Add("João");
            arrayList.Add("Severino");
            arrayList.Add(10);
            arrayList.Add(new DataSet("Teste"));

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            
            var dataSetName = (arrayList[4] as DataSet).DataSetName;
            
            Console.WriteLine(dataSetName);
            
            Console.WriteLine($"ArrayList count: {arrayList.Count}");
            Console.WriteLine($"ArrayList capacity: {arrayList.Capacity}");

            Console.ReadLine();
        }
    }
}