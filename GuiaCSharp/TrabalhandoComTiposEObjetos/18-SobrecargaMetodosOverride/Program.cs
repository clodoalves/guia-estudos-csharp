using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosOverride
{
    /// <summary>
    /// Este exemplo demonstra:
    /// <para>Como trabalhar com sobrecarga de metodos (sobreescrita) usando override, que permite ter
    /// multiplas versoes do mesmo metodo, matendo o mesmo nome</para>
    /// <para>Override, diferente de overload, necessita o uso de heranca, 
    /// aplicando-se a tecnica de polimorfismo</para>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Windows windows = new Windows();

            Arquivo musica = new Musica { Nome = "Pink Floyd - Learning To Fly.mp3" };
            Arquivo documentoWord = new DocumentoWord { Nome = "Trabalho da faculdade.doc" };
            Arquivo imagem = new Imagem { Nome = "Floresta Amazonica.jpg" };
            Arquivo planilhaExcel = new PlanilhaExcel { Nome = "Planilha de gastos.xls" };

            windows.AdicionarArquivo(musica);
            windows.AdicionarArquivo(documentoWord);
            windows.AdicionarArquivo(imagem);
            windows.AdicionarArquivo(planilhaExcel);

            //windows.AbrirArquivo(musica);
            //windows.AbrirArquivo(documentoWord);
            //windows.AbrirArquivo(imagem);
            //windows.AbrirArquivo(planilhaExcel);

            windows.AbrirTodos();

            Console.ReadLine();
        }
    }
}
