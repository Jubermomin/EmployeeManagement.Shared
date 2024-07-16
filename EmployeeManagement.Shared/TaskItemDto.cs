using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Shared
{
    public class TaskItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public EmployeeDto Employee { get; set; }
        public List<NoteDto> Notes { get; set; } = new List<NoteDto>();
        public List<DocumentDto> Documents { get; set; } = new List<DocumentDto>();
    }

}
