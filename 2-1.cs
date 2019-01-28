using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    public class TwoOne
    {
       
        public static int evenNumbers (List<int> number)
        {
            
            var Evens = new List<int>() { };
            int totalResult = 0;
            
            foreach(int num in number)
            {
                int newNum = num % 2;
                
                if(newNum == 0)
                {                    
                    Evens.Add(num);
                }
                
                if(newNum >= 1) {}
            }            
            
            foreach(int num in Evens)
            {                
                int newNum = num;                
                totalResult = newNum + totalResult;
            }
            
            return totalResult;
        }

        static void Main(string[] args)
        {
           
            var number = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            int totalEven = TwoOne.evenNumbers(number);            
            
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }            
            
            Console.WriteLine("\nCount of items in list: " + number.Count);
            
            Console.WriteLine("\nreturn: " + totalEven);
        }
    }
}
