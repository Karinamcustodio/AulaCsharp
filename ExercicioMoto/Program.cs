namespace ExercicioMoto
{
    class Program
    {
        static void Main(string[] args)
        {
            criarMoto();
            Console.ReadKey();
        }

        static void criarMoto()
        {
            MotoPasseio motoPasseio = new MotoPasseio() 
            { 
                Marca = "Honda",
                Cilindradas = 745,
                ConsumoCombustivel = 14
            };
            Console.WriteLine(motoPasseio.toString());

            MotoCompeticao motoCompeticao = new MotoCompeticao() 
            { 
                Marca = "Kawasaki",
                Cilindradas = 449,
                VelocidadeMaxima = 400
            };
            Console.WriteLine(motoCompeticao.toString());
        }
    }
}