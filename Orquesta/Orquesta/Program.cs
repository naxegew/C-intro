using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Orquesta Orquesta2 = new Orquesta("Orquesta Teatro Colon", "Teatro Colon", Orquesta.TipoOrquesta.Camara);
      Orquesta orquesta = new Orquesta("Orquesta de Nacho", "mi  casa", Orquesta.TipoOrquesta.Filarmonica);
      Console.WriteLine("\nNombre de  Orquesta {0} Lugar: {1}  Tipo {2}", Orquesta2.nombre, Orquesta2.lugar, Orquesta2.tipo);
      Console.ReadLine();
      Instrumento instrumento = new Instrumento("flauta", Instrumento.TipoInstrumento.Aire);
      Instrumento instrumentoGatita = new Instrumento("tamborcito", Instrumento.TipoInstrumento.Percusion);
      Musico musico = new Musico("Pepe", "Argento", 50, instrumento);
      Musico musico2 = new Musico("Joaquin", "Gil", 28, instrumento);
      Musico musico3 = new Musico("Gatita","gatita", 1, instrumentoGatita);
      Console.WriteLine("nombre del musico {0}, Apellido {1}, Edad: {2} \n Instrumento: {3}, tipo:{4} \n",
        musico.nombre, musico.apellido, musico.edad, musico.instrumento.nombre, musico.instrumento.tipo);
      Console.ReadLine();
      Orquesta2.musicos.Add(musico);
      Orquesta2.musicos.Add(musico2);
      orquesta.musicos.Add(musico);
      orquesta.musicos.Add(musico2);
      orquesta.musicos.Add(musico3);
      Orquesta.ImprimirOrquesta(Orquesta2);
      Orquesta.ImprimirOrquesta(orquesta);

    }
  }
}
