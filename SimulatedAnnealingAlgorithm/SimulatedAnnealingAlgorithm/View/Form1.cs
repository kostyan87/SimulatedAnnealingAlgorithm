using SimulatedAnnealingAlgorithm.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulatedAnnealingAlgorithm.View
{
    public partial class Form1 : Form, IMainView
    {
        private MainPresenter presenter;

        public Form1()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var s = new StreamReader(openFileDialog.FileName);
                    presenter.setFileText(s.ReadToEnd());
                    presenter.loadMatrix();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        public void showMatrix(string s)
        {
            label1.Text = s;
        }
    }
}
