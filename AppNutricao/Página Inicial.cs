using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNutricao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbCadastro_Click(object sender, EventArgs e)
        {
            Cadastro_Paciente Cpac = new Cadastro_Paciente();
            Cpac.ShowDialog();
        }

        private void tsbIMC_Click(object sender, EventArgs e)
        {
            Calculadora_IMC Cimc = new Calculadora_IMC();
            Cimc.ShowDialog();
        }

        private void tsbmetabolismo_Click(object sender, EventArgs e)
        {
            Metabolismo_Basal MetB = new Metabolismo_Basal();
            MetB.ShowDialog();
        }

        private void tsbpesoideal_Click(object sender, EventArgs e)
        {
            Peso_Ideal PesoI = new Peso_Ideal();
            PesoI.ShowDialog();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nutree_Quem_Somos nutree = new Nutree_Quem_Somos();
            nutree.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajuda_TecOn tecon = new Ajuda_TecOn();
            tecon.ShowDialog();
        }
    }
}
