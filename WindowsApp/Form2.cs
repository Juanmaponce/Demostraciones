using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FormNotas : Form
    {
        public FormNotas()
        {
            InitializeComponent();
        }

        private void btnMaxNota_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            
            decimal mayorNota = Math.Max(Math.Max(nota1, nota2), Math.Max(nota3, nota4));

            MessageBox.Show("Tu mayor nota es " + mayorNota);
            
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            decimal promedio = (nota1 + nota2 + nota3 + nota4)/4;
            if (promedio >= 9)
            {
                MessageBox.Show("Promedio: "+promedio+" Excelente");
            }
            else if (promedio >= 7 & promedio < 9)
            {
                MessageBox.Show("Promedio: " + promedio + " Muy Bien");
            }
            else if (promedio < 7 & promedio >= 4)
            {
                MessageBox.Show("Promedio: " + promedio + " Regular");
            }
            else
            {
                MessageBox.Show("En proceso de aprendizaje");
            }
        }
    }
    
}
