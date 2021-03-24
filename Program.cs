using System;

namespace practica6._2
{
    // Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". 
    // También deberá tener un método "SetContacto", de tipo void y con los parámetros string, 
    // que permita cambiar el valor de los atributos. También tendrá un método "Saludar", que escribirá en pantalla 
    // "Hola, soy " seguido de sus datos. Crear también una clase llamada ProbarContacto. Esta clase deberá contener 
    //sólo la función Main, que creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá 
    // que saluden.

    class Contacto
    {
        
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Direccion;

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }


        public void Saludar()
        {
            Console.WriteLine($" Hola, soy {Nombre} {Apellido}");
            Console.WriteLine($" Mi telefon es: {Telefono}");
            Console.WriteLine($" Direccion: {Direccion}");

        }
    }

    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto pro = new Contacto();
            pro.Nombre = "Miguel";
            pro.Apellido = "Moreta";
            pro.Telefono = "829-455-9050";
            pro.Direccion = "Edificio Metropolitano I, Segundo Nivel, Av. 27 de Febrero, Santiago De Los Caballeros";
            pro.Saludar();


            Console.ReadKey();

        }
    }
   


}




