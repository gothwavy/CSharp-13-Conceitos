using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo
{
    internal class Gato : Animal
    {

        public override void Som()
        {
            Console.WriteLine("Miau-miau!");
        }

    }
}
