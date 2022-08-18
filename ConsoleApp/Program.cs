using BracketAlgorithm;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brackets = "(){}[][][]()";
            ValidationBracket validationBracket = new ValidationBracket();

            var result = validationBracket.ValidationBraces(brackets);

            Console.WriteLine($"В \"{brackets}\" имеются все закрывающиеся скобки: {result}");
        }
    }
}
