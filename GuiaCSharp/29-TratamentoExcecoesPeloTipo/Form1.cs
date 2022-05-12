using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_TratamentoExcecoesPeloTipo
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
            catch (OverflowException)
            {
                MessageBox.Show("Valor muito grande para peso ou altura");
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro no formato de peso ou altura");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Altura não pode ser zero");
            }
            catch (ArithmeticException) 
            {
                MessageBox.Show("Erro aritmetico");
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel completar a operacao");
            }
        }
    }
}
