using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
  class Persona
  {
    private int edad;
    public string nombre;
    public string apellido;

    public Persona(string nombre, string apellido, int edad)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;

    }
    public Persona() { }
    public void setEdad(int edad)
    {
      this.edad = edad;
    }
    public void setNombre(string nombre)
    {
      this.nombre = nombre;
    }
    public void setApellido(string apellido)
    {
      this.apellido=apellido;
    }
    public int getEdad()
    {
      return this.edad;
    }
    public void cumplirAnios()
    {
      this.edad++;
    }

  }
}
