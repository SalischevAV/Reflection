using AttributesHomeWork.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributesHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Cars bmw = new Cars { Cilindres = 12, Volume = 5.4f, Brand = "BMW", Color = "Red" };
                Animals cat = new Animals { Name = "Tiger", IsMammals = true, Legs = 4 };
               
                ArrayList o = new ArrayList();
                o.Add(bmw);
                o.Add(cat);
                foreach (object ob in o)
                {
                    PropertyPrinter.Printer(ob);
                    Console.WriteLine("---------------------------");
                }





                Console.ReadKey();
            }


        }
    }
}

//Type t = bmw.GetType();
//IEnumerable<Attribute> at = t.GetCustomAttributes();
////foreach (var item in at)
////{
////    Console.WriteLine(item);
////}

//PropertyInfo[] pi = t.GetProperties();
//foreach (PropertyInfo i in pi)
//{

//    Console.WriteLine(i);
//}
//Console.WriteLine("----------------------------------------");
//try
//{
//    for (int i = 0; i < pi.Length; i++)
//    {
//        object[] customAttributes = pi[i].GetCustomAttributes(false);
//        if (customAttributes.Length != 0)
//        {
//            foreach (ColorInfoAttribute item in customAttributes)
//            {

//                Console.ForegroundColor = item.DisplayColor;
//                Console.WriteLine(pi[i].GetValue(bmw));
//            }

//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}