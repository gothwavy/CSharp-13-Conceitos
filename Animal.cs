﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo
{
    internal class Animal
    {

        public virtual void Som()
        {
            Console.WriteLine("Animal desconhecido...");
        }

    }
}
