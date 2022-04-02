using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_8_P1_HEREDAR_3_CLASES_DE_CARRO.CLASES
{
   
internal class Carro
        {
            public string Marca { get; }
            public int Modelo { get; }
            public string owner { get; set; }
            public String Color { get; set; }

            private int Encendido = 0;
            private int velocidad_actual = 0;
            private int Disminuir = 140;
            private int Frenar = 0;
            private int Apagar = 0;
            private int personas = 60;
            public int MAXVELOCIDAD { get; }
            public int MAXVELOCIDAD1 { get; }
            public int MAXVELOCIDAD2 { get; }
        //CONSTRUCTOR
            public Carro(string _marca, int _modelo, string _color, int maxvel)
            {
                Marca = _marca;
                Modelo = _modelo;
                Color = _color;
                Encendido = 0;
                MAXVELOCIDAD = 90;
                MAXVELOCIDAD1 = 150;
                MAXVELOCIDAD2 = 500;
                
                this.velocidad_actual = 0;
            }
           

        public string acelerarTrailer()
            {
                string mensaje = "";
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    velocidad_actual += 10;
                    mensaje = $"vas a {velocidad_actual} KPH";
                }
                if(velocidad_actual == 100)
                {
                    velocidad_actual = 100;
                    mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
                }

                return mensaje;

            }
        public string DesacelerarTrailer()

        {
            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual -= 10;
                mensaje = $"Estas disminuyendo {velocidad_actual} KPH";
            }
            if (velocidad_actual > MAXVELOCIDAD)
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Deberias de desacelerar???";
            }

            return mensaje;


        }
        public string frenarTrailer()
        {
            if ( velocidad_actual == 0) 
            {
                return $"El trailer se freno ahora estas a {velocidad_actual} es decir parqueado";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual = 0;
                mensaje = $"frenaste ahora estas a {velocidad_actual} KPH";
            }
           

       
            return mensaje;

        }
        public int GetVelocidadActualTrailer()
            {
                return velocidad_actual;
            }
        public void EncenderMotorTrailer()
            {
                if (Encendido == 0)
                {
                    Encendido = 1;
                    velocidad_actual = 0;

                }
               
            }
        public String DameInformacionTrailer()
            {
                return $"Este trailer es un {Marca} modelo  {Modelo} color {Color} y Tu maxima velocidad es {MAXVELOCIDAD}"; ;
            }
        
        
        public void EncenderMotorCamioneta()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                velocidad_actual = 0;

            }

        }
        public string acelerarCamioneta()
        {
            string mensaje = "";
            if (velocidad_actual <= 150)
            {
                velocidad_actual += 15;
                mensaje = $"Aumentaste ahora vas a {velocidad_actual} KPH";
            }
            if (velocidad_actual == 150)
            {
                velocidad_actual = 150;
                mensaje = "TEN CUIDADO VAS A MAXIMA VELOCIDAD";
            }

            return mensaje;

        }
        public string DesacelerarCamioneta()

        {

            string mensaje = "";
            if (velocidad_actual <= 150)
            {
                velocidad_actual -= 15;
                mensaje = $"Bajaste velocidad vas a {velocidad_actual} KPH";
            }
            if (velocidad_actual > 150)
            {
                velocidad_actual = 150;
                mensaje = "Empieza a frenar ya, que bajaran psajeros???";
            }

            return mensaje;

        }
        public string frenarCamioneta()
        {
            if (velocidad_actual == 0)
            {
                return $"Haz llegado a tu destino";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual = 0;
                mensaje = $"Paraste {velocidad_actual} KPH";
            }



            return mensaje;

        }
        public int GetVelocidadActualCamioneta()
        {
            return velocidad_actual;
        }
        public string BajarSubir()
        {
            if (velocidad_actual == 0) ;

            {
                string mensaje = "";
                
                if (velocidad_actual == 0)
                {
                    velocidad_actual = 0;
                    mensaje = "BAJAN TODAS LAS PERSONAS";
                }
                
                return mensaje;

            }
        }
        public String DameInformacionCamioneta()
        {
            return $"La camionmeta es una {Marca} modelo  {Modelo} color {Color} y Tu maxima velocidad es {MAXVELOCIDAD}";
        }


        public void EncenderMotorMoto()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                velocidad_actual = 0;

            }

        }
        public string acelerarMoto()
        {
            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD2)
            {
                velocidad_actual += 50;
                mensaje = $"Aumentaste ahora vas a {velocidad_actual} KPH";
            }
            if (velocidad_actual > 500)
            {
                velocidad_actual = 500;
                mensaje = "Eres super veloz pero ten cuidado";
                return mensaje;

            }

            return mensaje;
        }
        public string DesacelerarMoto()

        {

            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD2)
            {
                velocidad_actual -= 50;
                mensaje = $"Bajaste velocidad Vas a  {velocidad_actual} KPH";
            }
            if (velocidad_actual > 500)
            {
                velocidad_actual = 500;
                mensaje = "ERES INCREIBLE??";
                return mensaje;

            }

            return mensaje;


        }
        public string FrenarMoto()
        {
            if (velocidad_actual == 0)
            {
                return $"Vaya travesia haz frenado tu moto";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD1)
            {
                velocidad_actual = 0;
                mensaje = $"frenaste ahora estas a {velocidad_actual} KPH";
            }



            return mensaje;

        }
        public int GetVelocidadActualMoto()
        {
            return velocidad_actual;
        }
        public string SuperVelocidad()

        
        {
            string mensaje = "";
            if (velocidad_actual == MAXVELOCIDAD) ;

            {
                velocidad_actual = MAXVELOCIDAD2;
                mensaje = "LO LOGRASTE VE, CORRE";
            }

            return mensaje;


        }
        public String DameInformacionMoto()
        {
            return $"Tu motocicleta es una {Marca} modelo  {Modelo} color {Color} y Tu maxima velocidad es {MAXVELOCIDAD}";
        }

    }
    }

