using System.ComponentModel.DataAnnotations;

namespace emtitiProjectSem3.Models
{
    public class ChangePwdModel
    {
        [Required(ErrorMessage = "Current Password is required.")]
        public string currentPassword { get; set; }

        [Required(ErrorMessage = "New PassWord is required.")]
        public string newPassword { get; set; }
    }
}
