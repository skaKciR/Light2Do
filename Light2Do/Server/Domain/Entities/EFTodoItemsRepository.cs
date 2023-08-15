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
                new TodoItems() {Title = "Создать компонент razor", Author = "Алексей", DateAdded = DateTime.Now, Description="Просто добавить компнонент в проект", Id=new Guid(), IsDone = true},
                new TodoItems() {Title = "Написать код для компонента", Author = "Александр", DateAdded = DateTime.Now, Description="Добавить функционал", Id=new Guid(), IsDone = false},
                 new TodoItems() {Title = "Добавить компонент на страницу", Author = "Кирилл", DateAdded = DateTime.Now, Description="Вызвать компонент передав параметры", Id=new Guid(), IsDone = false},
                 new TodoItems() {Title = "Покормить кота", Author = "Кот", DateAdded = DateTime.Now, Description="Вкусно покормите кота", Id=new Guid(), IsDone = true},
                 new TodoItems() {Title = "Поиграть с котом", Author = "Кот", DateAdded = DateTime.Now, Description="Отвлекитесь от VS, поиграйте с котом", Id=new Guid(), IsDone = false}
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
