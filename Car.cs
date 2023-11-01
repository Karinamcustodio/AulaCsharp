using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOOcar
{
    class Car
    {
        private string marca;
        private string modelo;
        private string cor;
        private string placa;
    
        public Car()
        {
            //
        }

        public Car(string marca, string modelo, string cor, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Placa = placa;
        }

        public Car(string marca, string modelo, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
        }

        public Car(string modelo, string placa)
        {
            Modelo = modelo;
            Placa = placa;
        }

        public string displayCar()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Cor: {cor}, Placa: {placa}";
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("O nome da marca precisa ter no mínimo três letras");
                }
                else
                {
                    marca = value;
                }
            }
        }
        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("O nome do modelo precisa ter no mínimo quatro letras");
                }
                else
                {
                    modelo = value;
                }
            }
        }

        public string Cor
        {
            get { return cor; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("O nome do modelo precisa ter no mínimo quatro letras");
                }
                else
                {
                    cor = value;
                }
            }
        }

        public string Placa
        {
            get { return placa; }
            set
            {
                if (value.Length < 7)
                {
                    Console.WriteLine("A placa precisa ter no mínimo sete letras");
                }
                else
                {
                    placa = value;
                }
            }
        }
    }
}
