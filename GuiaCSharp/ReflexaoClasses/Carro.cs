using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexaoClasses
{
    internal class Carro: ICarro
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        
        private int _velocidade;
        public int Velocidade
        {
            get { return this._velocidade; }
        }
        public void Acelerar(int quantidade)
        {
            this._velocidade += quantidade;
        }
        public bool EstaEmMovimento()
        {
            return Velocidade != 0;
        }
        public Carro()
        {
            Cor = "Vermelho";
            this._velocidade = 0;
        }
        public Carro(string cor, int velocidade)
        {
            Cor = cor;
            this._velocidade = velocidade;
        }
        public double CalcularQuilometrosPorLitro(int kmInicial, int kmFinal, double litros)
        {
            return (kmFinal - kmFinal) / litros;
        }
    }
    internal class CarroEsportivo: Carro
    {
        public CarroEsportivo()
        {
            Cor = "Azul";
        }
    }
}