using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emtitiProjectSem3.Entities
{
    public class DateTimeRequiest
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Month is required.")]
        public int month { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public int year { get; set; }
       
    }
}
