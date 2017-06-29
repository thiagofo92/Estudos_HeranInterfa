using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosHeranInterfa
{
        abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }

        public Veiculo() { }

        abstract public void Andar();

        abstract public void Frear();

    }
}
