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
            var listOne = new List<int>();
            var listTwo = new List<int>();
            int final = 0;
            string path = "input.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                List<string> line = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).ToList();
                listOne.Add(int.Parse(line[0]));
                listTwo.Add(int.Parse(line[1]));

            }
            final += shortestPath(listOne, listTwo);
            System.Console.WriteLine(final);
        }

        public static int shortestPath(List<int> listOne, List<int> listTwo)
        {
            int value = 0;
            listOne.Sort();
            listTwo.Sort();

            for(int i =0; i < listOne.Count; i++)
            {
               // System.Console.WriteLine(listOne[i]);
                value += Math.Abs(listOne[i] - listTwo[i]);
            }
            return value;
        }
    
    }

}