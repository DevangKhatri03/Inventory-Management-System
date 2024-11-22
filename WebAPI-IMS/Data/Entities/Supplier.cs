namespace WebAPI_IMS.Data.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
