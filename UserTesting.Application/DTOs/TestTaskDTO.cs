using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.DTOs
{
    public class TestTaskDTO
    {
        public Guid TestId { get; set; }
        public Guid AnswerId { get; set; }
    }
}
