using System.Collections.Generic;
using System.Threading.Tasks;
using crud_opration.Models;

namespace crud_opration.Repository
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskModel>> GetTasks();
        Task<TaskModel> GetTaskById(int id);
        Task<int> AddTask(TaskModel task);
        Task<int> UpdateTask(int id, TaskModel task);
        Task<int> DeleteTask(int id);
    }
}
