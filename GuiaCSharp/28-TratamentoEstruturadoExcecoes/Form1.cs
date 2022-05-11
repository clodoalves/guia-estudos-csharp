using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_TratamentoEstruturadoExcecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                double imc = peso / (Math.Pow(altura, 2));

                txtImc.Text = imc.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel completar a operacao");
             
            }
        }
    }
}
