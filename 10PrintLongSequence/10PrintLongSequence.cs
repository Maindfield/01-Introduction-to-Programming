﻿using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            for (int i = 2; i <= 1000; )
            {
                Console.WriteLine(i++);
                Console.WriteLine(-i++);
            }
        }
    }
}
