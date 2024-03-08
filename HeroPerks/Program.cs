using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myperks = 0;

            char charA = 'a';
            char charW = 'w';
            char charS = 's';
            char charD = 'd';

            bool isOkay = false;
            bool autoHeal = false;
           


            string argString = args[0];

            char[] charArray1 = new char[argString.Length];
            int[] oddEven = new int[4];

            //if(argString.Length == 0)
            //{
            //    Console.WriteLine("No perk at all!");
            //}


            for(int i = 0; i< argString.Length; i++ )
            {
                charArray1[i] = argString[i];
            }

            foreach(char c in charArray1)
            {
                if(c == charA || c == charW || c == charS || c == charD)
                {
                    isOkay = true;

                    switch(c)
                    {
                        case 'a':
                            oddEven[0] += 1;
                            break;
                        case 'w':
                            oddEven[1] += 1;
                            break;
                        case 's':
                            oddEven[2] += 1;
                            break;
                        case 'd':
                            oddEven[3] +=1;
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    isOkay = false;
                }

            }

            int oddSum = oddEven[0] + oddEven[1] + oddEven[2] + oddEven[3];


            if(isOkay == false)
            {
                Console.WriteLine("Unknown Perk!");

                return;
            }
            else
            {
                //Console.WriteLine("good to go!");
                /*for(int j = 0; j<4; j++)
                {
                    Console.WriteLine(oddEven[j]);
                }*/
                
                if(oddEven[0] % 2 != 0)
                {
                    myperks += (int) Perks.WaterBreathing;
                }

                if(oddEven[1] % 2 != 0)
                {
                    myperks += (int)Perks.Stealth;
                }

                if(oddEven[2] % 2 != 0)
                {
                    myperks += (int) Perks.AutoHeal;
                }
                else
                {
                    autoHeal = false;
                }

                if(oddEven[3] % 2 != 0)
                {
                    myperks += (int) Perks.DoubleJump;
                }

                if(myperks != 0)
                {
                    Console.WriteLine(myperks);
                }

                if(oddEven[1] % 2 != 0 && oddEven[3] % 2 != 0)
                {
                    Console.WriteLine("Silent Jumper!");
                }

                if((int) myperks % 2 == 0)
                {
                    Console.WriteLine("No perks at all!");
                }

                if(autoHeal == false)
                {
                    Console.WriteLine("Not gonna make it!");
                }

                


                
                
                

            }




        }
    }
}
