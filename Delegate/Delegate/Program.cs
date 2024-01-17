﻿using Delegate;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
Console.Clear();
Console.WriteLine();
Car car = new();


WriteِDel write1 = Console.WriteLine;
WriteِDel write2 = writeTest;

RunTest(writeTest, 0, 100);




void RunTest(WriteِDel write, int from, int count)
{
    for (var i = 0; i <= 100; i++)
    {
        bool fizzBuzz = i % 3 == 0 && i % 5 == 0;
        bool fizz = i % 3 == 0;
        bool buzz = i % 5 == 0;
        if (fizzBuzz)
        {
            write("FizzBuzz");
        }
        else if (fizz)
        {
            write("Fizz");
        }
        else if (buzz)
        {
            write("Buzz");
        }
        else
        {
            write(i.ToString());
        }
    }
}

void writeTest(string c)
{
    System.Console.WriteLine(c);
}

delegate void WriteِDel(string a);































































































































































































































































































































































































































































































































