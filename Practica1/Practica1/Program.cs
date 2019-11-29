using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona p = new Persona();
      Console.WriteLine("Nombre: {0} Apellido: {1} Edad: {2}", p.nombre, p.apellido, p.getEdad());
      Console.ReadLine();
      Persona p2 = new Persona("Pepe", "Argento", 55);
      Console.WriteLine("Nombre: {0} Apellido: {1} Edad: {2}", p2.nombre, p2.apellido, p2.getEdad());
      Console.ReadLine();
      p2.cumplirAnios();
      Console.WriteLine("Nombre: {0} Apellido: {1} Edad: {2}", p2.nombre, p2.apellido, p2.getEdad());
      Console.ReadLine();
    }
  }
}
