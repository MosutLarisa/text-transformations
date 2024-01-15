﻿using TextTransformations.Library;

namespace TextTransformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is the original text";

            string result = TransformationEngine.ApplyAll(text);

            Console.WriteLine("Result=" + result);
        }
    }
}