using Light2Do.Shared;
namespace Light2Do.Server.Domain.Abstract
{
    public interface ITodoItemsRepository
    {
        public List<TodoItems> Get();
        public void Add(TodoItems item);
        public void Delete(Guid id); 
    }
}
