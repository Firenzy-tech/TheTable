using System.ComponentModel.DataAnnotations;

namespace TheTable.Api.Models
{
    public class Billing
    {
        public int BillingID { get; set; }
        public int TableID { get; set; }
        public int WaiterID { get; set; }
        public decimal Tocharge { get; set; }
        public decimal Tip { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPayment { get; set; }
        public string Notes { get; set; }
        public DateTime DateTime { get; set; }
    }

}
