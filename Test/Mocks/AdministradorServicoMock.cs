using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks;

public class AdministradorServicoMock : IAdministradorServico
{
    private static List<Administrador> administradores = new List<Administrador>(){
        new Administrador {
            Id = 1,
            Email = "admin@test.com",
            Senha = "123456",
            Perfil = "Adm"
        },
         new Administrador {
            Id = 2,
            Email = "editor@test.com",
            Senha = "123456",
            Perfil = "Editor"
        }
    };

    public void Apagar(Administrador administrador)
    {
        administradores.Remove(administrador);
    }

    public void Atualizar(Administrador administrador)
    {
        var index = administradores.FindIndex(a => a.Id == administrador.Id);
        if (index != -1)
        {
            administradores[index] = administrador;
        }
    }

    public Administrador? BuscaPorId(int id)
    {
        return administradores.Find(a => a.Id == id);
    }

    public Administrador Incluir(Administrador administrador)
    {
        administrador.Id = administradores.Count() + 1;
        administradores.Add(administrador);
        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        return administradores.Find(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
    }

    public List<Administrador> Todos(int? pagina)
    {
        return administradores;
    }
}
