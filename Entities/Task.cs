namespace GeekyMon2.Tasker.Entities
{
    class Task
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}