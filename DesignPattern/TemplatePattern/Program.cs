﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeWithHook ch = new CoffeeWithHook();
            ch.PrepareRecipe();
            Console.ReadKey(true);
        }
    }
}
