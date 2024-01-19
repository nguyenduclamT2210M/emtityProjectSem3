using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace emtitiProjectSem3.Entities
{
    public class EmpLoginModel
    {
        [Required(ErrorMessage = "User Name is required.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
}
