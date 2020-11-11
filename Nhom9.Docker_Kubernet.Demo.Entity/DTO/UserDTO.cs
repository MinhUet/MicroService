using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nhom9.Docker_Kubernet.Demo.Entity.DTO
{
    public class UserDTO
    {
        public string UserID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Fullname { get; set; }
    }
}
