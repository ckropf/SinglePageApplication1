Public Class TodoInitializer
    Inherits System.Data.Entity.DropCreateDatabaseIfModelChanges(Of TodoItemContext)

    Protected Overrides Sub Seed(context As TodoItemContext)
        Dim lists As New List(Of TodoList) From {New TodoList() With {.TodoListId = 1, .UserId = "chad", .Title = "Default todo list"}}

        lists.ForEach(Function(l) context.TodoLists.Add(l))
        context.SaveChanges()

        Dim items As New List(Of TodoItem) From {
            New TodoItem() With {.TodoItemId = 1, .Title = "Default todo 1", .IsDone = False, .TodoListId = 1},
            New TodoItem() With {.TodoItemId = 2, .Title = "Default todo 2", .IsDone = False, .TodoListId = 1},
            New TodoItem() With {.TodoItemId = 3, .Title = "Default todo 3", .IsDone = False, .TodoListId = 1}}

        items.ForEach(Function(i) context.TodoItems.Add(i))
        context.SaveChanges()
    End Sub
End Class
