using GamelistApp1.Domain.Interfaces;
using GamelistApp1.Domain.Models;

namespace GamelistApp1.Business.Services;

public class GameService : IService<Game>
{
    public List<Game> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Game> GetTop100()
    {
        throw new NotImplementedException();
    }

    public List<Game> SearchByQuery(string query)
    {
        throw new NotImplementedException();
    }

    public Game GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Game Create(Game entity)
    {
        throw new NotImplementedException();
    }

    public Game Update(Game entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}