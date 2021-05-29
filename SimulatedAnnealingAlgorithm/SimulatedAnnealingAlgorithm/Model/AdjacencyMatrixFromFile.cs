using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealingAlgorithm.Model
{
    public class AdjacencyMatrixFromFile
    {
        private int[,] matrix;

        private int sizeOfMatrix;

        private GraphVertices repo;

        public GraphVertices getRepo()
        {
            return repo;
        }

        public int[,] getMatrix()
        {
            return matrix;
        }

        public int getSizeOfMatrix()
        {
            return sizeOfMatrix;
        }

        public AdjacencyMatrixFromFile(String s)
        {
            this.repo = new GraphVertices(s);
            this.fillMatrix();
        }

        public void fillMatrix()
        {
            this.sizeOfMatrix = this.repo.getCities().Count;
            this.matrix = new int[this.sizeOfMatrix, this.sizeOfMatrix];

            for (int i = 0; i < this.sizeOfMatrix; i++)
            {
                for (int j = 0; j < this.sizeOfMatrix; j++)
                {
                    if (i == j) this.matrix[i, j] = 0;
                    else
                    {
                        this.matrix[i, j] = this.repo.getPriceOfWay
                                (this.repo.getCities()[i],
                                        this.repo.getCities()[j]);
                    }
                }
            }
        }

        public override string ToString()
        {
            String s = "   ";

            for (int i = 0; i < this.repo.getCities().Count; i++)
            {
                s += this.repo.getCities()[i] + " ";
            }

            s += "\n";

            for (int i = 0; i < this.sizeOfMatrix; i++)
            {
                s += this.repo.getCities()[i] + " ";
                for (int j = 0; j < this.sizeOfMatrix; j++)
                {
                    s = s + this.matrix[i, j].ToString() + " ";
                }
                s = s + '\n';
            }

            return s;
        }

        /*public void print()
        {
            for (int i = 0; i < this.sizeOfMatrix; i++)
            {
                for (int j = 0; j < this.sizeOfMatrix; j++)
                {
                    Console.Write(this.matrix[i][j] + " ");
                }
                Console.WriteLine('\n');
            }
        }*/
    }
}
