﻿using System;

class Bai8
{
    public static void Chay()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBảng cửu chương {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}
