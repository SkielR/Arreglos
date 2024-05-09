using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos1w1
{
    public partial class frmEmpleados : Form
    {
        const int tam = 2;
        //string[] aEmpleado = new string[tam];
        //double[] aSueldo = new double[tam];
        //double[] aNeto = new double[tam];
        Empleado[] aEmpleado = new Empleado[tam];
        int c;
        double total;
      
           

    public frmEmpleados()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                //aEmpleado[i] = "";
                //aSueldo[i] = 0;
                //aNeto[i] = 0;
                aEmpleado[i] = null;
            }
            c = 0;
            total = 0;
            if (string.IsNullOrEmpty(txtAumento.Text)) { btnAumento.Enabled = false; }
            else btnAumento.Enabled = true;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtAumento.Text)) { btnAumento.Enabled = false; }
            //else btnAumento.Enabled = true;

            //aEmpleado[c] = txtEmpleado.Text;
            //aSueldo[c] = double.Parse(txtSueldo.Text);
            //lstEmpleados.Items.Add(aEmpleado[c]);
            //lstSueldos.Items.Add(aSueldo[c]);
            aEmpleado[c] = new Empleado();
            aEmpleado[c].pNombre = txtEmpleado.Text;
            aEmpleado[c].pSueldo = Convert.ToDouble(txtSueldo.Text);

            lstEmpleados.Items.Add(aEmpleado[c].pNombre);
            lstSueldos.Items.Add(aEmpleado[c].pSueldo);


            c++;
            if (c==tam)
            {
                MessageBox.Show("Se completó la nómina de empleados...");
                btnCargar.Enabled = false;
                btnAumento.Enabled = true;
            }
            
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAumento.Text)) { btnAumento.Enabled = false; }
            else btnAumento.Enabled = true;

            lstNetos.Items.Clear();

            for (int i = 0; i < tam; i++)
            {
                //aNeto[i] = aSueldo[i] + (aSueldo[i] * Convert.ToDouble(txtAumento.Text) / 100);
                //lstNetos.Items.Add(aNeto[i]);
                //total += aNeto[i];

               /* lstNetos.Items.Add(aEmpleado[i].calcularNeto(double.Parse(txtAumento.Text)));*/

                lstNetos.Items.Add(aEmpleado[i].calcularNeto(Convert.ToDouble(txtAumento.Text)));
                total += aEmpleado[i].calcularNeto(Convert.ToDouble(txtAumento.Text));
            }

            txtTotal.Text = total.ToString();
            btnCargar.Enabled = true;
            btnAumento.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstEmpleados.Items.Clear();
            lstSueldos.Items.Clear();
            lstNetos.Items.Clear();
        }
    }
}
