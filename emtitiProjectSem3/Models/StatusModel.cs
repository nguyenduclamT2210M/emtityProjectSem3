using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emtitiProjectSem3.Entities
{
    public class StatusModel
    {
        public int typeId { get; set; }

        [Required(ErrorMessage = "Employee Id is required.")]
        public int employeeId { get; set; }

        [Required(ErrorMessage = "Bill Id is required.")]
        public int billId { get; set; }
    }
}
