namespace TheTable.Api.Models
{
    public class Food
    {
        public int Id { get; set; }
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
    }

}
