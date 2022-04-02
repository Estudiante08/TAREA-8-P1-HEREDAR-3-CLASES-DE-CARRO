using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_8_P1_HEREDAR_3_CLASES_DE_CARRO.CLASES
{
    internal class TRAILER : Carro
    {

        public int CONTENEDOR { get; set; }
        public int CAPACIDAD { get; set; } = 0;
       
        public TRAILER(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }

        public string CONTENDOR()

        {
            return "EL CONTENEDOR FUE ANCLADO";
        }
    }
}
