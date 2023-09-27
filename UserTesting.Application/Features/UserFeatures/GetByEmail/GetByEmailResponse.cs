using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTesting.Application.Features.UserFeatures.GetByEmail
{
    public sealed record GetByEmailResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        
    }
}
