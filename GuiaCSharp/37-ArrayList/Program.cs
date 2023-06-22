using System;
using System.Collections;
using System.Data;

namespace _37_ArrayList
{
    public class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Joao");
            arrayList.Add("Jose");
            arrayList.Add("Maria");
            arrayList.Add("Severina");
            arrayList.Add(20);
            arrayList.Add(new DataSet());

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
            
            Console.WriteLine($"Array count: {arrayList.Count}");
            Console.WriteLine($"Array capacity: {arrayList.Capacity}");
            
            Console.ReadLine();
        }
    }
}