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
    public partial class frmArreglo : Form
    {
        ////int tam = 0;
        const int tam = 3;
        int[] A = new int[tam];

        ////int[] A = new int[3];
        int c;

        public frmArreglo()
        {
            InitializeComponent();
            c = 0;
            for (int i = 0; i < tam; i++)
                A[i] = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ////if (tam <= 3)
            ////{
            ////    A[tam] = System.Int32.Parse(txtNumero.Text);
            ////    tam++;
            ////    txtNumero.Text = "";
            ////};
            ////if (tam == 3)
            ////{
            ////    txtNumero.Text = "Ya esta";
            ////};
            A[c] = int.Parse(txtNumero.Text);
            c++;
            if (c == tam)
            {
                MessageBox.Show("Se completó el arreglo...");
                btnCargar.Enabled = false;
            }

}

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tam; i++)
            {
                lstNumeros.Items.Add(A[i]);
            }
        }

        private void frmArreglo_Load(object sender, EventArgs e)
        {

        }
    }
}
