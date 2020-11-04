using ClassMatrix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGEnerateMatrix_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1(Convert.ToInt32(numericUpDownRowCount.Value),
                Convert.ToInt32(numericUpDownColCount.Value));
            class1.FillRandomNumbers();

            DateGridViewVisualizer dateGridViewVisualizer =
                new DateGridViewVisualizer(dataGridViewMatrix);
            dateGridViewVisualizer.Fill(class1);

        }

        private void dataGridViewVisualizer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
