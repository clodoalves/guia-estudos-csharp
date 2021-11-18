using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarOutroBotao_Click(object sender, EventArgs e)
        {
            Button dynamicButton = new Button();
            dynamicButton.Parent = this;
            dynamicButton.Location = new Point(235, 150);
            dynamicButton.Text = "Novo botão";

            dynamicButton.Click += new EventHandler(DynamicButton_Click);

            //Método anônimo
            dynamicButton.Click += delegate (object s, EventArgs ea)
            {
                MessageBox.Show("Ola mundo 2");
            };

            //Lambda expression
            dynamicButton.Click += (s, ea) =>
            {
                MessageBox.Show("Ola mundo 3");
            };
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola mundo");
        }
    }
}
