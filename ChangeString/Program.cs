using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char replaceChar ='\u0058';

            Console.Write("String>> ");
            string inString = Console.ReadLine();
            
            char[] arrayString = new char[inString.Length];

            Console.Write("Char>> ");

            char inChar = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine(inChar);

            //char[] arrayString = new char[inString.Length];

            for(int i = 0; i < inString.Length; i++)
            {
                char tmpChar = inString [i];
                //Console.WriteLine(tmpChar);
                arrayString [i] = tmpChar;
            }

            for(int j = 0; j < inString.Length; j++)
            {
                if(arrayString[j] == inChar)
                {
                    arrayString[j]= replaceChar;
                }
            }

            Console.WriteLine(arrayString);



            



        }
    }
}
