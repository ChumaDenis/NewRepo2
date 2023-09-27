using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Features.TestFeatures.CreateTest
{
    public sealed record CreateTestResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
