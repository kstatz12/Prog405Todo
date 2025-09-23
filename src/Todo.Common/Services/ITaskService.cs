using Todo.Common.Requests;

namespace Todo.Common.Services
{
    public interface ITaskService
    {
        Task CreateTaskAsync(CreateTaskRequest request);
    }

    public class TaskService : ITaskService
    {
        public async Task CreateTaskAsync(CreateTaskRequest request)
        {
            await Task.CompletedTask;
        }
    }
}
