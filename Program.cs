using System;
namespace Program
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string identificacion;
        
        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public string getIdentificacion()
        {
            return this.identificacion;
        }

        public void setNombre( string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setIdentificacion(string identificacion)
        {
            this.identificacion = identificacion;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("El nombre completo es " + this.nombre + " " + this.apellido + ", \nedad  " + this.edad + ", identificacion: " + this.identificacion);

        }
    }
}