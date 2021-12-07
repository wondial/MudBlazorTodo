using MudBlazorTodo.Models;
using MudBlazorTodo.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MudBlazorTodo.Services
{
    public class TodoTaskService
    {
        public List<TaskDto> LoadToday()
        {
            return RandomData();
        }

        public List<TaskDto> LoadStar()
        {
            return RandomData();
        }

        public List<TaskDto> LoadSearch(string title)
        {
            return RandomData();
        }

        private List<TaskDto> RandomData()
        {
            var taskDtos = new List<TaskDto>();
            Random r = new Random();
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(r.Next(0, 1));
                taskDtos.Add(new TaskDto
                {
                    Title = $"测试数据{i} {"".PadRight(r.Next(10), 'X')}",
                    Description = $"详细描述{i} {"".PadRight(r.Next(40), 'X')}",
                    PlanTime = DateTime.Now.Date.AddDays(r.Next(0, 4) * -1),
                    Deadline = ((r.Next(0, 2) == 0) ? (DateTime?)DateTime.Now.Date.AddDays(r.Next(-1, 3)) : null),
                    IsImportant = Convert.ToBoolean(r.Next(0, 2)),
                    TaskId = Guid.NewGuid(),
                });
            }
            return taskDtos;
        }
    }
}