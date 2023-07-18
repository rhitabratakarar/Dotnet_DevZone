using Todo.Interfaces;

namespace Todo.Classes
{
    internal class TodoElement : ITodoElement
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }
        public bool IsCompleted { get; set; }

        public TodoElement(int id, string name, string note, bool isCompleted)
        {
            this.Id = id;
            this.Name = name;
            this.Note = note;
            this.IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}\nName: {this.Name}\nNote: {this.Note}\nIsCompleted: {this.IsCompleted}";
        }
    }
}
