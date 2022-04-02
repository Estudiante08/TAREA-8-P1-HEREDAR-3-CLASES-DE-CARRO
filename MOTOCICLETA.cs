using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_8_P1_HEREDAR_3_CLASES_DE_CARRO.CLASES
{
    internal class MOTOCICLETA : Carro

    {
        public int VELOCIDAD { get; set; }
        public int VIENTO { get; set; } = 0;
       
        public MOTOCICLETA(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }
        public string ADRENALINA()

        {
            return "SIENTES LA VELOCIDAD EN EL ROSTRO";
        }
    }
}
