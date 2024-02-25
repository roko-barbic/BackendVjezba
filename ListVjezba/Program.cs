using System;
using System.Collections;

namespace ListVjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(0, 101);
                arrayList.Add(randomNumber);
            }

            foreach (var number in arrayList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Stack stackUp = new Stack();
            Stack stackDown = new Stack();
            int temp;
            int n = 20;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if ((int)arrayList[j] > (int)arrayList[j + 1])
                    {
                        temp = (int)arrayList[j];
                        arrayList[j] = arrayList[j + 1];
                        arrayList[j + 1] = temp;
                    }
                }
                stackUp.Push(arrayList[n - i - 1]);
            }
            Console.WriteLine("Sorted list: ");
            while(stackUp.Count != 0) { 
                Console.Write(stackUp.Peek() + " ");
                stackDown.Push(stackUp.Pop());
            }
            Console.WriteLine();
            foreach (var number in stackDown)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
