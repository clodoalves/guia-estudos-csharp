using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAcessores
{
    /// <summary>
    /// <para>Este exemplo demonstra:</para>
    /// <para>Como trabalhar com metodos acessores, que permitem a leitura/escrita de atributos internos a um tempo, 
    /// reforcando o encapsulamento</para>
    /// <para>A abordagem tradicional para get e set, mostrando um exemplo pratico de consume destes metodos 
    /// para definir valores para dados de uma classe</para>
    /// </summary>
    public class Conta 
    {
        public Conta()
        {

        }
        public Conta(string nomeCliente)
        {
            _cliente = nomeCliente;
        }

        private string _cliente;
        private double _valor;
        public void Sacar(double valor) 
        {
            this._valor = this._valor - valor;
        }

        public void Depositar(double valor) 
        {
            this._valor = this._valor + valor;
        }

        public double getValor() 
        {
            return _valor;
        }

        //Get e Set da forma tradicional para encapsular um campo privado
        public string getCliente() 
        {
            return this._cliente;
        }

        public void setCliente(string value) 
        {
            this._cliente = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.setCliente("João");
            c.Depositar(1000);
            c.Sacar(500);

            Console.WriteLine($"Cliente = {c.getCliente()}");
            Console.WriteLine($"Saldo na data = {c.getValor()}");
            Console.ReadLine();
        }
    }
}
