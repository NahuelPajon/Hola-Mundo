using System;

namespace SymDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>{1, 2, 3};
            List<int> list2 = new List<int>{3, 4, 5};
            Console.WriteLine(string.Join(", ", SymDiff(list1.ToArray(), list2.ToArray())));
            static List<int> SymDiff(int[] list1, int[] list2)
            {
                List<int> acumulador = new List<int>{};
                foreach (int elemento1 in list1)
                {
                    if (list2.Contains(elemento1) == false) 
                    {
                        acumulador.Add(elemento1);
                    }
                }
                foreach (int elemento2 in list2)
                {
                    if (list1.Contains(elemento2) == false) 
                    {
                        acumulador.Add(elemento2);
                    }
                }
                return acumulador;
            }
        }
    }
}