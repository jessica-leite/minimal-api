using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.Dominio.Interfaces;


namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public List<Administrador> Login(LoginDTO loginDTO)
    {
        // Implementação do método de login
    }
}