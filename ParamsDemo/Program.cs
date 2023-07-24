using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                Student s = new Student();
                s.Print("Anjali", "Vidyashree");
                s.Print("Akshata", "Snehal", "Pratik");
                s.Print("Akash", "Suraj", "Vishal", "Pankaj");
                s.Print1(1, 2);
                s.Print1(3, 4, 5);
                s.Print1(8, 9, 7, 0);
            }
        }
    }

