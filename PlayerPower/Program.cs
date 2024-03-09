using System;

namespace PlayerPower
{
    class Program
    {
        static void Main(string[] args)
        {

            

            UserPowers userPower = 0;

            int[] playerArray;
            
            

            Console.Write("Pick numb of players>> ");
            int n = int.Parse(Console.ReadLine());


            playerArray = new int[n];



            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please state your powers, player {i+1}:");
                Console.WriteLine("1 => Flight");
                Console.WriteLine("2 => X-ray Vision");
                Console.WriteLine("3 => Super Strength");
                Console.WriteLine("0 => Nothing");
                Console.WriteLine("anything above 3 => Nothing");
                Console.Write(">>");

                //use input sting as array to get the chars
                string tmpChars = Console.ReadLine();
                //this doesnt get the chars it gets the binary code of it


                //verify the chars
                foreach(char tmpc in tmpChars)
                {
                    //Console.WriteLine($"this is the char {tmpc}");
                    switch(tmpc)
                    {
                        case '1':
                            userPower += (int) UserPowers.Fly;
                            break;
                        case '2':
                            userPower += (int) UserPowers.XRayVision;
                            break;
                        case '3':
                            userPower += (int) UserPowers.SuperStrength;
                            break;
                        default:
                            break;
                        
                    }
                    playerArray[i] += (int) userPower;

                    userPower = 0;

                }

                /*playerArray[i] += (int) userPower;

                userPower = 0;*/

                
            }
            

            for(int j = 0; j < n; j++)
            {
                Console.WriteLine($"Player {j + 1}: {playerArray[j]}");
                userPower += playerArray[j];
                //userPower += playerArray[j];
                Console.WriteLine(userPower);
                Console.WriteLine("");

                UserPowers retpowers = (UserPowers) playerArray[j];
                Console.WriteLine($"this is ret power {retpowers}");
                //if(playerArray[j])
              



            }




        }
    }
}
