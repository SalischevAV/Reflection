using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesHomeWork.Classes
{
    public class Animals
    {
        [ColorInfo(ConsoleColor.Blue)]
        public int Legs { get; set; }

        public string Name { set; get; }


        [ColorInfo(ConsoleColor.Yellow)]
        public bool IsMammals { set; get; }

    }
}
