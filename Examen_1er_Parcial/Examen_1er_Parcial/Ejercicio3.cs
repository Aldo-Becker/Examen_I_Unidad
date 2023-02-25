using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1er_Parcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void PresionarButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(RecorrerNumeros(1));
        }
        private int RecorrerNumeros(int numeroInicio)
        {

            while (numeroInicio < 100)
            {
                listBox1.Items.Add(numeroInicio);
                if (numeroInicio % 3 == 0)
                {
                    listBox1.Items.Add("Aldo");
                }
                if (numeroInicio % 5 == 0)
                {
                    listBox1.Items.Add("Becker");
                }
                if (numeroInicio % 3 == 0 && numeroInicio % 5 == 0)
                {
                    listBox1.Items.Add("Aldo Becker");
                }
                numeroInicio++;
            }
            return numeroInicio;
        }
    }
}
