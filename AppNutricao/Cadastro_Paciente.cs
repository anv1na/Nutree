using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace AppNutricao
{
    public partial class Cadastro_Paciente : Form
    {
        public Cadastro_Paciente()
        {
            InitializeComponent();
        }

        private void btnMetabolismoBasal_Click(object sender, EventArgs e)
        {
            Metabolismo_Basal MetB = new Metabolismo_Basal();
            MetB.ShowDialog();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            Peso_Ideal PesoI = new Peso_Ideal();
            PesoI.ShowDialog();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            Calculadora_IMC Cimc = new Calculadora_IMC();
            Cimc.ShowDialog();
        }

        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            Alterar_Cadastro alt = new Alterar_Cadastro();
            alt.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskCEP.Clear();
            txtEndereco.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            cbestado.SelectedIndex = -1;
            txtCidade.Clear();
            mskCPF.Clear();
            mskRG.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            txtAltura.Clear();
            txtPeso.Clear();
            cboGenero.SelectedIndex = -1;
            txtNome.Focus();

        }

        private void btnLimparHabitos_Click(object sender, EventArgs e)
        {
            cboFumante.SelectedIndex = -1;
            txtFumar.Clear();
            cbbeber.SelectedIndex = -1;
            txtBeber.Clear();
            cbodrogas.SelectedIndex = -1;
            txtDrogas.Clear();
            cboatividadefisica.SelectedIndex = -1; 
            txtatividadeF.Clear();
        }

        private void btnLimparInfo_Click(object sender, EventArgs e)
        {
            cboremedio.SelectedIndex = -1;
            txtRemedio.Clear();
            cbcirurgia.SelectedIndex = -1;
            txtCirurgia.Clear();
            cbProblemaF.SelectedIndex = -1;
            txtProblemaF.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cbDoencaH.SelectedIndex = -1;
            txtDoencaH.Clear();
            cbOutraDoenca.SelectedIndex = -1;
            txtDoencaO.Clear();
        }

        private void btnLimpaTudo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskCEP.Clear();
            txtEndereco.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            cbestado.SelectedIndex = -1;
            txtCidade.Clear();
            mskCPF.Clear();
            mskRG.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            txtAltura.Clear();
            txtPeso.Clear();
            cboGenero.SelectedIndex = -1;
            cboFumante.SelectedIndex = -1;
            txtFumar.Clear();
            cbbeber.SelectedIndex = -1;
            txtBeber.Clear();
            cbodrogas.SelectedIndex = -1;
            txtDrogas.Clear();
            cboatividadefisica.SelectedIndex = -1;
            txtatividadeF.Clear();
            cboremedio.SelectedIndex = -1;
            txtRemedio.Clear();
            cbcirurgia.SelectedIndex = -1;
            txtCirurgia.Clear();
            cbProblemaF.SelectedIndex = -1;
            txtProblemaF.Clear();
            cbDoencaH.SelectedIndex = -1;
            txtDoencaH.Clear();
            cbOutraDoenca.SelectedIndex = -1;
            txtDoencaO.Clear();
            txtNome.Focus();
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mskCEP.Text);


            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            txtEndereco.Text = ds.Tables[0].Rows[0][6].ToString();
            txtBairro.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0][3].ToString();
            cbestado.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                Pacient pac = new Pacient();

                SqlConnection conBd = new SqlConnection(Banco.BDConexao);
                conBd.Open();

                string sql = "Insert into Paciente(nome, nascimento, cep, endereco, numero, bairro, estado, cidade, cpf, rg, celular, telefone, altura, peso, genero, fuma, fumaroque, bebe, bebeoque, droga, drogaqual, atividadef, atividadefqual, remedio, remedioqual,cirurgia, cirurgiaqual, problemaf, problemafqual, doencaH, doencaHqual, outradoenca, outradoencaqual)" +
                "values(@nome, @nascimento, @cep, @endereco, @numero, @bairro, @estado, @cidade, @cpf, @rg, @celular, @telefone, @altura, @peso, @genero, @fuma, @fumaroque, @bebe, @bebeoque, @droga, @drogaqual, @atividadef, @atividadefqual, @remedio, @remedioqual, @cirurgia, @cirurgiaqual, @problemaf, @problemafqual, @doencaH, @doencaHqual, @outradoenca, @outradoencaqual)";


                SqlCommand cmd = new SqlCommand(sql, conBd);


                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@nascimento", SqlDbType.VarChar).Value = dateTimePicker1.Text;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = mskCEP.Text;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
                cmd.Parameters.Add("@numero", SqlDbType.Int).Value = txtNum.Text;
                cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = cbestado.Text;
                cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mskCPF.Text;
                cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = mskRG.Text;
                cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = mskCelular.Text;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mskTelefone.Text;
                cmd.Parameters.Add("@altura", SqlDbType.Decimal).Value = txtAltura.Text;
                cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = txtPeso.Text;
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cboGenero.Text;
                cmd.Parameters.Add("@fuma", SqlDbType.VarChar).Value = cboFumante.Text;
                cmd.Parameters.Add("@fumaroque", SqlDbType.VarChar).Value = txtFumar.Text;
                cmd.Parameters.Add("@bebe", SqlDbType.VarChar).Value = cbbeber.Text;
                cmd.Parameters.Add("@bebeoque", SqlDbType.VarChar).Value = txtBeber.Text;
                cmd.Parameters.Add("@droga", SqlDbType.VarChar).Value = cbodrogas.Text;
                cmd.Parameters.Add("@drogaqual", SqlDbType.VarChar).Value = txtDrogas.Text;
                cmd.Parameters.Add("@atividadef", SqlDbType.VarChar).Value = cboatividadefisica.Text;
                cmd.Parameters.Add("@atividadefqual", SqlDbType.VarChar).Value = txtatividadeF.Text;
                cmd.Parameters.Add("@remedio", SqlDbType.VarChar).Value = cboremedio.Text;
                cmd.Parameters.Add("@remedioqual", SqlDbType.VarChar).Value = txtRemedio.Text;
                cmd.Parameters.Add("@cirurgia", SqlDbType.VarChar).Value = cbcirurgia.Text;
                cmd.Parameters.Add("@cirurgiaqual", SqlDbType.VarChar).Value = txtCirurgia.Text;
                cmd.Parameters.Add("@problemaf", SqlDbType.VarChar).Value = cbProblemaF.Text;
                cmd.Parameters.Add("@problemafqual", SqlDbType.VarChar).Value = txtProblemaF.Text;
                cmd.Parameters.Add("@doencaH", SqlDbType.VarChar).Value = cbDoencaH.Text;
                cmd.Parameters.Add("@doencaHqual", SqlDbType.VarChar).Value = txtDoencaH.Text;
                cmd.Parameters.Add("@outradoenca", SqlDbType.VarChar).Value = cbOutraDoenca.Text;
                cmd.Parameters.Add("@outradoencaqual", SqlDbType.VarChar).Value = txtDoencaO.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente cadastrado com sucesso!!");

                conBd.Close();

            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar paciente!! " + erro.Message);
            }
        }

        private void cboFumante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
