using System;

namespace PlayerPower
{
    class Program
    {
        static void Main(string[] args)
        {

            

            
            //int[] playerArray;
            string ret = "";
            
            

            Console.Write("Pick numb of players>> ");
            int n = int.Parse(Console.ReadLine());


            UserPowers [] playerArray = new UserPowers[n];



            for(int i = 0; i < n; i++)
            {
                ret += $"Player{i+1}";
                Console.WriteLine($"State your powers, player {i+1}:");
                Console.WriteLine("1 => Flight");
                Console.WriteLine("2 => X-ray Vision");
                Console.WriteLine("3 => Super Strength");
                Console.WriteLine("0 => Nothing");
                Console.WriteLine("anything above 3 => Nothing");
                

                //verify the chars
                for (int j = 0; j <3; j++)
                {
                    Console.Write(">>");

                    string tmps = Console.ReadLine();


                    switch(tmps)
                    {
                        case "1":
                            playerArray[i] ^=  UserPowers.Fly;
                            break;
                        case "":
                            playerArray[i] ^=  UserPowers.XRayVision;
                            break;
                        case "3":
                            playerArray[i] ^= UserPowers.SuperStrength;
                            break;
                        default:
                            break;
                        
                    }

                    ret += $" {playerArray[i]}\n";

                    if ((playerArray[i] & UserPowers.Fly) == UserPowers.Fly
                    && ((playerArray[i] & UserPowers.SuperStrength)
                     == UserPowers.SuperStrength))
                {
                    ret +=" Flying radiation!\n";
                }
   
                }
                Console.WriteLine(ret);
                


            
                
            }
            
            





        }
    }
}
