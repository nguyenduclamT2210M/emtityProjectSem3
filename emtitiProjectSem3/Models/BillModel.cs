using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emtitiProjectSem3.Entities
{
    public class BillModel
    {
        public int userId { get; set; }

        [Required(ErrorMessage = "Shipping Add Id is required.")]
        public int shippingAddId { get; set; }

        [Required(ErrorMessage = "Delivery Add Id is required.")]
        public int deliveryAddId { get; set; }

        [Required(ErrorMessage = "Pickup Type is required.")]
        public string pickupType { get; set; }

        [Required(ErrorMessage = "Delivery Type is required.")]
        public string deliveryType { get; set; }

        [Required(ErrorMessage = "Payer is required.")]
        public string payer { get; set; }

        [Required(ErrorMessage = "Node is required.")]
        public string note { get; set; }

        [Required(ErrorMessage = "Cod is required.")]
        public double cod { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Nature is required.")]
        public string nature { get; set; }

        [Required(ErrorMessage = "Weight is required.")]
        public double weight { get; set; }

        [Required(ErrorMessage = "Length is required.")]
        public int length { get; set; }

        [Required(ErrorMessage = "Width is required.")]
        public int width { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        public int height { get; set; }

        [Required(ErrorMessage = "Value is required.")]
        public double value { get; set; }
    }
}
