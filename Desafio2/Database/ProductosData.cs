using Desafio2.Contexts;
using Desafio2.Models;

namespace Desafio2.Database;

public class ProductosData
{
    private  CoderhouseDbContext _context;

    public ProductosData()
    {
        _context = new CoderhouseDbContext();
    }

    public Producto? GetOneProduct(int id)
    {
        return _context.Producto.FirstOrDefault(producto => producto.Id == id);        
    }

    public  List<Producto> GetProductBy(string filtro)
   {
        return _context.Producto
            .Where(producto => producto.Descripciones.Contains(filtro))
            .ToList();

    }

    public List<Producto> ListProducts()
    {
        return _context.Producto.ToList();        
    }

    public  void InsertProduct(Producto producto)
    {        
        _context.Producto.Add(producto);
        _context.SaveChanges();        
    }

    public void UpdateProduct(int id, Producto producto)
    {
        _context.Producto.Update(producto);
        _context.SaveChanges();        
    }

    public void DeleteProduct(int id)
    {        
        var producto = GetOneProduct(id);
        if (producto != null)
        {
            _context.Producto.Remove(producto);
            _context.SaveChanges();
        }
    }
}




