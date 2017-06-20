﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateStrings
{
   public static class ConcatenateStrings
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                var currentText = Console.ReadLine();
                sb.Append($" {currentText}");
            }
            Console.WriteLine(sb.ToString().TrimStart());
        }
    }
}
