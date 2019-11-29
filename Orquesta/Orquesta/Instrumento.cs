using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Instrumento
  {
    public string nombre;
    public TipoInstrumento tipo;
    public enum TipoInstrumento { Aire, Cuerda, Percusion}

    public Instrumento()
    {

    }
    public Instrumento( string nombre, TipoInstrumento tipo)
    {
      this.nombre = nombre;
      this.tipo = tipo;
    }
  }
}
