using Desafio2.Contexts;
using Desafio2.Models;

namespace Desafio2.Database;

public class VentaData
{
    private CoderhouseDbContext _context;

    public VentaData()
    {
        _context = new CoderhouseDbContext();
    }

    public Venta? ObtenerVenta(int id)
    {
        return _context.Venta.FirstOrDefault(venta => venta.Id == id);
    }

    public List<Venta> ListarVentas()
    {
        return _context.Venta.ToList();
    }

    public void CrearVenta(Venta venta)
    {
        _context.Venta.Add(venta);
        _context.SaveChanges();
    }

    public void ModificarVenta(int id, Venta venta)
    {
        _context.Venta.Update(venta);
        _context.SaveChanges();
    }

    public void EliminarVenta(int id)
    {
        var venta = ObtenerVenta(id);
        if (venta != null)
        {
            _context.Venta.Remove(venta);
            _context.SaveChanges();
        }
    }
}


