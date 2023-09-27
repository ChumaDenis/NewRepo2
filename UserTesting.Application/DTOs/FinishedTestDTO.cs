using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.DTOs
{
    public class FinishedTestDTO
    {
        public Guid TestId { get; set; }
        public List<TestTaskDTO> testTasks { get; set; }


    }
}
