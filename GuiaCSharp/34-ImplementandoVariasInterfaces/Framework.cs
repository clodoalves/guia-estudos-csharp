using System;

namespace _34_ImplementandoVariasInterfaces
{
    public interface IComprimivel
    {
        void Compactar();
        void Descompactar();
    }

    public interface IArmazenavel
    {
        void Ler();
        void Escrever();
    }
    
    public class Compactador : IComprimivel
    {
        public void Compactar()
        {
            Console.WriteLine("Compactando arquivo");
        }

        public void Descompactar()
        {
            Console.WriteLine("Descompactando arquivo");
        }
    }

    public class Armazenador : IArmazenavel
    {
        public void Ler()
        {
            Console.WriteLine("Lendo arquivo");
        }

        public void Escrever()
        {
            Console.WriteLine("Escrevendo em arquivo");
        }
    }

    public class Arquivo
    {
        public string Nome { get; set; }
    }
    
    public class Documento : Arquivo, IComprimivel, IArmazenavel
    {
        private Compactador _compactador;
        private Armazenador _armazenador;

        public Documento()
        {
            _compactador = new Compactador();
            _armazenador = new Armazenador();
        }
        public void Compactar()
        {
            _compactador.Compactar();        
        }

        public void Descompactar()
        {
           _compactador.Descompactar();
        }

        public void Ler()
        {
            _armazenador.Ler();
        }

        public void Escrever()
        {
            _armazenador.Escrever();
        }
    }
    
    public class Imagem : Arquivo, IComprimivel, IArmazenavel
    {
        private Compactador _compactador;
        private Armazenador _armazenador;

        public Imagem()
        {
            _compactador = new Compactador();
            _armazenador = new Armazenador();
        }
        
        public void Compactar()
        {
            _compactador.Compactar();
        }

        public void Descompactar()
        {
            _compactador.Descompactar();
        }

        public void Ler()
        {
            _armazenador.Ler();
        }

        public void Escrever()
        {
            _armazenador.Escrever();
        }
    }
}