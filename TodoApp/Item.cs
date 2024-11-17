namespace TodoApp
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public Item(int id, string title, bool status = false)
        {
            Id = id;
            Title = title;
            Completed = status;
        }

        public override string ToString()
        {
            string describe = $"{Id}). {Title} (Completed: {Completed}).";
            return describe;
        }
    }
}