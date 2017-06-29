using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosHeranInterfa
{
    interface IMecanica
    {

        string AceleradorFuncionando(bool acelerador);

        string MarchaFuncionando(bool marcha);

        string FreioFuncionando(bool freio);

    }
}
