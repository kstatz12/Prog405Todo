namespace Todo.Common.Requests
{
    public class CreateTaskRequest
    {
        public CreateTaskRequest(string name, string description, DateTime dueDate)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = dueDate;
        }

        public string Name { get; }
        public string Description { get; }
        public DateTime DueDate { get; }


        public bool IsValid()
        {
            if(string.IsNullOrWhiteSpace(this.Name))
            {
                return false;
            }

            if(this.DueDate <= DateTime.UtcNow)
            {
                return false;
            }
            return true;
        }
    }
}
