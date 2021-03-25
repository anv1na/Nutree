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
    public partial class Metabolismo_Basal : Form
    {
        public Metabolismo_Basal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double idade = Convert.ToDouble(txtIdade.Text);


                double homem;
                double mulher;
                homem = 66 + (13.7 * peso) + (5 * altura) - (6.8 * idade);
                mulher = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * idade);

                if (cboGenero.SelectedItem == "Homem")
                {
                    MessageBox.Show("A taxa de metebolismo basal do paciente é:  " + homem, "Taxa de Metabolismo Basal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtresultado.Text = "metabolismo basal: " +homem;
                }
                else if (cboGenero.SelectedItem == "Mulher")
                {
                    MessageBox.Show("A taxa de metabolismo basal da paciente é:  " + mulher, "Taxa de Metabolismo Basal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtresultado.Text = "metabolismo basal: " + mulher;
                }   
                else
                {
                    MessageBox.Show("Insira todas as informações conforme o campo correspondente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                SqlConnection con = new SqlConnection(Banco.BDConexao);
                MetabolismoB metB = new MetabolismoB();

                metB.genero = Convert.ToString(cboGenero.Text);
                metB.altura = Convert.ToDecimal(txtAltura.Text);
                metB.peso = Convert.ToDecimal(txtPeso.Text);
                metB.idade = Convert.ToString(txtIdade.Text);
                metB.resultado = Convert.ToString(txtresultado.Text);

                con.Open();

                string sqlInsrerirMB = "insert into metabolismo_basal(genero, altura, peso, idade, resultado)values(@genero, @altura, @peso, @idade, @resultado)";


                SqlCommand cmdInserirMB = new SqlCommand(sqlInsrerirMB, con);

                cmdInserirMB.Parameters.AddWithValue("@genero", metB.genero);
                cmdInserirMB.Parameters.AddWithValue("@altura", metB.altura);
                cmdInserirMB.Parameters.AddWithValue("@peso", metB.peso);
                cmdInserirMB.Parameters.AddWithValue("@idade", metB.idade);
                cmdInserirMB.Parameters.AddWithValue("@resultado", metB.resultado);

                cmdInserirMB.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao calcular!! " + erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboGenero.SelectedIndex = -1;
            txtAltura.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            cboGenero.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Enabled = txtAltura.Text != "" ? true : false;

            if (txtAltura.Text == "")
            {
                btnCalcular.BackColor = Color.PaleGreen;
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Enabled = txtPeso.Text != "" ? true : false;

            if (txtPeso.Text == "")
            {
                btnCalcular.BackColor = Color.PaleGreen;
            }
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Enabled = txtIdade.Text != "" ? true : false;

            if (txtIdade.Text == "")
            {
                btnCalcular.BackColor = Color.PaleGreen;
            }
        }
    }
}
