namespace TheTable.Api.Models
{
    public class Table
    {
        public int TableID { get; set; }
        public int CustomerID { get; set; }
        public int WaiterID { get; set; }
        public decimal Price { get; set; }
        public string TypePayment { get; set; }
        public int Seats { get; set; }
        public string Notes { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
