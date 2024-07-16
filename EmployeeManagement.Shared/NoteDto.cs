using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Shared
{
    public class NoteDto
    {
        public int NoteId { get; set; }

        public int TaskId { get; set; }

        public string Content { get; set; } = null!;

        public int CreatedByUserId { get; set; }

        public DateTime CreatedDate { get; set; }
    }


}
