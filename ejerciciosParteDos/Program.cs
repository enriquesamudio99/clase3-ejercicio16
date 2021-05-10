using System;

namespace ejerciciosParteDos
{

    class Program
    {
        class Persona
        {
            public string nombre;
            public string apellido;
            public int peso;

            public Persona(string nombre, string apellido, int peso)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.peso = peso;
            }
        }

        static void Main(string[] args)
        {

            int mayorOchenta = 0, menorOchenta = 0;

            Console.Write("Ingrese el numero de personas a ingresar: ");
            int cantidadPersonas = Convert.ToInt32(Console.ReadLine());

            Persona[] personas = new Persona[cantidadPersonas];

            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.Write("Ingrese el nombre de la Persona N° {0}: ", i + 1);
                string nombrePersona = Console.ReadLine();
                Console.Write("Ingrese el apellido de la persona N° {0}: ", i + 1);
                string apellidoPersona = Console.ReadLine();
                Console.Write("Ingrese el peso de la persona N° {0}: ", i + 1);
                int pesoPersona = Convert.ToInt32(Console.ReadLine());

                Persona persona = new Persona(nombrePersona, apellidoPersona, pesoPersona);

                personas[i] = persona;

            }

            foreach (Persona persona in personas)
            {
                if (persona.peso > 80)
                {
                    mayorOchenta++;
                } else
                {
                    menorOchenta++;
                }
            }

            Console.WriteLine("{0} persona/s pesan más de 80 kilos", mayorOchenta);
            Console.WriteLine("{0} persona/s pesan menos de 80 kilos", menorOchenta);

        }
    }
}
