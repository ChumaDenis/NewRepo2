using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Common;

namespace UserTesting.Domain.Entities
{
    public class Test:BaseEntity
    {
        public string Title { get; set; }
        public List<TestTask> Tasks { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

}
