using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9class_and_object
{
    public class Time : Attribute
    {
        public int hourse { get; set; }
        public int minuts { get; set; }
        [Time(hourse = 2, minuts = 23)]
        class vipol
        {

        }
        Time()
        {
            
        }

    }
    
}
