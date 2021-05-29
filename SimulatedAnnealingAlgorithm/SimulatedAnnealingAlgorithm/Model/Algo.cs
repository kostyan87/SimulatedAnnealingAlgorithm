using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealingAlgorithm.Model
{
    public class Algo
    {

        /*public static int simulatedAnnealingAlgo(AdjacencyMatrixFromFile matrix, double t)
        {
            Random rand = new Random();
            List<Int32> hamiltonCycle = new List<Int32>();

            for (int i = 0; i < matrix.getMatrix().GetLength(0); i++)
            {
                hamiltonCycle.Add(i);
            }
            hamiltonCycle = getHamiltonCycle(hamiltonCycle);

            for (int i = 0; i < 100; i++)
            {

                List<String> newHamiltonCycle = getHamiltonCycle(hamiltonCycle);



            }

            return -1;
        }

        static List<Int32> getHamiltonCycle(List<Int32> hamiltonCycle,
                                            AdjacencyMatrixFromFile matrix)
        {
            Random rand = new Random();

            int i = 1;
            int j = 1;

            while (i == j)
            {
                i = rand.Next(hamiltonCycle.Count);
                j = rand.Next(hamiltonCycle.Count);
            }

            if (checkHamiltonCycle(hamiltonCycle))
            {
                return hamiltonCycle;
            }

            getHamiltonCycle(hamiltonCycle);

            return null;
        }*/

        public static bool checkHamiltonCycle(List<Int32> hamiltonCycle,
                                       AdjacencyMatrixFromFile matrix)
        {
            for (int i = 0; i < hamiltonCycle.Count - 1; i++)
            {
                int from = hamiltonCycle[i];
                int to = hamiltonCycle[i+1];

                if (matrix.getMatrix()[from, to] == 0)
                {
                    return false;
                }
            }

            if (matrix.getMatrix()[hamiltonCycle[hamiltonCycle.Count - 1], hamiltonCycle[0]] == 0)
            {
                return false;
            }

            return true;
        }
    }
}
