using System;

namespace StudentAttendance
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public bool HasSixOrMore()
        {
            if (Scores.Length >= 6)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}