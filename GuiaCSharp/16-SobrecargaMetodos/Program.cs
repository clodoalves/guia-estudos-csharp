using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    /// <summary>
    /// <para> Este exemplo demostra: </para>
    /// <para> - Como trabalhar com sobrecarga de métodos usando overloads, que
    /// permite a existencia de multiplas versoes do mesmo metodo, mantendo o mesmo
    /// nome, mas variando os parametros</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogo dlg1 = new CaixaDialogo();
            dlg1.Show("Confirmar?");

            CaixaDialogo dlg2 = new CaixaDialogo();
            dlg2.Show("Confirmar?", 20.0); ;

            CaixaDialogo dlg3 = new CaixaDialogo();
            dlg3.Show("Confirmar?", delay: 20.0, ok: true, no: true); 

            Console.ReadLine();
        }
    }

    public class CaixaDialogo
    {
        //default
        public void Show(string mensagem, int delay=10)
        {
            Console.WriteLine(mensagem);
        }

        public void Show(string mensagem, double delay) 
        {
            //configuracao de delay
            Show(mensagem);
        }

        public void Show(string mensagem, double delay, bool ok, bool no)
        {
            //configuracao de delay
            //configuracao de botao ok
            //configuracao de botao no
            Show(mensagem);
        }
    }
}
