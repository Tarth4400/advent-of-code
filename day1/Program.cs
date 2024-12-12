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
            var(listOne, listTwo) = createSortedLists("input.txt");
            System.Console.WriteLine(shortestPath(listOne, listTwo));
            System.Console.WriteLine(PartTwo(listOne, listTwo));
        }

        public static (List<int>listOne, List<int> listTwo) createSortedLists(string path) 
        {
            //splits the input file into 2 sorted lists
            var listOne = new List<int>();
            var listTwo = new List<int>();
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                List<string> line = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).ToList();
                listOne.Add(int.Parse(line[0]));
                listTwo.Add(int.Parse(line[1]));
            }
            listOne.Sort();
            listTwo.Sort();
            return (listOne, listTwo);
        }


        public static int shortestPath(List<int> listOne, List<int> listTwo)
        {
            //compares each number in the lists and works out the distance between then eg: 1 and 3, distance 2
            var value = 0;
            for(int i =0; i < listOne.Count; i++)
            {
                value += Math.Abs(listOne[i] - listTwo[i]);
            }
            return value;
        }
        public static int PartTwo(List<int> listOne, List<int> listTwo)
        {
            //finds duplucates in the lists and adds them togehter 
            var value = 0;
            var final = 0;

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