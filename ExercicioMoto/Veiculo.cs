using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMoto
{

    /*
    A partir da classe Veiculo cria a classe Moto com o atributo 
    cilindradas.A partir da classe Moto crie classes derivadas com 
    atributos específicos para Moto de passeio e de competição.
    Criar métodos polimórficos para listar os atributos de cada objeto 
    criado.
    */

    class Veiculo
    {
        public string Marca { get; set; }

        public Veiculo() { }
        public Veiculo(string marca)
        {
            Marca = marca;
        }

        public string toString()
        {
            return $"Marca: {Marca}";
        }
    }

    class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto() { }
        public Moto(string marca, int cilindradas):base(marca)
        {
            Cilindradas = cilindradas;
        }

        public string toString()
        {
            return $"{base.toStringVeiculo()}, Cilindradas: {Cilindradas}cc";
        }
    }

    class MotoPasseio : Moto
    {
        public int ConsumoCombustivel { get; set; }

        public MotoPasseio() { }
        public MotoPasseio(string marca, int cilindradas, int consumoCombustivel):base(marca, cilindradas)
        {
            ConsumoCombustivel = consumoCombustivel;
        }

        public string toString()
        {
            return $"{base.toString()}, Consumo do combustível: {ConsumoCombustivel}km/l";
        }
    }

    class MotoCompeticao : Moto
    {
        public int VelocidadeMaxima { get; set; }

        public MotoCompeticao() { }
        public MotoCompeticao(string marca, int cilindradas, int velocidadeMaxima):base(marca, cilindradas)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        public string toString()
        {
            return $"{base.toString()}, Velocidade máxima: {VelocidadeMaxima}km/h";
        }
    }
}
