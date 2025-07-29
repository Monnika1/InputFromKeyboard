namespace TaskApi
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        
    }
}
