using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosOverride
{
    public abstract class Arquivo 
    {
        public string Nome;
        public double Tamanho;
        public virtual void Abrir() 
        {
            Console.WriteLine($"Log - Abrindo Arquivo: {Nome}");
        }

        //public abstract void Abrir();
    }
    public class Musica : Arquivo
    {
        public override void Abrir() 
        {
            base.Abrir();
            Console.WriteLine($"Tocando musica: {Nome}");
        }      
    }

    public class DocumentoWord : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Abrindo documento: {Nome}");
        }
    }

    public class Imagem : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Exibindo imagem: {Nome}");
        }
    }

    public class PlanilhaExcel : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Abrindo planilha: {Nome}");
        }
    }

    public class Windows
    {
        private List<Arquivo> _arquivos;

        public Windows()
        {
            _arquivos = new List<Arquivo>();
        }

        public void AdicionarArquivo(Arquivo arquivo)
        {
            _arquivos.Add(arquivo);
        }

        public void AbrirArquivo(Arquivo arquivo)
        {
            arquivo.Abrir();
        }

        public void AbrirTodos() 
        {
            foreach (Arquivo item in _arquivos)
            {
                AbrirArquivo(item);
            }
        }
    }
}
