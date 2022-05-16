using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30_InstanciasDeExcecao
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
            catch (OverflowException ex)
            {
                HandleException(ex);
                MessageBox.Show("Valor muito grande para peso ou altura");
            }
            catch (FormatException ex)
            {
                ex.Data.Add("Peso: ", txtPeso.Text);
                ex.Data.Add("Altura: ", txtAltura.Text);
                HandleException(ex);
                MessageBox.Show("Erro no formato de peso ou altura");
            }
            catch (DivideByZeroException ex)
            {
                HandleException(ex);
                MessageBox.Show("Altura não pode ser zero");
            }
            catch (ArithmeticException ex) 
            {
                HandleException(ex);
                MessageBox.Show("Erro aritmetico");
            }
            catch (Exception ex)
            {
                HandleException(ex);
                MessageBox.Show("Nao foi possivel completar a operacao");
            }
        }

        private void HandleException(Exception e) 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Message: ");
            sb.AppendLine(e.Message);
            sb.AppendLine("StackTrace: ");
            sb.AppendLine(e.StackTrace);
            sb.AppendLine("TargetSite:");
            sb.AppendLine(e.TargetSite.Name);
            sb.AppendLine("Source: ");
            sb.AppendLine(e.Source);

            sb.AppendLine("Data: ");
            foreach (var item in e.Data.Values)
            {
                sb.AppendLine(item.ToString());
            }

            txtErro.Text = sb.ToString();
        }
    }
}
