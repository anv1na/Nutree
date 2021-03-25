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
    public partial class Calculadora_IMC : Form
    {
        public Calculadora_IMC()
        {
            InitializeComponent();
            cboPacientes.DataSource = CarregarcbPaciente();
            cboPacientes.DisplayMember = "nome";
            
        }

        public static DataTable CarregarcbPaciente()
        {
            try
            {

                SqlConnection con = new SqlConnection(Banco.BDConexao);
                con.Open();


                string sql = "Select nome from Paciente order by nome ASC";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

                con.Close();


            }
            catch (Exception)
            {
                return null;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Dietas d = new Dietas();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboPacientes.SelectedIndex = -1;
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            txtIMCResult.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.PaleGreen;
            btnCalcular.Enabled = txtPeso.Text != "" ? true : false;

            if (txtPeso.Text == "")
            {
                btnCalcular.BackColor = Color.LimeGreen;
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.PaleGreen;
            btnCalcular.Enabled = txtAltura.Text != "" ? true : false;

            if (txtAltura.Text == "")
            {
                btnCalcular.BackColor = Color.LimeGreen;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double IMC;
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                
                

                IMC = peso / altura/ altura *10000;

                if (IMC < 16)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Magreza Severa";
                }
                else if (IMC < 17)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Magreza Moderada";

                }
                else if(IMC < 18.5)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Magreza Leve";
                }
                else if (IMC < 25)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Peso Normal";
                }
                else if (IMC < 30)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Sobrepeso";
                }
                else if (IMC < 35)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Obesidade Classe I";
                }
                else if (IMC < 40)
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Obesidade Classe II";
                }
                else
                {

                    txtIMC.Text = "Seu IMC é:" + IMC;
                    txtIMCResult.Text = "O paciente possuí Obesidade Classe III";
                }

                SqlConnection con = new SqlConnection(Banco.BDConexao);
                con.Open();

                IMC imc_c = new IMC();


                imc_c.paciente = cboPacientes.Text;
                imc_c.altura = Convert.ToDecimal(txtAltura.Text);
                imc_c.peso = Convert.ToDecimal(txtPeso.Text);
                imc_c.imcvalor = Convert.ToString(txtIMC.Text);
                imc_c.resultadoimc = Convert.ToString(txtIMCResult.Text);




                string sqlInsreririmc = "insert into imc(paciente, altura, peso, imcvalor, imcresultado)values(@paciente, @altura, @peso, @imcvalor, @imcresultado)";


                SqlCommand cmdInseririmc = new SqlCommand(sqlInsreririmc, con);



                cmdInseririmc.Parameters.AddWithValue("@paciente", imc_c.paciente);
                cmdInseririmc.Parameters.AddWithValue("@altura", imc_c.altura);
                cmdInseririmc.Parameters.AddWithValue("@peso", imc_c.peso);
                cmdInseririmc.Parameters.AddWithValue("@imcvalor", imc_c.imcvalor);
                cmdInseririmc.Parameters.AddWithValue("@imcresultado", imc_c.resultadoimc);
                cmdInseririmc.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("IMC não cadastrado" + erro.Message);
            }
        }
        private void Calculadora_IMC_Load(object sender, EventArgs e)
        {

        }

    }
}
