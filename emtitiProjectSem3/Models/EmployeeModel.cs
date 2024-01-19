using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emtitiProjectSem3.Entities
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Full Name is required.")]
        public string fullname { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }

        [Required(ErrorMessage = "Rold Id is required.")]
        public int roleId { get; set; }

        [Required(ErrorMessage = "PostOffice Id is required.")]
        public int postOfficeId { get; set; }
    }
}
