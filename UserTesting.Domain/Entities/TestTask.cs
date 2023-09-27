using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Common;

namespace UserTesting.Domain.Entities
{
    public class TestTask:BaseEntity
    {
        public Guid TestId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public List<AnswerOption> AnswerOptions { get; set; }
        public Guid CorrectAnswerId { get; set; }
    }

    public class AnswerOption
    {
        public Guid Id { get; set; }
        public Guid TestTaskId { get; set; }
        public string Text { get; set; }
    }

}
