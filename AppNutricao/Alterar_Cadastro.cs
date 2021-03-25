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
    public partial class Alterar_Cadastro : Form
    {
        public Alterar_Cadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alterar_Cadastro_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Banco.BDConexao);
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT nome, nascimento, cep, endereco, numero, bairro, estado, cidade, cpf, rg, celular, telefone, altura, peso, genero, fuma, fumaroque, bebe, bebeoque, droga, drogaqual, atividadef, atividadefqual, remedio, remedioqual,cirurgia, cirurgiaqual, problemaf, problemafqual, doencaH, doencaHqual, outradoenca, outradoencaqual FROM Paciente", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           dtgAlterar.DataSource = dt;

        }
    }
}
