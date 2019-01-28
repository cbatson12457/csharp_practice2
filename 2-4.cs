using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            string newStudent="";
            string id="";

            Console.WriteLine("Enter student info (enter to quit):");
          
            do
            {              
                Console.Write("ID: ");
                id = Console.ReadLine();                

                if (id != "")
                {
                  int newID = int.Parse(id);
                    // Get the student's grade
                    Console.Write("Name: ");
                    newStudent = Console.ReadLine();
                    students.Add(newID, newStudent);
                }

                if (id == ""){
                  break;
                }                   
            }
            while (newStudent != "");
        

          
            // Print roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }

           
        }
    }
}