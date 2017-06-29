using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosHeranInterfa
{
    class Carro : Veiculo, IMecanica
    {
        public string StatusOk { get; set; }
        public string StatusProblema { get; set; }

        public Carro()
        {
            StatusOk = "OK";
            StatusProblema = "Defeito";
        }

        public Carro(string marca, string cor, string placa, string modelo)
        {
            Marca = marca;
            Cor = cor;
            Placa = placa;
            Modelo = modelo;
        }

        public override void Andar()
        {
            Console.WriteLine("\nO carro está andando");
        }

        public override void Frear()
        {
            Console.WriteLine("\nO carro está Freando");
        }

        // Verificar status do Acelerador do Carro
        public string AceleradorFuncionando(bool acelerador)
        {
            return acelerador ? StatusOk : StatusProblema;
        }

        // Verificar status do Freio Carro
        public string FreioFuncionando(bool freio)
        {
            return freio ? StatusOk : StatusProblema;
        }

        // Verificar status do Marcha do Carro
        public string MarchaFuncionando(bool marcha)
        {
            return marcha ? StatusOk : StatusProblema;
        }
    }
}
