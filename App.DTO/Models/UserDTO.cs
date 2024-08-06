using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO.Models
{
    public class UserDTO
    {
        public Guid UserId { get; set; }

        //public string? Name { get; set; }

        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
