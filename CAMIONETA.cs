using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_8_P1_HEREDAR_3_CLASES_DE_CARRO.CLASES
{
    internal class CAMIONETA : Carro
    {

        public int CANTIDAD { get; set; }
        public int CAPACIDAD { get; set; } = 0;
       
        public CAMIONETA(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }

        public string PERSONAS()

        {
            return "VAS LLENO LLEVAS A 60 PERSONAS";
        }
    }
}
