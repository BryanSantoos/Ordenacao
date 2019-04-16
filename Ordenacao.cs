using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmOrdenacao : Form
    {
        public frmOrdenacao()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //Possibilidades:
            /* A B C
             * A C B
             * B A C
             * B C A
             * C A B
             * C B A
             */
            //Declarações das variáveis
            int A, B, C;
            //Entrada de dados 
            A = Convert.ToInt32(txtA.Text);
            B = Convert.ToInt32(txtB.Text);
            C = Convert.ToInt32(txtC.Text);
            if (A <= B && B <= C)
            {
                MessageBox.Show(A + " - " + B + " - " + C);
            }
            else if (A <= C && C <= B)
            {
                MessageBox.Show(A + " - " + C + " - " + B);
            }
            else if (B <= A && A <= C)
            {
                MessageBox.Show(B + " - " + A + " - " + C);
            }
            else if (B <= C && C <= A)
            {
                MessageBox.Show(B + " - " + C + " - " + A);
            }
            else if (C <= A && A <= B)
            {
                MessageBox.Show(C + " - " + A + " - " + B);
            }
            else         
            {                             
                MessageBox.Show(C + " - " + B + " - " + A);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }
    }
}
