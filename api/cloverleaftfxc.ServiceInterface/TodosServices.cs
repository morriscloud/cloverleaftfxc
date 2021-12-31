using System;
using System.Linq;
using ServiceStack;
using cloverleaftfxc.ServiceModel;

namespace cloverleaftfxc.ServiceInterface;

public class TodosServices : Service
{
    public IAutoQueryData AutoQuery { get; set; }

    static readonly PocoDataSource<Todo> Todos = PocoDataSource.Create(new Todo[]
    {
        new () { Id = 1, Text = "Learn" },
        new () { Id = 2, Text = "Vue", IsFinished = true },
        new () { Id = 3, Text = "SSG!" },
    }, nextId: x => x.Select(e => e.Id).Max());

    public object Get(QueryTodos query)
    {
        var db = Todos.ToDataSource(query, Request);
        return AutoQuery.Execute(query, AutoQuery.CreateQuery(query, Request, db), db);
    }

    public Todo Post(CreateTodo request)
    {
        if (request.Text.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(request.Text));

        var newTodo = new Todo { Id = Todos.NextId(), Text = request.Text };
        Todos.Add(newTodo);
        return newTodo;
    }

    public Todo Put(UpdateTodo request)
    {
        var todo = request.ConvertTo<Todo>();
        Todos.TryUpdateById(todo, todo.Id);
        return todo;
    }

    // Handles Deleting the Todo item
    public void Delete(DeleteTodo request) => Todos.TryDeleteById(request.Id);

    public void Delete(DeleteTodos request) => Todos.TryDeleteByIds(request.Ids);
}
