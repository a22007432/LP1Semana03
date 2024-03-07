using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] matrixA = new float [2,2];
            float[,] matrixRet = new float[2,2];
            //float

            matrixA[0,0] = float.Parse(args[0]);
            matrixA[0,1] = float.Parse(args[1]);
            matrixA[1,0] = float.Parse(args[2]);
            matrixA[1,1] = float.Parse(args[3]);

            float[] matrixB = new float [2];

            matrixB[0] = float.Parse(args[4]);
            matrixB[1] = float.Parse(args[5]);

            for(int i = 0; i< 2;i ++)
            {
                for(int j = 0; j<2; j++)
                {
                    matrixRet[i,j] = matrixA[i,j] * matrixB[j];
                    //Console.WriteLine($"this is matrix ret[{i},{j}]{matrixRet[i,j]}");
                }
            }

            Console.WriteLine(matrixRet[0,0] + matrixRet [0,1]);
            Console.WriteLine(matrixRet[1,0] + matrixRet [1,1]);


            

            

        }
    }
}
