using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulatedAnnealingAlgorithm.Model;
using System.Runtime.ExceptionServices;
using System.Reflection;
using System.IO;

namespace SimulatedAnnealingAlgorithm.Test
{
    [TestClass]
    public class AlgoTest
    {
        [TestMethod]
        public void checkHamiltonCycleTest()
        {
            StreamReader reader = new StreamReader("Документы/test.txt");
            String s = reader.ReadToEnd();
            AdjacencyMatrixFromFile matrix = new AdjacencyMatrixFromFile(s);

            List<Int32> cycle1 = new List<Int32>() { 0, 1, 2, 3, 4, 5 };
            List<Int32> cycle2 = new List<Int32>() { 0, 1, 2, 3, 4, 5 };
            List<Int32> cycle3 = new List<Int32>() { 0, 1, 2, 3, 4, 5 };
            List<Int32> cycle4 = new List<Int32>() { 0, 1, 2, 3, 4, 5 };
            List<Int32> cycle5 = new List<Int32>() { 0, 1, 2, 3, 4, 5 };

            Assert.IsFalse(Algo.checkHamiltonCycle(cycle1, matrix));
        }
    }
}
