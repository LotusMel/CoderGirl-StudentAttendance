using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentAttendance
{
    public static class Program
    {
        public static void Main()
        {
            string filePath = @"C:\Users\mjlan\source\repos\LotusMel\CoderGirl-StudentAverage\studentdata.txt";
            List<Student> studentList = new List<Student>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            Student student = new Student();
            
            foreach (string line in lines)
            {
                string[] entries = line.Split(' ');
                int[] scores = new int[entries.Length - 1];
                student.Name = entries[0];
                string name = student.Name;
                student.Scores = scores;
                for (int i = 1; i < entries.Length; i++)
                {
                    scores[i - 1] = int.Parse(entries[i]);
                }
                
            
                if (student.HasSixOrMore())
                {
                    Console.WriteLine(student.Name);
                }
            }
            
                Console.ReadLine();
        }

    }
}