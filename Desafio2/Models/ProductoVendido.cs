using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Models;

public class ProductosVendido
{
    public int Id { get; set; }
    public int IdProducto { get; set; }
    public decimal Stock { get; set; }
    public int IdVenta { get; set; }

}
