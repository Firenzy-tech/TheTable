namespace TheTable.Api.Models
{
    public class Waiter
    {
        public int Id { get; set; }
        public int WaiterID { get; set; }
        public string Name { get; set; }=string.Empty;
        public int TableID { get; set; }
    }
}
