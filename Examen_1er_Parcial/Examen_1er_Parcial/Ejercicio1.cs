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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = Enero(1) + Febrero(2) + Marzo(3) + Abril(4) + Mayo(5) + Junio (6) + Julio(7) +
                Agosto(8) + Septiembre(9) + Octubre(10) + Noviembre(11) + Diciembre(12);

            listBox1.Items.Add($"La Ganancia Total que Tendrá a Fin de Año Será de: {total} Lps.");
        }
        private double Enero(int mes)
        {
            mes = 1;
            double capital = 200000;
            double tasa = 0.015;
            mes = 1;
            double interes = capital * tasa * mes;
            if (mes == 1)
            {
                listBox1.Items.Add($"En el Mes de Enero, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Febrero(int mes)
        {
            mes = 2;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 2)
            {
                listBox1.Items.Add($"En el Mes de Febrero, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Marzo(int mes)
        {
            mes = 3;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 3)
            {
                listBox1.Items.Add($"En el Mes de Marzo, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Abril(int mes)
        {
            mes = 4;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 4)
            {
                listBox1.Items.Add($"En el Mes de Abril, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Mayo(int mes)
        {
            mes = 5;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 5)
            {
                listBox1.Items.Add($"En el Mes de Mayo, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Junio(int mes)
        {
            mes = 6;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 6)
            {
                listBox1.Items.Add($"En el Mes de Junio, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Julio(int mes)
        {
            mes = 7;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 7)
            {
                listBox1.Items.Add($"En el Mes de Julio, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Agosto(int mes)
        {
            mes = 8;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 8)
            {
                listBox1.Items.Add($"En el Mes de Agosto, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Septiembre(int mes)
        {
            mes = 9;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 9)
            {
                listBox1.Items.Add($"En el Mes de Septiembre, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Octubre(int mes)
        {
            mes = 10;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 10)
            {
                listBox1.Items.Add($"En el Mes de Octubre, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Noviembre(int mes)
        {
            mes = 11;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 11)
            {
                listBox1.Items.Add($"En el Mes de Noviembre, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }
        private double Diciembre(int mes)
        {
            mes = 12;
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * mes;
            if (mes == 12)
            {
                listBox1.Items.Add($"En el Mes de Diciembre, La Ganancia por Interes Será de: {interes} Lps.");
            }
            return interes;
        }

    }
}
