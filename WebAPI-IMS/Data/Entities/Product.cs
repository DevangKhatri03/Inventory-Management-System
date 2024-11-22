namespace WebAPI_IMS.Data.Entities
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AmountInStock { get; set; }
        public int CategoryId { get; set; } // Foreign Key to Category
        public int SupplierId { get; set; } // Foreign Key to Supplier
        public decimal Discount { get; set; }

        // Navigation Properties
        public Category Category { get; set; } // Navigation to Category
        public Supplier Supplier { get; set; } // Navigation to Supplier
    }
}
