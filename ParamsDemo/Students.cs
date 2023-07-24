using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{

        public class Student
    {
       public string name;
        public int id;

        public void Print(params String[] name)
        {
            Console.WriteLine("count" + name.Length);
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
        public void Print1(params int[] id) 
        {
            foreach(var item in id)
            {
                Console.WriteLine(item);
            }
        }
    }
    }

