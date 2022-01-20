using System.ComponentModel.DataAnnotations;

namespace TaskRegistrationSystem.Models
{
    public class Tasks
    {
        public int ID { get; set; }

        public string TaskName { get; set; }

        public string Programmer { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime IssueDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateFinished { get; set; }

        public string? QA { get; set; }

        public Tasks()
        {

        }
    }
}
