using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double notaG1 = 8.7;
            double notaG2 = 9.2;
            double mediaPonderada = (notaG1 + (notaG2 * 2)) / 3;

            MessageBox.Show("Nota final: " + mediaPonderada);
        }
    }
}
