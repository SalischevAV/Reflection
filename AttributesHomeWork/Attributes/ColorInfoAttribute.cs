using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesHomeWork
{
   [AttributeUsage(AttributeTargets.Property)]
    public class ColorInfoAttribute : Attribute
    {
        public ConsoleColor DisplayColor { set; get; }
        public ColorInfoAttribute()
        {

        }
        public ColorInfoAttribute(ConsoleColor displayColor)
        {
            DisplayColor = displayColor;    
        }

    }
}
