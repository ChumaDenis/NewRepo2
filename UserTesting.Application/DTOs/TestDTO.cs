using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.DTOs
{
    public class TestDTO
    {
        public Guid TestId { get; set; }
        public TestState TestState { get; set; }
        public string Title { get; set; }
    }
}
