using Desafio2.Contexts;
using Desafio2.Models;
using Microsoft.Data.SqlClient;
using System;

namespace Desafio2.Database;

public  class UsuarioData
{

    private  CoderhouseDbContext _context = new CoderhouseDbContext();

    public UsuarioData()
    {
        _context = new CoderhouseDbContext();
    }

    public Usuario? GetOneUser(int id)
    {
        return _context.Usuario.FirstOrDefault(usuario => usuario.Id == id);
    }

    public List<Usuario> GetUserBy(string filtro)
    {
        return _context.Usuario
            .Where(usuario => usuario.NombreUsuario.Contains(filtro))
            .ToList();

    }

    public  List<Usuario> ListUsers()
    {
       return _context.Usuario.ToList();
    }
   
    public  void CreateUser(Usuario usuario)
    {
        _context.Usuario.Add(usuario);
        _context.SaveChanges();        
    }

    public  void UpdateUser(int id, Usuario usuario)
    {
        _context.Usuario.Update(usuario);
        _context.SaveChanges();        
    }

    public  void DeleteUser(int id)
    {
        var usuario = GetOneUser(id);
        if (usuario != null)
        {
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }       
    }
}


