namespace TheTable.Api.Models
{
    public class CashRegister
    {
        public int FoodID { get; set; }
        public string Name { get; set; } = string.Empty;    
        public string Description { get; set; } =string .Empty;
        public decimal Price { get; set; }
        public string Notes { get; set; }=string .Empty;
    }
}
