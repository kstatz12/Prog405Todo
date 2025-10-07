using Todo.Common.Models;
using Todo.Common.Requests;

namespace Todo.Common.Services
{
    public interface ITaskService
    {
        Task CreateTaskAsync(CreateTaskRequest request);
    }

    public class TaskService : ITaskService
    {
        private readonly IFileDataService fileDataService;

        public TaskService(IFileDataService fileDataService)
        {
            this.fileDataService = fileDataService;
        }
        
        public async Task CreateTaskAsync(CreateTaskRequest request)
        {
            var model = TaskModel.CreateTask(request);
            await this.fileDataService.SaveAsync(model);
        }
    }
}
