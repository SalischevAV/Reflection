using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributesHomeWork
{
    public class PropertyPrinter
    {
        

        public static void Printer (object sameObj)
        {
            Console.WriteLine("Object type of: " + sameObj.GetType().Name);
            Type objType = sameObj.GetType();
            PropertyInfo[] objPropertyes = objType.GetProperties();
            try
            {
                for (int i = 0; i < objPropertyes.Length; i++)
                {
                    Console.Write(objPropertyes[i].Name + " ");
                    object[] customAttributes = objPropertyes[i].GetCustomAttributes(false);
                    if (customAttributes.Length != 0)
                    {
                        foreach (ColorInfoAttribute item in customAttributes)
                        {
                            
                            Console.ForegroundColor = item.DisplayColor;
                            Console.WriteLine(objPropertyes[i].GetValue(sameObj));
                            Console.ResetColor();
                        }

                    }
                    else
                    {
                        
                        Console.WriteLine(objPropertyes[i].GetValue(sameObj));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
