using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Proyecto5n6
{
    class Program
    {
        public static void Main(string[] args)
        {
           
           ProductoDB Test = new ProductoDB();
           Console.WriteLine("Ingresa departamento:\n01 Chucheria\n02 Lacteos\n03 Carne");
           int opcion = int.Parse(Console.ReadLine());
           Console.Clear();
           Test.Serializa();

           

           GetDepartment(opcion,Test.GetList());
            
            
            
            
            Console.ReadKey();
        }

        static public void GetDepartment(int depto, List<Producto> list)
        {
            foreach(Producto pro in list)
            {
                if(pro.departamento == depto)
                {
                    Console.WriteLine(pro.ToString());
                }
            }
        }

        static public void GetLikes( List<Producto> list)
        {

            list.Sort();

            foreach(Producto pro in list)
            {
                //if()
                {
                    Console.WriteLine(pro.ToString());
                }
            }
        }
    }
}
