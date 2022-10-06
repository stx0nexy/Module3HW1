using System;

namespace Module3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstList = new MyList<int>();
            var secondList = new MyList<int>();
            firstList.Add(12);
            firstList.Add(70);
            firstList.Add(32);
            firstList.Add(8);
            firstList.Add(38);
            firstList.Add(10);
            firstList.Add(57);
            firstList.Add(3);
            secondList.Add(15);
            secondList.Add(11);
            secondList.Add(17);
            secondList.Add(6);
            secondList.Add(9);
            secondList.Add(13);
            firstList.AddRange(secondList);
            Console.WriteLine("List after AddRange: ");
            foreach (var item in firstList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nResalt of Remove: " + firstList.Remove(17));
            firstList.RemoveAt(3);
            Console.WriteLine("List after all removes: ");
            foreach (var item in firstList)
            {
                Console.Write(item + " ");
            }

            firstList.Sort();
            Console.WriteLine("\nList after Sort: ");
            foreach (var item in firstList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
