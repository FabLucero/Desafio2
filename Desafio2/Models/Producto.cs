using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Models;

public class Producto
{
    public int Id { get; set; }
    public string? Descripciones { get; set; }
    public double Costo { get; set; }
    public double PrecioVenta { get; set; }
    public double Stock { get; set; }
    public int IdUsuario { get; set; }
   
}