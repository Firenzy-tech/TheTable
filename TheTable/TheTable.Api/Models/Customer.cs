namespace TheTable.Api.Models
{
    public class Customer
    {   
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Preference { get; set; } =string.Empty;

    }
}
