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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private async void FacturaButton_Click(object sender, EventArgs e)
        {
            if (Producto1TextBox.Text == "")
            {
                errorProvider1.SetError(Producto1TextBox, "Ingrese El Nombre del Producto");
                return;
            }
            if (Producto2TextBox.Text == "")
            {
                errorProvider1.SetError(Producto2TextBox, "Ingrese El Nombre del Producto");
                return;
            }
            if (Precio1TextBox.Text == "")
            {
                errorProvider1.SetError(Precio1TextBox, "Ingrese El Precio del Producto");
                return;
            }
            if (Precio2TextBox.Text == "")
            {
                errorProvider1.SetError(Precio2TextBox, "Ingrese El Precio del Producto");
                return;
            }

            errorProvider1.Clear();

            string producto1 = Convert.ToString(Producto1TextBox.Text);
            string producto2 = Convert.ToString(Producto2TextBox.Text);
            double precio1 = Convert.ToDouble(Precio1TextBox.Text);
            double precio2 = Convert.ToDouble(Precio2TextBox.Text);

            double total = await DescuentoAsync(precio1, precio2);

            MessageBox.Show($"El Descuento Para el Cliente es del 15%\nPor lo Tanto el Total a Pagar Será de: {total} Lps.");
        }
        private async Task<double> DescuentoAsync(double p1, double p2)
        {
            double factura = await Task.Run(() =>
            {
                return (p1 + p2) * 0.15;
            });
            return factura;
        }
    }
}
