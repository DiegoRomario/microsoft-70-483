using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_UsingIList_TAndICollection_T
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string> { "A", "B", "C", "D", "E" };
            for (int x = 0; x < listOfStrings.Count; x++) { 
                Console.WriteLine(listOfStrings[x]); // Displays: ABCDE
            }
            Console.WriteLine("------------------------");
            foreach (var item in listOfStrings)
            {
                Console.WriteLine(item); // Displays: ABCDE
            }
            Console.WriteLine("------------------------");
            listOfStrings.Remove("A");
            Console.WriteLine(listOfStrings[0]); // Displays: B
            listOfStrings.Add("F");
            Console.WriteLine(listOfStrings.Count); // Displays: 5
            bool hasC = listOfStrings.Contains("C");
            Console.WriteLine(hasC); // Displays: true
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        T this[int index] { get; set; }
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
    }
    public interface ICollection<T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
        bool IsReadOnly { get; }
        void Add(T item);
        void Clear();
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool Remove(T item);
    }
}
