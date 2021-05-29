using SimulatedAnnealingAlgorithm.View;
using SimulatedAnnealingAlgorithm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealingAlgorithm.Presenter
{
    class MainPresenter
    {
        public IMainView view;

        public AdjacencyMatrixFromFile matrix;

        public MainPresenter(IMainView view)
        {
            this.view = view;
        }

        public void setFileText(String s)
        {
            matrix = new AdjacencyMatrixFromFile(s);
        }

        public void loadMatrix()
        {
            this.view.showMatrix(matrix.ToString());
        }
    }
}
