using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity
{
    class AlgorithmAnalysis
    {
        public void optimalComplexity()
        {
            int alpha = 3, beta = 4, sum;
            sum = alpha + beta;
            Console.WriteLine("{0}", sum);
            Console.WriteLine("\n");

        }

        public void nComplexity()
        {
            int number = 5, repeat=5,loopIndex;
            for(loopIndex=1;loopIndex<=repeat;loopIndex++)
            {
                Console.Write(number);
            }
            Console.WriteLine("\n");

        }

        public void nSquareComplexity()
        {
            int row = 4, column = 4, number = 2, rowIndex, colIndex;
            for(rowIndex=0;rowIndex<row;rowIndex++)
            {
                for(colIndex=0;colIndex<column;colIndex++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }


        public static void Main(string[] args)
        {
            AlgorithmAnalysis algo = new AlgorithmAnalysis();
            algo.optimalComplexity();
            algo.nComplexity();
            algo.nSquareComplexity();
            Console.ReadKey();
        }
    }
}
