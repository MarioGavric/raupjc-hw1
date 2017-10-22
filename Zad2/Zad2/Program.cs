using System;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {

        public static void ListExample(IGenericList<int> listOf)
        {
            listOf.Add(1); // [1]
            listOf.Add(2); // [1 ,2]
            listOf.Add(3); // [1 ,2 ,3]
            listOf.Add(4); // [1 ,2 ,3 ,4]
            listOf.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOf.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOf.Remove(5); //[2 ,3 ,4]
            Console.WriteLine(listOf.Count); // 3
            Console.WriteLine(listOf.Remove(100)); // false
            Console.WriteLine(listOf.RemoveAt(5)); // false
            listOf.Clear(); // []
            Console.WriteLine(listOf.Count); // 0
        }
        static void Main(string[] args)
        {
            IGenericList<int> list = new GenericList<int>();

            ListExample(list);
            Console.ReadLine();
        }
    }
}
