using System;
using System.Net.Mime;

namespace _34_ImplementandoVariasInterfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Documento doc = new Documento(){ Nome = "Arquivo.docx"};
            doc.Descompactar();
            doc.Ler();
            doc.Escrever();
            doc.Compactar();

            Imagem img = new Imagem() { Nome = "Foto.jpg" };
            img.Descompactar();
            img.Ler();
            img.Escrever();
            img.Compactar();
                
            Console.ReadLine();
        }
    }
}