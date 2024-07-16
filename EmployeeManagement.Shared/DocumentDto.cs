using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Shared
{
    public class DocumentDto
    {
        public int DocId { get; set; }
        public string FileName { get; set; }
        public string Content { get; set; }
        public int TaskItemId { get; set; }
    }

}
