using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Shared
{
    public partial class UserDto
    {
        public int? UserId { get; set; }

        public string? Name { get; set; } = null!;

        public string? Role { get; set; } = null!;

        public int? TeamId { get; set; }
    }
}
