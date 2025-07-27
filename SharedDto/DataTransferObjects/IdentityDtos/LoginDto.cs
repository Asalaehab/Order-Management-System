using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects.IdentityDtos
{
    public class LoginDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;
        [Required]

        public string Password { get; set; }=null!;
    }
}
