using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            string newStudent="";
            string id="";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter student info (enter to quit):");
          
            do
            {              
                Console.Write("ID: ");
                id = Console.ReadLine();
                sb.Append("\n"+id + " ");

                if (id != "")
                {
                  int newID = int.Parse(id);
                    // Get the student's grade
                    Console.Write("Name: ");
                    newStudent = Console.ReadLine();
                    sb.Append(newStudent + " ");
                    students.Add(newID, newStudent);
                }

                if (id == ""){
                  break;
                }                   
            }
            while (newStudent != "");
        

          
            // Print roster
            Console.WriteLine("\nClass roster:");           
            
            Console.WriteLine(sb.ToString());
            

           
        }
    }
}