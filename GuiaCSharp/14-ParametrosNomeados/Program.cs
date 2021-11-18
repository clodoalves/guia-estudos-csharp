
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{

    /// <summary>
    /// Este exemplo demonstra:
    /// <para>Utilizacao de parametros nomeados, que permitem passar parâmetros para métodos usando o nome além do valor. </para>
    /// <para> O uso de parametros nomeados torna o código mais legível (reduz “bad smells”). </para>
    /// <para>Pode ser usado ainda para passar parâmetros em ordem diferente da assinatura </para>
    /// </summary>
    class Program
    {     
        static void Main(string[] args)
        {
            //Abordagem sem uso de parametros nomeados
            DialogBoxBadSmell dialog1 = new DialogBoxBadSmell();
            dialog1.Show("Mensagem", true, true, false, 10);

            //Uso de parametros, mas com metodo que possui muitos parametros
            DialogBoxBadSmell dialog2 = new DialogBoxBadSmell();
            dialog2.Show(message: "Mensagem", delay: 10, showButtonCancel: false, showButtonYes: true, showButtonNo: true);

            //Uso de objeto para encapsular os parametros da caixa de dialog
            DialogBox dialog3 = new DialogBox();

            DialogParams dialogParams = new DialogParams()
            {
                message = "Mensagem",
                showButtonCancel = true,
                showButtonYes = false,
                showButtonNo = false,
                delay = 100
            };

            dialog3.Show(dialogParams: dialogParams);

            Console.ReadLine();

        }
    }


    public class DialogBoxBadSmell 
    {    
        public void Show(string message, bool showButtonYes, bool showButtonNo, bool showButtonCancel, int delay) 
        {
            Console.WriteLine(message);
        }         
    }

    public class DialogBox
    {
        public void Show(DialogParams dialogParams)
        {
            Console.WriteLine(dialogParams.message);
        }
    }

    public class DialogParams
    {
        public string message;
        public bool showButtonYes; 
        public bool showButtonNo;
        public bool showButtonCancel;
        public int delay;
    }
}
