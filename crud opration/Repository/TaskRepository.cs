using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using crud_opration.Data;
using crud_opration.Models;

namespace crud_opration.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DapperContext _context;

        public TaskRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskModel>> GetTasks()
        {
            var query = "SELECT TaskId, TaskName, Description, Status FROM Tasks";
            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<TaskModel>(query);
            }
        }

        public async Task<TaskModel> GetTaskById(int id)
        {
            var query = "SELECT TaskId, TaskName, Description, Status FROM Tasks WHERE TaskId = @Id";
            using (var connection = _context.CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<TaskModel>(query, new { Id = id });
            }
        }

        public async Task<int> AddTask(TaskModel task)
        {
            var query = "INSERT INTO Tasks (TaskName, Description, Status) VALUES (@TaskName, @Description, @Status)";
            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteAsync(query, task);
            }
        }

        public async Task<int> UpdateTask(int id, TaskModel task)
        {
            var query = @"
                UPDATE Tasks 
                SET TaskName = @TaskName, 
                    Description = @Description, 
                    Status = @Status 
                WHERE TaskId = @TaskId";

            using (var connection = _context.CreateConnection())
            {
                task.TaskId = id; // Ensure the correct ID is set
                return await connection.ExecuteAsync(query, task);
            }
        }

        public async Task<int> DeleteTask(int id)
        {
            var query = "DELETE FROM Tasks WHERE TaskId = @Id";
            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteAsync(query, new { Id = id });
            }
        }
    }
}
