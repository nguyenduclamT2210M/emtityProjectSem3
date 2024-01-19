using System.ComponentModel.DataAnnotations;

namespace emtitiProjectSem3.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
}
