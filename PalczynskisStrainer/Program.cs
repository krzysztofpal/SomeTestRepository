using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace PalczynskisStrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = EuklidesStainer(997);
            for (int i = 0; i < firstNumbers.Count; i++)
                Console.Write(firstNumbers[i] + "\t");
            Console.WriteLine(1);
            StreamWriter writer = new StreamWriter("C:\\Strainer.txt");
            //for (int i = 0; i < firstNumbers.Count - 1; i++)
            //{
            //    string line = /*firstNumbers[i + 1] + "   " + firstNumbers[i] + "  "+*/ (firstNumbers[i + 1] * firstNumbers[i + 1] + firstNumbers[i] * firstNumbers[i]).ToString();
            //    //Console.WriteLine(line);
            //    writer.WriteLine(line);
            //}
            //writer.Close();
            Console.WriteLine();
            for (int i = 1; i < 20; i++)
                Console.WriteLine((firstNumbers[i] * firstNumbers[i + 1] + 2) + "   " + isFirst(firstNumbers, (firstNumbers[i] * firstNumbers[i + 1] + 2)));
            Console.ReadLine();
        }

        public static List<int>EuklidesStainer(int lastProbe)
        {
            bool[] array = new bool[lastProbe + 2];
            for (int i = 2; i < array.Length; i++)
                array[i] = true;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i])
                {
                    for (int j = 2 * i; j < array.Length; j += i)
                        array[j] = false;
                }
            }
            List<int> firstNumbers = new List<int>();
            for (int i = 0; i < array.Length; i++)
                if (array[i])
                    firstNumbers.Add(i);
            return firstNumbers;
        }

        public static bool isFirst(List<int> firstNumbers, int number)
        {
            return firstNumbers.Exists(x => x == number);
        }
    }
}
