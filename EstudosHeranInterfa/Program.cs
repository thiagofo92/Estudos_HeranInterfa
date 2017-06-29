using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosHeranInterfa
{
    class Program
    {




        static void Main(string[] args)
        {
            
            int velocidadeCar = 5;
            bool statusCar = true;


            Veiculo car = new Carro("Ford", "Preto", "XBL-4587", "Mustang");
            IMecanica carMeca = new Carro();
            

            Console.WriteLine("Meu carro: \nMarca: {0} \nCor: {1} \nPlaca: {2} \nModelo: {3}", car.Marca, car.Cor, car.Placa, car.Modelo);

            if (velocidadeCar > 0)
                car.Andar();

            else
                car.Frear();

            Console.WriteLine("O acelerador está: " + carMeca.AceleradorFuncionando(statusCar));

            Console.WriteLine("O freio está: " + carMeca.FreioFuncionando(statusCar));

            Console.WriteLine("A marcha está: " + carMeca.MarchaFuncionando(statusCar));

        }

    }
}
