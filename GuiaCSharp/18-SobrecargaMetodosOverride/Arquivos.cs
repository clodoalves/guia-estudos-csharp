using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosOverride
{
    public class Musica 
    {
        public string Nome;
        public double Tamanho;
        public void Abrir() 
        {
            Console.WriteLine($"Tocando musica: {Nome}");
        }

       
    }

    public class DocumentoWord
    {
        public string Nome;
        public double Tamanho;

        public void Abrir()
        {
            Console.WriteLine($"Abrindo documento: {Nome}");
        }
    }

    public class Imagem
    {
        public string Nome;
        public double Tamanho;

        public void Abrir()
        {
            Console.WriteLine($"Exibindo imagem: {Nome}");
        }
    }

    public class PlanilhaExcel
    {
        public string Nome;
        public double Tamanho;

        public void Abrir()
        {
            Console.WriteLine($"Abrindo planilha: {Nome}");
        }
    }

    public class Windows
    {
        private ArrayList _arquivos;

        public Windows()
        {
            _arquivos = new ArrayList();
        }

        public void AdicionarArquivo(object arquivo)
        {
            _arquivos.Add(arquivo);
        }

        public void AbrirArquivo(object arquivo)
        {
            if (arquivo is Musica musica)
            {
                musica.Abrir();
            }
            else if (arquivo is DocumentoWord documentoWord)
            {
                documentoWord.Abrir();
            }
            else if (arquivo is Imagem imagem)
            {
                imagem.Abrir();
            }
            else if (arquivo is PlanilhaExcel planilhaExcel)
            {
                planilhaExcel.Abrir();
            }
        }
    }
}
