using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Common;

namespace UserTesting.Domain.Entities
{
    public class UserTest:BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid TestId { get; set; }
        public TestState TestState { get; set; }
        public int Mark { get; set; }
        public Test test { get; set; }
    }
    

    public enum TestState
    {
        Ready=0,
        Pass=1
    }
}
