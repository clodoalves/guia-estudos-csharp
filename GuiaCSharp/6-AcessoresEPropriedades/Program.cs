using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoresEPropriedades
{


    /// <summary>
    /// Este exemplo demostra:
    /// <para>Como trabalhar com metodos acessores utilizando propriedades em C#,
    /// que permitem a leitura/escrita de atributos internos a um tipo, reforçando encapsulamento,
    /// porem usando a mesma estruta da propriedade, sem a necessidade da criacao de metodos Get/Set
    /// publicos</para>
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno a = new Aluno();
                a.Matricula = 123;
                a.Nome = "Jose";
                a.Mensalidade = -100;
                a.Tipo = TipoAluno.Regular;
            }
            catch (MensalidadeNegativaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }

    public class MensalidadeNegativaException : Exception
    {
        public MensalidadeNegativaException(string message) : base(message)
        {

        }
    }
    public enum TipoAluno
    {
        Regular, Especial
    }
    public class Aluno
    {
        private int _matricula;
        private string _nome;
        private double _mensalidade;
        private TipoAluno _tipo;

        public int Matricula
        {
            get
            {
                return this._matricula;
            }

            set
            {
                this._matricula = value;
            }
        }


        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                this._nome = value;
            }
        }

        public double Mensalidade
        {
            get { return this._mensalidade; }
            set
            {
                if (value < 0)
                    throw new Exception("Valor da mensalidade nao pode ser negativo");
                else
                    this._mensalidade = value;
            }
        }

        public TipoAluno Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
    }

}
