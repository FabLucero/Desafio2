using Desafio2.Models;
using Desafio2.Contexts;

namespace Desafio2.Database;

public class ProductoVendidoData
{

    private CoderhouseDbContext _context = new CoderhouseDbContext();

    public ProductoVendidoData()
    {
        _context = new CoderhouseDbContext();        
    }

    public ProductosVendido? ObtenerProductoVendido(int id)
    {
        return _context.ProductosVendido.FirstOrDefault(productov => productov.Id == id);
    }

    public List<ProductosVendido> ListarProductosVendidos()
    {
        return _context.ProductosVendido.ToList();
    }

    public void CrearProductoVendido(ProductosVendido productov)
    {
        _context.ProductosVendido.Add(productov);
        _context.SaveChanges();
    }

    public void ModificarProductoVendido(int id, ProductosVendido productov)
    {
        _context.ProductosVendido.Update(productov);
        _context.SaveChanges();
    }

    public void EliminarProductoVendido(int id)
    {
        var productov = ObtenerProductoVendido(id);
        if (productov != null)
        {
            _context.ProductosVendido.Remove(productov);
            _context.SaveChanges();
        }
    }
}


