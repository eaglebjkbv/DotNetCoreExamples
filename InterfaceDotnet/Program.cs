﻿using System;
using InterfaceDotnet.Hayvan;

namespace InterfaceDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi=new Kedi();
            System.Console.WriteLine($"Kedi Sesi {kedi.sesver()}");
        }
    }
}
