using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Microsoft.VisualBasic;

namespace WindowsApp
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            int total = 0;

            MessageBox.Show("Ingresar 10 numeros menores a 100");

            for (int i = 1; i <= 2; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese numero","Carga de numeros"));

                while (numero >= 100)
                {
                    MessageBox.Show("Numeros menores a 100. Intente nuevamente. ");
                    numero = Convert.ToInt32(Interaction.InputBox("Ingrese numero", "Carga de numeros"));
                }
                total = total + numero;
            }

            MessageBox.Show("Total: "+ total.ToString());
        }
    }
}
