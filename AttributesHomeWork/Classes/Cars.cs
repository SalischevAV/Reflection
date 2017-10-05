using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesHomeWork
{
  
    public class Cars
    {
        
        
        public int Cilindres { get; set; }
        public float Volume { get; set; }

        [ColorInfo(ConsoleColor.Green)]
        public string Brand { set; get; }


        [ColorInfo(ConsoleColor.Red)]
        public string Color { set; get; }

    }
}
