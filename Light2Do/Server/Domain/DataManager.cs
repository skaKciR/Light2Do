using Light2Do.Server.Domain.Abstract;
using Microsoft.Extensions.Hosting;

namespace Light2Do.Server.Domain
{
    public class DataManager
    {
        public ITodoItemsRepository Todos { get; set; }
        public DataManager(ITodoItemsRepository todosRepository)
        {
            Todos = todosRepository;
        }
    }
}
