using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeRol
{
    class Personaje
    {
        //Datos
        int velocidad; //1 a 10
        int destreza; //1 a 5
        int fuerza; //1 a 10
        int nivel; //1 a 10
        int armadura; //1 a 10

        //Caracteristicas
        string tipo;
        string nombre;
        string apodo;
        DateTime fechadenacimiento;
        int salud; //100

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Salud { get => salud; set => salud = value; }
    }
}
