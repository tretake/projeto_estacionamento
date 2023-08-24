using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string p_Placa)
        {
            Placa = p_Placa;
        }
    }
}