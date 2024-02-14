using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class lion : Pet
    {
        public lion(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " Roars at you.");
        }
        public void HideInshell()
        {
            Console.WriteLine(Name + " Hides in his Cave.");
        }
    }
}
