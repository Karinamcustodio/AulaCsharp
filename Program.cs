using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AulaPOOcar
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdicionarCar();
            //VerificarCadastroCar();
            //ListCar();

            List<Car> cars = new List<Car>();

            while (true)
            {
                Console.WriteLine("Infome uma opção");
                Console.WriteLine("1 = Cadastre seu carro");
                Console.WriteLine("2 = Consulte seu cadastro");
                Console.WriteLine("3 = Edite seu cadastrro");
                Console.WriteLine("4 = Exclui seu cadastro");
                Console.WriteLine("5 = Consulte um cadastro pela placa");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarCar(cars);
                        break;

                    case 2:
                        VerificarCadastroCar(cars);
                        break;
                        
                    case 3:
                        EditarCadastroCar();
                        break;

                    case 4:
                        ExcluirCadastroCar();
                        break;

                    case 5:
                        ConsultarPlacaCadastroCar();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            Console.ReadKey();
        }

        static void AdicionarCar(List<Car> origin)
        {
            bool repetir = true;
            int contador = 0;

                Console.WriteLine("Vamos cadastrar seu carro!");

            while (repetir)
            {
                Console.WriteLine("Informe a marca do carro:");
                string marca = Console.ReadLine();
                
                Console.WriteLine("Informe o modelo do carro:");
                string modelo = Console.ReadLine();
                
                Console.WriteLine("Informe a cor do carro:");
                string cor = Console.ReadLine();
               
                Console.WriteLine("Informe a placa do carro:");
                string placa = Console.ReadLine();

                origin.Add(new Car(marca, modelo, cor, placa));

                Console.WriteLine("Deseja cadastrar mais um carro? s = sim  n = não");
                string opcao = Console.ReadLine();
                repetir = opcao.ToLower().Equals("s");
                contador++;
            }
        }

        static void VerificarCadastroCar(List<Car> origin)
        {
            Console.WriteLine("Segue informações do seu cadastro!");

            foreach (Car car in origin)
            {
                Console.WriteLine(car.displayCar());
                break;
            }
        }

        static void EditarCadastroCar()
        {

        }

        static void ExcluirCadastroCar()
        {

        }

        static void ConsultarPlacaCadastroCar()
        {

        }

        static void ListCar()
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car() { Marca = "Fiat", Modelo = "Mobi", Cor = "Branco", Placa = "QJP8877" });
            cars.Add(new Car() { Marca = "Volkswagen", Modelo = "Gol", Cor = "Preto", Placa = "DLM4562" });
            cars.Add(new Car() { Marca = "Chevrolet", Modelo = "Onix", Cor = "Vermelho"});
            cars.Add(new Car() { Modelo = "Tracker", Placa = "HJR7648" });
        }
    }
}