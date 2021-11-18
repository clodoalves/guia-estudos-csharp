using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionais
{
    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para> - Como trabalhar com parametros opcionais, que permitem a omissão da
    /// passagem de valor para um paramametro. A assinatura do metodo deve conter o
    /// valor para a atribuicao padrao caso quem consuma o metodo nao passe o parametro</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogo dlg1 = new CaixaDialogo();
            dlg1.Show("Confirmar", true, true);

            CaixaDialogo dlg2 = new CaixaDialogo();
            dlg2.Show(Mensagem: "Confirmar", Ok: true, No: true, Delay: 100);

            Console.ReadLine();
        }
    }

    public class CaixaDialogo 
    {
        public void Show(
            string Mensagem, 
            bool Ok, 
            bool No,
            int TamanhoCaixa = 200,
            bool Cancel = false,
            int Delay = 10
            )
        {
            Console.WriteLine(Mensagem);        
        }
    }
}
