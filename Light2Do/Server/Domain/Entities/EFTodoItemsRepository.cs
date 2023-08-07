using Light2Do.Server.Domain.Abstract;
using Light2Do.Shared;
using System;
using System.Collections.Generic;

namespace Light2Do.Server.Domain.Entities
{
    public class EFTodoItemsRepository : ITodoItemsRepository
    {
        private readonly AppDbContext context;
        public EFTodoItemsRepository(AppDbContext context)
        {
            this.context = context;
            if (!context.TodoItems.Any())
            {
                context.TodoItems.AddRange(new List<TodoItems>()
            {
                new TodoItems() {Title = "Добавить ToDo", Author = "КК", DateAdded = DateTime.Now, Description="ОписаниеТут", Id=new Guid(), IsDone = true},
                new TodoItems() {Title = "Доделать ToDo", Author = "КК", DateAdded = DateTime.Now, Description="ДругоеОписаниеТут", Id=new Guid(), IsDone = false},
                 new TodoItems() {Title = "ПеределатьДоделанное", Author = "КК", DateAdded = DateTime.Now, Description="Какое-тоОписание", Id=new Guid(), IsDone = false}
            });
                context.SaveChanges();
            }
        }
        public List<TodoItems> Get()
        {
            return context.TodoItems.ToList();
        }
        public void Add(TodoItems item)
        {
            context.TodoItems.Add(item);
            context.SaveChanges();
        }
        public void Delete(Guid Id)
        {
            context.TodoItems.Remove(context.TodoItems.FirstOrDefault(x => x.Id == Id));
            context.SaveChanges();
        }

   
    }
}
