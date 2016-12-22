using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication3;

class program
{
    static void Main()
    {
        ElementContainer<short> myShortContainer = new ElementContainer<short>();
        myShortContainer.Add(3);
        myShortContainer.Add(5);
        myShortContainer.Add(1);
        foreach (short s in myShortContainer)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}