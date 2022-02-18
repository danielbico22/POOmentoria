using System;




namespace POOmentoria
{
    public class Program
    {
        static void Main(string[] args)
        {

            Veiculo carro = new Veiculo("Fiat", "Punto", 2017, "Branco Kalahari", 71250, 42350.00);
            Veiculo carro2 = new Veiculo("Fiat", "500", 2012, "Azul Perolado", 85700, 25400.00);
            Veiculo carro3 = new Veiculo("Toyota", "Camry", 2020, "Cinza Ferro", 16320, 130000.00);
            Veiculo carro4 = new Veiculo("Chevrolet", "Camaro ZL1", 2022, "Preto Petróleo", 00620, 250000.00);
            Moto moto = new("Yamaha", "RD 350z", 350, 2022, "Vermelho/Branco", 0, 17950.00);
            Moto moto2 = new("Honda", "RR 1200", 1200, 2021, "Azul/Amarelo", 6350, 32650.00);

            //carro.Marca = "Fiat";
            //carro.Modelo = "Punto";
            //carro.Ano = 2017;
            //carro.Cor = "Branco Kalahari";
            //carro.km = 71750;
            //carro.Preco = 42000;

            Console.WriteLine();
            Console.WriteLine(carro);
            Console.WriteLine("--------------");
            Console.WriteLine(carro2);
            Console.WriteLine("--------------");
            Console.WriteLine(carro3);
            Console.WriteLine("--------------");
            Console.WriteLine(carro4);
            Console.WriteLine("--------------");
            Console.WriteLine(moto);
            Console.WriteLine("--------------");
            Console.WriteLine(moto2);
            Console.WriteLine();


        }
    }
}

