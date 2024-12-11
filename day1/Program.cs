// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.InteropServices;

namespace day1
{

    public class Solver
    {
        static void Main()
        {
            int final = 0;
            string path = "input.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                System.Console.WriteLine("compare " + s);
                List<string> line = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).ToList();
                int[] numOne = Array.ConvertAll(line[0].ToCharArray(), c => (int)Char.GetNumericValue(c));
                int[] numTwo = Array.ConvertAll(line[1].ToCharArray(), c => (int)Char.GetNumericValue(c));

                final += shortestPath(numOne, numTwo);
                System.Console.WriteLine(final);

            }
            Console.WriteLine("Total " + final);
        }

        public static int shortestPath(int[] listOne, int[] listTwo)
        {
            int value = 0;
            Array.Sort(listOne);
            Array.Sort(listTwo);

            for(int i =0; i < listOne.Length; i++)
            {
                System.Console.WriteLine(listOne[i]);
                value += Math.Abs(listOne[i] - listTwo[i]);
            }
            return value;
        }
    
    }

}