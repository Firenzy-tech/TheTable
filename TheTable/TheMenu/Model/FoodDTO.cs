namespace TheMenu.Model
{
    public class FoodDTO
    {
        public int Id { get; set; }
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UrlImagen { get; set; } = string.Empty;
        public DateTime Time { get; set; }
    }
}
