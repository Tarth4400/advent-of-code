// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace day1
{

    public class Solver
    {
        static void Main()
        {
            var listOne = new List<int>();
            var listTwo = new List<int>();
            string path = "input.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                List<string> line = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).ToList();
                listOne.Add(int.Parse(line[0]));
                listTwo.Add(int.Parse(line[1]));

            }
            System.Console.WriteLine(shortestPath(listOne, listTwo));
            System.Console.WriteLine(PartTwo(listOne, listTwo));
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
        public static int PartTwo(List<int> listOne, List<int> listTwo)
        {
            int value = 0;
            int final = 0;
            listOne.Sort();
            listTwo.Sort();

            for(int i=0; i < listOne.Count; i++)
            {
                value = 0;
                foreach(int number in listTwo)
                {
                    if(number == listOne[i])
                    {
                        value += number;
                    }
                }
                final += value;
            }
            return final;
        }
    
    }

}