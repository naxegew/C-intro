using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Orquesta
  {
    public string nombre;
    public string lugar;
    public TipoOrquesta tipo;
    private int id;
    public enum TipoOrquesta { Sinfonica,Camara,Filarmonica}
    public List<Musico> musicos;

    public Orquesta()
    {
    }
    public Orquesta(string nombre, string lugar, TipoOrquesta tipo)
    {
      this.nombre = nombre;
      this.lugar = lugar;
      this.tipo = tipo;
      this.musicos = new List<Musico>();
    }
    public void setNombre(string nombre)
    {
      this.nombre = nombre;
    }
    public void setLugar(string lugar)
    {
      this.lugar = lugar;
    }
    public void setTipo(TipoOrquesta tipo)
    {
      this.tipo = tipo;
    }
    public string getOrquestaToStr()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Nombre: {0}.\n Lugar {1}.\n Tipo: {2} \n", this.nombre,this.lugar,this.tipo);

      return sb.ToString();  
    }
    public static void ImprimirOrquesta(Orquesta orquesta)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(orquesta.getOrquestaToStr());

      if(orquesta.musicos.Count>0)
      {
      sb.AppendFormat("Lista de Musicos \n");
        foreach (Musico element in orquesta.musicos)
        {
          sb.AppendFormat("Musico Nombre y Apellido: {0} {1} \n", element.nombre, element.apellido);
          sb.AppendFormat("Instrumento: {0}\n", element.instrumento.nombre);
        }
        Console.WriteLine("{0}", sb.ToString());
        Console.ReadLine();
      }

    }


  }
}
