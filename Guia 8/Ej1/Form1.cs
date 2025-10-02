using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Cuenta> cuentas = new List<Cuenta>();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);

            Cuenta c = new Cuenta(nombre, dni, importe);
            cuentas.Add(c);

            tbNombre.Clear();
            tbDNI.Clear();
            tbImporte.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var c in cuentas)
            {
                listBox1.Items.Add(c);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Cuenta c = listBox1.SelectedItem as Cuenta;
            if (c != null)
            {
                tbDNI.Text = $"{c.DNI}";
                tbNombre.Text = $"{c.Nombre}";
                tbImporte.Text = $"{c.Importe}";
            }
        }

        

    }
}
