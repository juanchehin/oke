using System;
using System.Collections.Generic;
using System.Text;

namespace KaraokeApp.Modelo
{
  public  class Mpedidos
    {
        public int IdPedido { get; set; }
        public int IdMesa { get; set; }
        public int IdCancion { get; set; }
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }
}
