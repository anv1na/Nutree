using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AppNutricao
{
    public partial class Peso_Ideal : Form
    {
        public Peso_Ideal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Enabled = txtAltura.Text != "" ? true : false;

            if (txtAltura.Text == "")
            {
                btnCalcular.BackColor = Color.MediumAquamarine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double peso_ideal = 0;
            double altura = Convert.ToDouble(txtAltura.Text);

            //condição homem ou mulher
            if (cboGenero.SelectedItem == "Homem")
            {
                // homem
                peso_ideal = (72.7 * altura) - 58;
            }
            else
            {
                //mulher

                peso_ideal = (62.7 * altura) - 44.7;
            }

            StringBuilder srt = new StringBuilder("A idade do paciente é: " + txtIdade.Text + " Peso ideal: " + peso_ideal.ToString(" 0.00 ") + "kg.");

            //comparação com o peso atual
            if (txtPeso.Text != "")
            {
                double peso_atual = Convert.ToDouble(txtPeso.Text);
                if (peso_ideal < peso_atual)
                {
                    //deve emagrecer
                    srt.Append(Environment.NewLine + "Deve emagrecer " + (peso_atual - peso_ideal).ToString("0.00") + "Kg.");
                    
                }
                else if (peso_ideal > peso_atual)
                {
                    //está abaixo do seu peso ideal
                    srt.Append(Environment.NewLine + "Está " + (peso_ideal - peso_atual).ToString("0.00") + "Kg. abaixo do seu peso ideal.");
                    
                }
                else
                {
                    //tem o peso ideal
                    srt.Append(Environment.NewLine + "Parabéns! Está com o seu peso ideal." );
                    
                } 
            }

            MessageBox.Show(srt.ToString());
        }



        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Enabled = txtPeso.Text != "" ? true : false;

            if (txtPeso.Text == "")
            {
                btnCalcular.BackColor = Color.MediumAquamarine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboGenero.SelectedIndex = -1;
            txtAltura.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
